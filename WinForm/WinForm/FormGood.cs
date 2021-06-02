using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormGood : Form
    {
        private bool favorite = false;


        public FormGood()
        {
            InitializeComponent();
        }

        public FormGood(Good good)
        {
            lblGood.Text = good.name;
            this.Text = good.name;
            InitializeComponent();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            panel2.Height = this.Height - 107;
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if(favorite)
            {
                favorite = false;
                btnFavorite.BackgroundImage = Properties.Resources.收藏;
            }
            else
            {
                favorite = true;
                btnFavorite.BackgroundImage = Properties.Resources.已收藏_;
            }
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            Form form = new FormConsult();//参数
            form.ShowDialog();
        }

        private void FormGood_Load(object sender, EventArgs e)
        {
            panel2.Height = this.Height - 107;
        }
    }


    //临时
    public class Good
    {
        public string name { get; set; }
        public Good()
        {

        }
    }
}
