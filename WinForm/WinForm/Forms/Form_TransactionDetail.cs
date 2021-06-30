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

namespace WinForm
{
    public partial class Form_TransactionDetail : Form
    {
        private TransactionRecord transactionRecord = null;
        private PageConsult consultForm;
        public Form_TransactionDetail()
        {
            InitializeComponent();
        }

        public Form_TransactionDetail(TransactionRecord transactionRecord,bool sender,PageConsult consultForm)
        {
            this.transactionRecord = transactionRecord;
            this.consultForm = consultForm;
            InitializeComponent();
            if (sender == true)
            {
                btnSend.Show();
            }
            else
            {
                btnSend.Hide();
            }
        }

        private void Form_TransacationDetail_Load(object sender, EventArgs e)
        {
            lblGoodId.Text ="商品ID："+  transactionRecord.GoodId.ToString();
            lblGoodName.Text = "商品名称：" + transactionRecord.GoodName;
            lblBuyerId.Text = "买家ID：" + transactionRecord.BuyerId.ToString();
            lblSalerId.Text = "卖家ID：" + transactionRecord.SalerId.ToString();
            lblSalerName.Text = "卖家姓名：" + transactionRecord.SalerName;
            lblTime.Text = "交易时间：" + transactionRecord.Time;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            consultForm.sendTransactionDetail(transactionRecord.TransactionRecordId);
            this.Close();
        }
    }
}
