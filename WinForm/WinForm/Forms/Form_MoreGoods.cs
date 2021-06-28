using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApi.Models;
using WinForm.EntityClass;
using WinForm.Service;

namespace WinForm
{
    public partial class Form_MoreGoods : Form
    {
        private List<Good> list = new List<Good>();
        public Form_MoreGoods()
        {
            InitializeComponent();
            bdsMoreGoods.DataSource = list;
        }

        public Form_MoreGoods(string username,int goodId)
        {
            User user = UserService.GetUser(username);
            list = GoodService.GetGoodByUserId(user.UserId);
            Good tem = null;
            foreach(Good good in list)
            {
                if(good.GoodId==goodId)
                {
                    tem = good;
                }
            }
            list.Remove(tem);
            InitializeComponent();
            bdsMoreGoods.DataSource = list;
        }
        private void dgvMoreGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Good good = (Good)dgvMoreGoods.Rows[e.RowIndex].DataBoundItem;
                Form_Good form_Good= new Form_Good(good);
                form_Good.ShowDialog();
            }
        }
    }
}
