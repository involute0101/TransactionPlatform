
namespace WinForm
{
    partial class SubPagePublish
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGood = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtGood = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.buttonPublish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Location = new System.Drawing.Point(20, 20);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(67, 15);
            this.lblGood.TabIndex = 0;
            this.lblGood.Text = "商品名：";
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(20, 50);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(82, 15);
            this.lblPicture.TabIndex = 1;
            this.lblPicture.Text = "添加图片：";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20, 201);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(82, 15);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "商品详情：";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 305);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 15);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "价格：";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(20, 347);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "数量：";
            // 
            // txtGood
            // 
            this.txtGood.Location = new System.Drawing.Point(90, 15);
            this.txtGood.Name = "txtGood";
            this.txtGood.Size = new System.Drawing.Size(270, 25);
            this.txtGood.TabIndex = 5;
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInfo.Location = new System.Drawing.Point(107, 191);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(690, 94);
            this.txtInfo.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 25);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 344);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(270, 25);
            this.textBox4.TabIndex = 8;
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Location = new System.Drawing.Point(23, 83);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(91, 85);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 10;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonPublish
            // 
            this.buttonPublish.Location = new System.Drawing.Point(323, 375);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(127, 43);
            this.buttonPublish.TabIndex = 11;
            this.buttonPublish.Text = "确认发布";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // SubPagePublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.pictureBoxAdd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtGood);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.lblGood);
            this.Name = "SubPagePublish";
            this.Size = new System.Drawing.Size(800, 434);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtGood;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Button buttonPublish;
    }
}
