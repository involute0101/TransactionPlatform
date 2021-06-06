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
        private string text;
        public bool modify = false;
        private Label label = new Label();
        private TextBox textBox = new TextBox();

        public string InputText
        {
            get { return text; }
            set { text = value; }
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
            label.Text = text;
            label.Location = new Point(0, 2);
            label.AutoSize = false;
            this.Controls.Add(label);
        }

        public void Modify()
        {
            this.Controls.Clear();
            textBox.Text = text;
            this.Controls.Add(textBox);
        }

        public void Save()
        {
            text = textBox.Text;
            this.Controls.Clear();
            label.Text = text;
            this.Controls.Add(label);
        }
    }
}
