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
    public partial class ModifiedLabel : UserControl
    {
        //private string text;
        public bool modify = false;
        private Label label = new Label();
        private TextBox textBox = new TextBox();

        public string InputText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }
        public ModifiedLabel()
        {
            InitializeComponent();
        }

        private void ModifiedLabel_Load(object sender, EventArgs e)
        {
            label.Width = this.Width;
            textBox.Width = this.Width;
            label.Font = new System.Drawing.Font("幼圆", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            textBox.Font= new System.Drawing.Font("幼圆", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label.Location = new Point(0, 2);
            label.AutoSize = false;
            this.Controls.Add(label);
        }

        public void Modify()
        {
            this.Controls.Clear();
            textBox.Text = label.Text;
            this.Controls.Add(textBox);
        }

        public void Save()
        {
            label.Text = textBox.Text;
            this.Controls.Clear();
            this.Controls.Add(label);
        }

        public void ChangeSize(int width,int height)
        {
            label.AutoSize = false;
            label.Size = new Size(width, height);
            textBox.Multiline = true;
            textBox.Size = new Size(width, height);
        }
    }
}
