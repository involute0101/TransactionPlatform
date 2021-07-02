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
    public partial class GoodsTable : UserControl
    {
        public string Username;
        public GoodsTable()
        {
            InitializeComponent();
            bdsGoods.DataSource = GoodService.GetGoodByUserId(Int32.Parse(StaticVar.USERID));
        }

        private void dgvGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Good good = (Good)dgvGoods.Rows[e.RowIndex].DataBoundItem;
                Form_Good form_Good = new Form_Good(good);
                form_Good.ShowDialog();
            }
        }
    }
}
