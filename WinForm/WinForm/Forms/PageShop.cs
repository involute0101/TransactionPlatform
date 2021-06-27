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
    public partial class PageShop : UserControl
    {
        public PageShop()
        {
            InitializeComponent();
            shopTable.bdsShop.DataSource = GoodService.GetAllGoods();
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            shopTable.Height = panel2.Height - 40;
            shopTable.Width = panel2.Width - 40;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxSearchOption.Items.ToString())
            {
                case "商品名称":
                    shopTable.bdsShop.DataSource = Search.SearchGoodByGoodName(GoodService.GetAllGoods(), txtSearch.Text);
                    break;
                case "商品状态":
                    shopTable.bdsShop.DataSource = Search.SearchGoodByGoodState(GoodService.GetAllGoods(), txtSearch.Text);
                    break;
                case "卖家姓名":
                    shopTable.bdsShop.DataSource = Search.SearchGoodBySalerName(GoodService.GetAllGoods(), txtSearch.Text);
                    break;
            }
        }
    }
}
