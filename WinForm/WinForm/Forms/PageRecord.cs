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
    public partial class PageRecord : UserControl
    {
        public PageRecord()
        {
            InitializeComponent();
            bdsRecord.DataSource = TransactionService.GetAllRecordsByBuyerId(int.Parse(StaticVar.USERID));
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            dgvRecord.Height = panel2.Height - 40;
            dgvRecord.Width = panel2.Width - 40;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxSearchOption.Text)
            {
                case "商品编号":
                    bdsRecord.DataSource = Search.SearchRecordByGoodId(TransactionService.GetAllRecordsByBuyerId(int.Parse(StaticVar.USERID)), int.Parse(txtSearch.Text));
                    bdsRecord.ResetBindings(false);
                    break;
                case "商品名称":
                    bdsRecord.DataSource = Search.SearchRecordByGoodName(TransactionService.GetAllRecordsByBuyerId(int.Parse(StaticVar.USERID)), txtSearch.Text);
                    bdsRecord.ResetBindings(false);
                    break;
                case "卖家姓名":
                    bdsRecord.DataSource = Search.SearchRecordBySalerName(TransactionService.GetAllRecordsByBuyerId(int.Parse(StaticVar.USERID)), txtSearch.Text);
                    bdsRecord.ResetBindings(false);
                    break;
            }
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            bdsRecord.DataSource = TransactionService.GetAllRecordsByBuyerId(int.Parse(StaticVar.USERID));
        }
    }
}
