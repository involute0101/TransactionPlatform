using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.EntityClass;
using WinForm.Service;
using WinForm.Tool;

namespace WinForm
{
    public partial class Form_Good : Form
    {
        private PageConsult pageConsult;
        private Good good = new Good();
        public Form_Good()
        {
            InitializeComponent();
        }

        public Form_Good(Good good)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.good = good;
            StaticVar.GOALUSERID = "" + good.SellerId;
            InitializeComponent();
        }

        private void Form_Good_Load(object sender, EventArgs e)
        {
            lblHeadName.Text = good.GoodName;
            picImg.Image = good.Image;
            lblName.Text = "姓名：" + good.GoodName;
            lblGoodId.Text = "编号：" + good.GoodId.ToString();
            lblState.Text = "状态：" + good.State;
            lblSellerId.Text = "卖家：" + good.SellerId.ToString();
            lblPrice.Text = "单价：" + good.Price.ToString();
            lblCount.Text = "数量：" + good.Count.ToString();
            lblDetail.Text = "商品详情：\n" + good.GoodDetailDesc;
        }

        private void btnGoodPage_Click(object sender, EventArgs e)
        {
            btnConsultPage.Image = Properties.Resources.咨询;
            btnGoodPage.Image = Properties.Resources.商_品_选中_;
            panelChoose.Controls.Remove(pageConsult);
            panelChoose.Controls.Add(panel2);
        }

        private void btnConsultPage_Click(object sender, EventArgs e)
        {
            btnConsultPage.Image = Properties.Resources.咨询中;
            btnGoodPage.Image = Properties.Resources.商_品_;
            //后续修改-->若已有聊天记录则读取，不新建
            pageConsult = new PageConsult();
            panelChoose.Controls.Remove(panel2);
            pageConsult.Dock = DockStyle.Fill;
            panelChoose.Controls.Add(pageConsult);
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (good.SellerId == Int32.Parse(StaticVar.USERID))
            {
                MessageBox.Show("无法收藏自己的商品喔……");
                return;
            }
            List<Good> collectList = CollectService.GetCollects(Int32.Parse(StaticVar.USERID));
            foreach (Good g in collectList)
                if (g.GoodId == good.GoodId)
                {
                    MessageBox.Show("您已经收藏过该商品！");
                    return;
                }
            Collect collect = new Collect(good.GoodId,good.SellerId,DateTime.Now);
            CollectService.AddCollect(collect);
            MessageBox.Show("收藏成功！");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(good.SellerId == Int32.Parse(StaticVar.USERID)) { MessageBox.Show("不可以购买自己的商品");return; }
            TransactionService.AddRecord(new TransactionRecord(good.GoodId, Int32.Parse(StaticVar.USERID),good.SellerId, DateTime.Now));           
            good.Count = good.Count-1;//更改商品数量
            if (good.Count == 0) good.State = "售罄";
            GoodService.AlterGood(good.GoodId, good);
            MessageBox.Show("购买成功！");
            this.Close();
        }
    }
}
