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

namespace WinForm
{
    public partial class ShopTable : UserControl
    {
        public ShopTable()
        {
            InitializeComponent();
            bdsShop.DataSource = GoodService.GetAllGoods();
        }

        private void dgvShop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                Good good = (Good)dgvShop.Rows[e.RowIndex].DataBoundItem;
                Form_Good form_Good = new Form_Good(good);
                form_Good.ShowDialog();
            }
            
        }
    }
}
