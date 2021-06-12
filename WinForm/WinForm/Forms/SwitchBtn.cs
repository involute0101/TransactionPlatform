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
    public partial class SwitchBtn : Label
    {
        public SwitchBtn()
        {
            this.Font = new System.Drawing.Font("幼圆", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void Switchbtn_MouseEnter(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("幼圆", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }

        private void Switchbtn_MouseLeave(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("幼圆", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }
    }
}
