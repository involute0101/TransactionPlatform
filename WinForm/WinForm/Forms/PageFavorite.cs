using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Forms;
using WinForm.Service;
using WinForm.Tool;

namespace WinForm
{
    public partial class PageFavorite : UserControl
    {
        public PageFavorite()
        {
            InitializeComponent();
            goodsTable.bdsGoods.DataSource = CollectService.GetCollects(int.Parse(StaticVar.USERID));
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            goodsTable.Height = panel2.Height - 40;
            goodsTable.Width = panel2.Width - 40;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxSearchOption.Text)
            {
                case "商品名称":
                    goodsTable.bdsGoods.DataSource = Search.SearchGoodByGoodName(CollectService.GetCollects(int.Parse(StaticVar.USERID)), txtSearch.Text);
                    goodsTable.bdsGoods.ResetBindings(false);
                    break;
                case "商品状态":
                    goodsTable.bdsGoods.DataSource = Search.SearchGoodByGoodState(CollectService.GetCollects(int.Parse(StaticVar.USERID)), txtSearch.Text);
                    goodsTable.bdsGoods.ResetBindings(false);
                    break;
                case "卖家姓名":
                    goodsTable.bdsGoods.DataSource = Search.SearchGoodBySalerName(CollectService.GetCollects(int.Parse(StaticVar.USERID)), txtSearch.Text);
                    goodsTable.bdsGoods.ResetBindings(false);
                    break;
            }
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            goodsTable.bdsGoods.DataSource = CollectService.GetCollects(int.Parse(StaticVar.USERID));
        }

        public void RefreshFavorite()
        {
            goodsTable.bdsGoods.DataSource = CollectService.GetCollects(int.Parse(StaticVar.USERID));
        }
    }
}
