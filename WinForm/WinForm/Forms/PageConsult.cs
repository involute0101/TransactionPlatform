using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Entity;
using WinForm.EntityClass;
using WinForm.Service;
using WinForm.Tool;

namespace WinForm
{
    public partial class PageConsult : UserControl
    {
        CommunicationEntityService communicationEntityService = new CommunicationEntityService();
        ClientService clientService = new ClientService();

        private Good good;

        private int SenderId;

        System.Timers.Timer timer = new System.Timers.Timer();

        private DateTime StartTime;

        private List<TransactionRecord> transactionRecords = null;

        //咨询商家的聊天界面
        public PageConsult(Good good)
        {
            InitializeComponent();
            this.good = good;
            StartTime = DateTime.Now;
            Control.CheckForIllegalCrossThreadCalls = false;
            if (!clientService.notifyServer())
            {
                MessageBox.Show("服务器繁忙，请稍后重试", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                this.Hide();
                return;
            }
            //clientService.connectServer(ClientPrintImage,ClientPrint);
            //目标ID先为自己，进行测试
            communicationEntityService.sendIdentify(StaticVar.LOCALIPPORT, StaticVar.USERID, StaticVar.USERID);
            InitComment();
            initTimer();
        }

        //商家的聊天窗口
        public PageConsult(Good good,int senderId)
        {
            InitializeComponent();
            this.good = good;
            this.SenderId = senderId;
            StartTime = DateTime.Now;
            Control.CheckForIllegalCrossThreadCalls = false;
            if (!clientService.notifyServer())
            {
                MessageBox.Show("服务器繁忙，请稍后重试", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                this.Hide();
                return;
            }
            //clientService.connectServer(ClientPrintImage,ClientPrint);
            //目标ID先为自己，进行测试
            communicationEntityService.sendIdentify(StaticVar.LOCALIPPORT, StaticVar.USERID, StaticVar.USERID);
            InitComment();
            initTimer();

            //商家打开界面不显示交易记录列表
            if(good.SellerId== Int32.Parse(StaticVar.USERID))
            {
                cmbRecord.Hide();
            }
        }

        private void ClientPrint(string info)
        {
            if (textBox_showing.InvokeRequired)
            {
                Client.Print F = new Client.Print(ClientPrint);
                this.Invoke(F, new object[] { info });
            }
            else
            {
                if (info != null)
                {
                    textBox_showing.SelectionColor = Color.Green;
                    //textBox_showing.AppendText("me: "+"["+ DateTime.Now +"]\n");
                    textBox_showing.SelectionColor = Color.Black;
                    //textBox_showing.AppendText(info);

                    textBox_showing.AppendText(Environment.NewLine);
                    textBox_showing.ScrollToCaret();
                }
            }

        }

        private void ClientPrintImage(Image img)
        {
            this.textBox_showing.SelectionColor = Color.Green;
            this.textBox_showing.AppendText("我: " + "[" + DateTime.Now + "]\n");
            Clipboard.SetDataObject(img);
            textBox_showing.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
            this.textBox_showing.AppendText("\n");      
            this.textBox_showing.Focus();
        }

        /// <summary>
        /// 初始加载聊天记录
        /// </summary>
        private void InitComment()
        {
            int goodId = good.GoodId;
            this.textBox_showing.Clear();
            List<Comment> comments = CommentService.GetComment(goodId, Int32.Parse(StaticVar.USERID));
            foreach (Comment c in comments)
            {
                if (c.SenderId == Int32.Parse(StaticVar.USERID))
                {
                    textBox_showing.SelectionColor = Color.Green;
                    textBox_showing.AppendText("我: " + "[" + c.Time + "]\n");
                    textBox_showing.SelectionColor = Color.Black;
                    if (c.InfoType.Equals("Word")) textBox_showing.AppendText(c.WordRecords);
                    else if (c.InfoType.Equals("Image"))
                    {
                        Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
                        Clipboard.SetDataObject((Image)ImageTool.Deserialize(c.ImageByte));
                        textBox_showing.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
                    }
                }
                if (c.ReceiverId == Int32.Parse(StaticVar.USERID))
                {
                    textBox_showing.SelectionColor = Color.Green;
                    if (good.SellerId == Int32.Parse(StaticVar.USERID)) textBox_showing.AppendText("用户: " + "[" + c.Time + "]\n");
                    else textBox_showing.AppendText("卖家: " + "[" + c.Time + "]\n");
                    textBox_showing.SelectionColor = Color.Blue;
                    if (c.InfoType.Equals("Word")) textBox_showing.AppendText(c.WordRecords);
                    else if (c.InfoType.Equals("Image"))
                    {
                        Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
                        Clipboard.SetDataObject((Image)ImageTool.Deserialize(c.ImageByte));
                        textBox_showing.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
                    }
                }
                textBox_showing.AppendText(Environment.NewLine);
                textBox_showing.ScrollToCaret();
            }
        }

        /// <summary>
        /// 发送文字
        /// </summary>
        private void button_send_Click_1(object sender, EventArgs e)
        {
            communicationEntityService.SendInfoType("Word");
            clientService.connectServer(ClientPrintImage, ClientPrint);
            communicationEntityService.sendIdentify(StaticVar.LOCALIPPORT, StaticVar.USERID, StaticVar.USERID);
            //目标ID先为自己，进行测试           

            clientService.sendMessage(textBox_send.Text);
            Comment comment;
            if (good.SellerId == Int32.Parse(StaticVar.USERID))         //商家
            {
                comment = new Comment(good.GoodId, Int32.Parse(StaticVar.USERID), SenderId, DateTime.Now);
            }               
            else comment = new Comment(good.GoodId,Int32.Parse(StaticVar.USERID),good.SellerId,DateTime.Now);
            comment.InfoType = "Word";
            comment.WordRecords = textBox_send.Text;
            CommentService.AddComment(comment);
            
            textBox_send.Clear();
        }

        /// <summary>
        /// 发送图片
        /// </summary>
        private void btnSendImg_Click(object sender, EventArgs e)
        {
            communicationEntityService.SendInfoType("Image");
            clientService.connectServer(ClientPrintImage, ClientPrint);
            communicationEntityService.sendIdentify(StaticVar.LOCALIPPORT, StaticVar.USERID, StaticVar.USERID);

            OpenFileDialog openfile = new OpenFileDialog();
            Image imageComment = null;
            if (openfile.ShowDialog() == DialogResult.OK && (openfile.FileName != ""))
            {
                string file = openfile.FileName;
                //clientService.sendImage(file);
                imageComment = Image.FromFile(file);
            }

            Comment comment;
            if (good.SellerId == Int32.Parse(StaticVar.USERID))         //商家
            {
                comment = new Comment(good.GoodId, Int32.Parse(StaticVar.USERID), SenderId, DateTime.Now);
            }
            else comment = new Comment(good.GoodId, Int32.Parse(StaticVar.USERID), good.SellerId, DateTime.Now);
            comment.InfoType = "Image";
            comment.ImageByte =  ImageTool.Serialize(imageComment);
            if (comment.ImageByte == null) { MessageBox.Show("图片不能为空！"); return; }
            CommentService.AddComment(comment);
            openfile.Dispose();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Form_Map form_Map = new Form_Map();
            form_Map.ShowDialog();
        }

        /// <summary>
        /// 显示聊天记录
        /// </summary>
        private void GetComments(object source, System.Timers.ElapsedEventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(threadAppendComment));
            thread.SetApartmentState(ApartmentState.STA); //重点
            thread.Start();
        }
        private void threadAppendComment()         //使用STA线程来更新聊天记录
        {       
            int goodId = good.GoodId;
            List<Comment> comments = CommentService.GetComment(goodId, Int32.Parse(StaticVar.USERID));
            foreach (Comment c in comments)
            {
                if (c.SenderId == Int32.Parse(StaticVar.USERID) && c.Time.CompareTo(StartTime) > 0)       //发送者
                {
                    textBox_showing.SelectionColor = Color.Green;
                    textBox_showing.AppendText("我: " + "[" + c.Time + "]\n");
                    textBox_showing.SelectionColor = Color.Black;
                    if (c.InfoType.Equals("Word")) textBox_showing.AppendText(c.WordRecords);
                    else if (c.InfoType.Equals("Image"))
                    {                    
                        Clipboard.SetDataObject((Image)ImageTool.Deserialize(c.ImageByte));
                        textBox_showing.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
                    }
                    textBox_showing.AppendText(Environment.NewLine);
                    textBox_showing.ScrollToCaret();
                    StartTime = c.Time;     //刷新时间，避免重复读取聊天记录
                }
                if (c.ReceiverId == Int32.Parse(StaticVar.USERID) && c.Time.CompareTo(StartTime) > 0)       //接收者
                {
                    textBox_showing.SelectionColor = Color.Green;
                    if (good.SellerId == Int32.Parse(StaticVar.USERID)) textBox_showing.AppendText("用户: " + "[" + c.Time + "]\n");
                    else textBox_showing.AppendText("卖家: " + "[" + c.Time + "]\n");
                    textBox_showing.SelectionColor = Color.Blue;
                    if (c.InfoType.Equals("Word")) textBox_showing.AppendText(c.WordRecords);
                    else if (c.InfoType.Equals("Image"))
                    {
                        Clipboard.SetDataObject((Image)ImageTool.Deserialize(c.ImageByte));
                        textBox_showing.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
                    }
                    textBox_showing.AppendText(Environment.NewLine);
                    textBox_showing.ScrollToCaret();
                    StartTime = c.Time;
                }
            }
        }

        //初始化定时器
        private void initTimer()
        {
            timer.Enabled = true;
            timer.Interval = 1000;//执行间隔时间,单位为毫秒
            timer.AutoReset = true;     //重复执行  
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(GetComments);
        }

        private void btnMoreGoods_Click(object sender, EventArgs e)
        {
            Form_MoreGoods form_MoreGoods = new Form_MoreGoods(good.SellerName, good.GoodId);
            form_MoreGoods.ShowDialog();
        }

        private void cmbRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var t in transactionRecords)
            {
                if(t.GoodId.ToString()==cmbRecord.Text)
                {
                    Form_TransactionDetail form_TransactionDetail = new Form_TransactionDetail(t,true);
                    form_TransactionDetail.ShowDialog();
                }
            }
        }

        private void PageConsult_Load(object sender, EventArgs e)
        {
             transactionRecords= TransactionService.GetAllRecordsByBuyerId(Int32.Parse(StaticVar.USERID));
            foreach (var t in transactionRecords)
            {
                if (t.SalerId != good.SellerId)
                {
                    transactionRecords.Remove(t);
                }
            }
            foreach (var t in transactionRecords)
            {
                cmbRecord.Items.Add(t.GoodId.ToString());
            }
        }
    }
}
