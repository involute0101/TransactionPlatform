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

namespace WinForm.Forms
{
    public partial class Form_Buyer : Form
    {
        public Good good;
        public Form_Buyer(Good good)
        {
            InitializeComponent();
            this.good = good;
            for(int i=1;i<=good.Count;i++)
            {
                cbxAmount.Items.Add(i);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            good.Count = good.Count - int.Parse(cbxAmount.SelectedItem.ToString());//更改商品数量
            if (good.Count == 0) good.State = "售罄";
            TransactionService.AddRecord(new TransactionRecord(good.GoodId, Int32.Parse(StaticVar.USERID), good.SellerId, DateTime.Now));
            FormControl.pageRecord.RefreshRecord();
            FormControl.form_Good.RefreshGood(this.good.Count.ToString(),this.good.State);
            FormControl.form_Main.Refreshshop();

            GoodService.AlterGoodByBuyer(good.GoodId, good);//买家买完，修改商品数量及状态
            MessageBox.Show("购买成功！");
            this.Close();
        }
    }
}
