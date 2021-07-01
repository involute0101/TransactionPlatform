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
using WinForm.Util;
using Message = WinForm.Util.Message;

namespace WinForm
{
    public partial class PageNews : UserControl
    {
        public PageNews()
        {
            InitializeComponent();
            bdsNews.DataSource = CommentService.GetMessage(Int32.Parse(StaticVar.USERID));
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            dgvNews.Height = panel2.Height - 40;
            dgvNews.Width = panel2.Width - 40;
        }

        private void dgvNews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Message message = (Message)dgvNews.Rows[e.RowIndex].DataBoundItem;
                Good good = GoodService.GetGoodByGoodId(message.GoodId);
                PageConsult pageConsult = new PageConsult(good,message.SenderId);
                Form form = new Form();                 //为form添加pageConsult,pageConsult不能单独显示
                form.Size = new Size(615, 370);        
                form.StartPosition = FormStartPosition.Manual;      //窗体的位置由Location属性决定
                form.Location = (Point)new Size(430,300);
                form.Controls.Add(pageConsult);
                form.ShowDialog();
            }

        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            bdsNews.DataSource = CommentService.GetMessage(Int32.Parse(StaticVar.USERID));
        }
    }
}
