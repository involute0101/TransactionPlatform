﻿using System;
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
        private bool modifyGood = false;
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
            lblHeadName.InputText = good.GoodName;
            picImg.Image = good.Image;
            lblName.InputText =  good.GoodName;
            lblGoodId.Text = good.GoodId.ToString();
            lblState.InputText = good.State;
            lblSellerId.Text =good.SellerId.ToString();
            lblPrice.InputText = good.Price.ToString();
            lblCount.InputText = good.Count.ToString();
            lblDetail.InputText = "商品详情：\n" + good.GoodDetailDesc;
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
            if(good.SellerId == Int32.Parse(StaticVar.USERID))
            {
                MessageBox.Show("您是商品的售卖者噢……");
                return;
            }
            btnConsultPage.Image = Properties.Resources.咨询中;
            btnGoodPage.Image = Properties.Resources.商_品_;
            //后续修改-->若已有聊天记录则读取，不新建 
            //修改：聊天记录在PageConsult中读取
            pageConsult = new PageConsult(good);
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
            Collect collect = new Collect(good.GoodId, Int32.Parse(StaticVar.USERID), DateTime.Now);
            CollectService.AddCollect(collect);
            FormControl.pageFavorite.RefreshFavorite();
            MessageBox.Show("收藏成功！");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(good.SellerId == Int32.Parse(StaticVar.USERID)) { MessageBox.Show("不可以购买自己的商品");return; }
            if (good.Count>0) good.Count = good.Count - 1;//更改商品数量
            else return;
            TransactionService.AddRecord(new TransactionRecord(good.GoodId, Int32.Parse(StaticVar.USERID),good.SellerId, DateTime.Now));
            FormControl.pageRecord.RefreshRecord();
            if (good.Count == 0) good.State = "售罄";
            GoodService.AlterGoodByBuyer(good.GoodId, good);//买家买完，修改商品数量及状态
            MessageBox.Show("购买成功！");
            this.Close();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if (this.good.SellerId != int.Parse(StaticVar.USERID)) 
            { MessageBox.Show("不允许修改！"); return; }

            if (modifyGood)
            {
                modifyGood = false;
                lblName.Save();
                lblState.Save();
                lblPrice.Save();
                lblCount.Save();
                lblDetail.Save();
                good.GoodName = lblName.InputText;
                good.State = lblState.InputText;
                good.Price = int.Parse(lblPrice.InputText);
                good.Count = int.Parse(lblPrice.InputText);
                GoodService.AlterGood(good.GoodId, good);
            }
            else
            {
                int newPrice,newCount;
                lblName.Modify();
                lblState.Modify();
                lblPrice.Modify();
                lblCount.Modify();
                lblDetail.Modify();
                if (!int.TryParse(lblPrice.InputText, out newPrice)) { MessageBox.Show("错误价格！"); return; }
                if (!int.TryParse(lblCount.InputText,out newCount)) { MessageBox.Show("错误数量！"); return; }
                modifyGood = true;
            }
        }
    }
}
