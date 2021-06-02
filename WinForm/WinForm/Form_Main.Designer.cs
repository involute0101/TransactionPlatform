
namespace WinForm
{
    partial class Form_Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnPublish = new WinForm.RoundBtn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPublish)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 380);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPublish);
            this.panel3.Controls.Add(this.btnCenter);
            this.panel3.Controls.Add(this.btnShop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 70);
            this.panel3.TabIndex = 2;
            // 
            // btnCenter
            // 
            this.btnCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCenter.Location = new System.Drawing.Point(663, 8);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(125, 59);
            this.btnCenter.TabIndex = 1;
            this.btnCenter.Text = "个人中心";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnShop
            // 
            this.btnShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShop.Location = new System.Drawing.Point(35, 6);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(125, 61);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "商城";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Image = global::WinForm.Properties.Resources.添加;
            this.btnPublish.ImageChecked = global::WinForm.Properties.Resources.添加_选中_;
            this.btnPublish.ImageNormal = global::WinForm.Properties.Resources.添加;
            this.btnPublish.Location = new System.Drawing.Point(358, -22);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(80, 80);
            this.btnPublish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPublish.TabIndex = 0;
            this.btnPublish.TabStop = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form_Main";
            this.Text = "实时通讯交易平台";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPublish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnShop;
        private RoundBtn btnPublish;
    }
}

