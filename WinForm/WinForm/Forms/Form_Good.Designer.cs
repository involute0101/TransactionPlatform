
namespace WinForm
{
    partial class Form_Good
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoodPage = new WinForm.ImageBtn();
            this.btnConsultPage = new WinForm.ImageBtn();
            this.btnFavorite = new WinForm.ImageBtn();
            this.lblHeadName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuy = new WinForm.ImageBtn();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSellerId = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblGoodId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.panelChoose = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoodPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavorite)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.panelChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnGoodPage);
            this.panel1.Controls.Add(this.btnConsultPage);
            this.panel1.Controls.Add(this.btnFavorite);
            this.panel1.Controls.Add(this.lblHeadName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnGoodPage
            // 
            this.btnGoodPage.ChangeState = false;
            this.btnGoodPage.Image = global::WinForm.Properties.Resources.商_品_选中_;
            this.btnGoodPage.ImageChecked = null;
            this.btnGoodPage.ImageNormal = null;
            this.btnGoodPage.Location = new System.Drawing.Point(672, 0);
            this.btnGoodPage.Name = "btnGoodPage";
            this.btnGoodPage.Size = new System.Drawing.Size(40, 40);
            this.btnGoodPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGoodPage.TabIndex = 3;
            this.btnGoodPage.TabStop = false;
            this.btnGoodPage.Click += new System.EventHandler(this.btnGoodPage_Click);
            // 
            // btnConsultPage
            // 
            this.btnConsultPage.ChangeState = false;
            this.btnConsultPage.Image = global::WinForm.Properties.Resources.咨询;
            this.btnConsultPage.ImageChecked = null;
            this.btnConsultPage.ImageNormal = null;
            this.btnConsultPage.Location = new System.Drawing.Point(718, 0);
            this.btnConsultPage.Name = "btnConsultPage";
            this.btnConsultPage.Size = new System.Drawing.Size(40, 40);
            this.btnConsultPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConsultPage.TabIndex = 2;
            this.btnConsultPage.TabStop = false;
            this.btnConsultPage.Click += new System.EventHandler(this.btnConsultPage_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.ChangeState = true;
            this.btnFavorite.Image = global::WinForm.Properties.Resources.收_藏;
            this.btnFavorite.ImageChecked = global::WinForm.Properties.Resources.收_藏__选中_;
            this.btnFavorite.ImageNormal = global::WinForm.Properties.Resources.收_藏;
            this.btnFavorite.Location = new System.Drawing.Point(767, 3);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(30, 30);
            this.btnFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFavorite.TabIndex = 2;
            this.btnFavorite.TabStop = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // lblHeadName
            // 
            this.lblHeadName.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHeadName.ForeColor = System.Drawing.Color.White;
            this.lblHeadName.Location = new System.Drawing.Point(3, 9);
            this.lblHeadName.Name = "lblHeadName";
            this.lblHeadName.Size = new System.Drawing.Size(356, 27);
            this.lblHeadName.TabIndex = 0;
            this.lblHeadName.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Controls.Add(this.lblDetail);
            this.panel2.Controls.Add(this.lblCount);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblSellerId);
            this.panel2.Controls.Add(this.lblState);
            this.panel2.Controls.Add(this.lblGoodId);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.picImg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 411);
            this.panel2.TabIndex = 1;
            // 
            // btnBuy
            // 
            this.btnBuy.ChangeState = true;
            this.btnBuy.Image = global::WinForm.Properties.Resources.购买;
            this.btnBuy.ImageChecked = global::WinForm.Properties.Resources.已购买;
            this.btnBuy.ImageNormal = global::WinForm.Properties.Resources.购买;
            this.btnBuy.Location = new System.Drawing.Point(363, 359);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(40, 40);
            this.btnBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuy.TabIndex = 1;
            this.btnBuy.TabStop = false;
            // 
            // lblDetail
            // 
            this.lblDetail.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetail.Location = new System.Drawing.Point(17, 257);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(759, 92);
            this.lblDetail.TabIndex = 7;
            this.lblDetail.Text = "label1";
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCount.Location = new System.Drawing.Point(250, 220);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(512, 23);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "label1";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(250, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(512, 23);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "label1";
            // 
            // lblSellerId
            // 
            this.lblSellerId.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSellerId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSellerId.Location = new System.Drawing.Point(250, 140);
            this.lblSellerId.Name = "lblSellerId";
            this.lblSellerId.Size = new System.Drawing.Size(512, 23);
            this.lblSellerId.TabIndex = 4;
            this.lblSellerId.Text = "label1";
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblState.Location = new System.Drawing.Point(250, 100);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(512, 23);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "label1";
            // 
            // lblGoodId
            // 
            this.lblGoodId.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoodId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGoodId.Location = new System.Drawing.Point(250, 60);
            this.lblGoodId.Name = "lblGoodId";
            this.lblGoodId.Size = new System.Drawing.Size(512, 23);
            this.lblGoodId.TabIndex = 2;
            this.lblGoodId.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(250, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(512, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(21, 20);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(223, 223);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            // 
            // panelChoose
            // 
            this.panelChoose.BackColor = System.Drawing.Color.Transparent;
            this.panelChoose.Controls.Add(this.panel2);
            this.panelChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChoose.Location = new System.Drawing.Point(0, 39);
            this.panelChoose.Name = "panelChoose";
            this.panelChoose.Size = new System.Drawing.Size(800, 411);
            this.panelChoose.TabIndex = 2;
            // 
            // Form_Good
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChoose);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form_Good";
            this.Text = "商品详情";
            this.Load += new System.EventHandler(this.Form_Good_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGoodPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavorite)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.panelChoose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeadName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSellerId;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblGoodId;
        private ImageBtn btnBuy;
        private System.Windows.Forms.Label lblDetail;
        private ImageBtn btnFavorite;
        private ImageBtn btnConsultPage;
        private ImageBtn btnGoodPage;
        private System.Windows.Forms.Panel panelChoose;
    }
}