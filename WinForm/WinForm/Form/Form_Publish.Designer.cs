
namespace WinForm
{
    partial class Form_Publish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGoodNumber = new System.Windows.Forms.TextBox();
            this.txtGoodPrice = new System.Windows.Forms.TextBox();
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelbg = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.btnAddGood = new WinForm.ImageBtn();
            this.btnAddImage = new WinForm.ImageBtn();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelbg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtGoodNumber);
            this.panel5.Controls.Add(this.txtGoodPrice);
            this.panel5.Controls.Add(this.txtGoodName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 100);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "价格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "商品名：";
            // 
            // txtGoodNumber
            // 
            this.txtGoodNumber.Location = new System.Drawing.Point(93, 72);
            this.txtGoodNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGoodNumber.Name = "txtGoodNumber";
            this.txtGoodNumber.Size = new System.Drawing.Size(100, 25);
            this.txtGoodNumber.TabIndex = 2;
            // 
            // txtGoodPrice
            // 
            this.txtGoodPrice.Location = new System.Drawing.Point(93, 38);
            this.txtGoodPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGoodPrice.Name = "txtGoodPrice";
            this.txtGoodPrice.Size = new System.Drawing.Size(100, 25);
            this.txtGoodPrice.TabIndex = 1;
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(93, 0);
            this.txtGoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(100, 25);
            this.txtGoodName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBoxImage);
            this.panel1.Controls.Add(this.btnAddImage);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 100);
            this.panel1.TabIndex = 4;
            // 
            // panelbg
            // 
            this.panelbg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelbg.Controls.Add(this.btnAddGood);
            this.panelbg.Controls.Add(this.textBox1);
            this.panelbg.Controls.Add(this.label5);
            this.panelbg.Controls.Add(this.panel1);
            this.panelbg.Location = new System.Drawing.Point(31, 22);
            this.panelbg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelbg.Name = "panelbg";
            this.panelbg.Size = new System.Drawing.Size(540, 300);
            this.panelbg.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 150);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 104);
            this.textBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("幼圆", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "商品详情：";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.Location = new System.Drawing.Point(406, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(106, 105);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // btnAddGood
            // 
            this.btnAddGood.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddGood.ChangeState = false;
            this.btnAddGood.Image = global::WinForm.Properties.Resources.发布商品;
            this.btnAddGood.ImageChecked = null;
            this.btnAddGood.ImageNormal = null;
            this.btnAddGood.Location = new System.Drawing.Point(239, 259);
            this.btnAddGood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(40, 38);
            this.btnAddGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddGood.TabIndex = 7;
            this.btnAddGood.TabStop = false;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Pink;
            this.btnAddImage.ChangeState = false;
            this.btnAddImage.Image = global::WinForm.Properties.Resources.添加;
            this.btnAddImage.ImageChecked = null;
            this.btnAddImage.ImageNormal = null;
            this.btnAddImage.Location = new System.Drawing.Point(358, 3);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(27, 26);
            this.btnAddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddImage.TabIndex = 4;
            this.btnAddImage.TabStop = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click_1);
            // 
            // Form_Publish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 348);
            this.Controls.Add(this.panelbg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(618, 395);
            this.MinimumSize = new System.Drawing.Size(618, 395);
            this.Name = "Form_Publish";
            this.Opacity = 0.97D;
            this.Text = "发布商品";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelbg.ResumeLayout(false);
            this.panelbg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGoodNumber;
        private System.Windows.Forms.TextBox txtGoodPrice;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.Panel panel1;
        private ImageBtn btnAddImage;
        private System.Windows.Forms.Panel panelbg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private ImageBtn btnAddGood;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}