using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Service;
using WinForm.Tool;

namespace WinForm
{
    public partial class PageConsult : UserControl
    {
        CommunicationEntityService communicationEntityService = new CommunicationEntityService();
        ClientService clientService = new ClientService();
        public PageConsult()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            if (!clientService.notifyServer())
            {
                MessageBox.Show("服务器繁忙，请稍后重试", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                this.Hide();
                return;
            }
            //clientService.connectServer(ClientPrintImage,ClientPrint);
            //目标ID先为自己，进行测试
            communicationEntityService.sendIdentify(StaticVar.LOCALIPPORT, StaticVar.USERID, StaticVar.GOALUSERID);
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
                    textBox_showing.AppendText(info);
                    textBox_showing.AppendText(Environment.NewLine);
                    textBox_showing.ScrollToCaret();
                }
            }

        }

        private void ClientPrintImage(Image img)
        {
            Clipboard.SetDataObject(img);
            textBox_showing.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
            this.textBox_showing.AppendText("\n");
            this.textBox_showing.Focus();
        }

        private void button_send_Click_1(object sender, EventArgs e)
        {
            communicationEntityService.SendInfoType("Word");
            clientService.connectServer(ClientPrintImage, ClientPrint);
            communicationEntityService.sendIdentify(StaticVar.LOCALIPPORT, StaticVar.USERID, StaticVar.GOALUSERID);
            //目标ID先为自己，进行测试           

            clientService.sendMessage(textBox_send.Text);
            textBox_send.Clear();
        }

        private void btnSendImg_Click(object sender, EventArgs e)
        {
            communicationEntityService.SendInfoType("Image");
            clientService.connectServer(ClientPrintImage, ClientPrint);
            communicationEntityService.sendIdentify(StaticVar.LOCALIPPORT, "1", "1");

            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK && (openfile.FileName != ""))
            {
                string file = openfile.FileName;
                clientService.sendImage(file);
            }
            openfile.Dispose();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {

        }
    }
}
