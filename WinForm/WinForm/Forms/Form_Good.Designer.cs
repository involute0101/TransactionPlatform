
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
            this.lblHeadName = new WinForm.ModifiedLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangeInfo = new WinForm.ImageBtn();
            this.btnBuy = new WinForm.ImageBtn();
            this.lblDetail = new WinForm.ModifiedLabel();
            this.lblCount = new WinForm.ModifiedLabel();
            this.lblPrice = new WinForm.ModifiedLabel();
            this.lblSellerId = new System.Windows.Forms.Label();
            this.lblState = new WinForm.ModifiedLabel();
            this.lblGoodId = new System.Windows.Forms.Label();
            this.lblName = new WinForm.ModifiedLabel();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.panelChoose = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoodPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavorite)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeInfo)).BeginInit();
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
            this.lblHeadName.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHeadName.ForeColor = System.Drawing.Color.White;
            this.lblHeadName.InputText = "";
            this.lblHeadName.Location = new System.Drawing.Point(3, 9);
            this.lblHeadName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblHeadName.Name = "lblHeadName";
            this.lblHeadName.Size = new System.Drawing.Size(356, 27);
            this.lblHeadName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnChangeInfo);
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
            this.panel2.Size = new System.Drawing.Size(800, 412);
            this.panel2.TabIndex = 1;
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.ChangeState = true;
            this.btnChangeInfo.Image = global::WinForm.Properties.Resources.修_改;
            this.btnChangeInfo.ImageChecked = global::WinForm.Properties.Resources.修_改_中;
            this.btnChangeInfo.ImageNormal = global::WinForm.Properties.Resources.修_改;
            this.btnChangeInfo.Location = new System.Drawing.Point(692, 34);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(35, 35);
            this.btnChangeInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChangeInfo.TabIndex = 8;
            this.btnChangeInfo.TabStop = false;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
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
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetail.InputText = "";
            this.lblDetail.Location = new System.Drawing.Point(17, 257);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(759, 92);
            this.lblDetail.TabIndex = 7;
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCount.InputText = "";
            this.lblCount.Location = new System.Drawing.Point(348, 225);
            this.lblCount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(287, 30);
            this.lblCount.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.InputText = "";
            this.lblPrice.Location = new System.Drawing.Point(348, 187);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(272, 35);
            this.lblPrice.TabIndex = 5;
            // 
            // lblSellerId
            // 
            this.lblSellerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSellerId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSellerId.Location = new System.Drawing.Point(343, 144);
            this.lblSellerId.Name = "lblSellerId";
            this.lblSellerId.Size = new System.Drawing.Size(292, 35);
            this.lblSellerId.TabIndex = 4;
            this.lblSellerId.Text = "label1";
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblState.InputText = "";
            this.lblState.Location = new System.Drawing.Point(348, 97);
            this.lblState.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(287, 35);
            this.lblState.TabIndex = 3;
            // 
            // lblGoodId
            // 
            this.lblGoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoodId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGoodId.Location = new System.Drawing.Point(343, 48);
            this.lblGoodId.Name = "lblGoodId";
            this.lblGoodId.Size = new System.Drawing.Size(287, 35);
            this.lblGoodId.TabIndex = 2;
            this.lblGoodId.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.InputText = "";
            this.lblName.Location = new System.Drawing.Point(348, 2);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(287, 35);
            this.lblName.TabIndex = 1;
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
            this.panelChoose.Size = new System.Drawing.Size(800, 412);
            this.panelChoose.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(255, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(255, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "商品ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(255, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(255, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "买家ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(255, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "价格";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(255, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "数量";
            // 
            // Form_Good
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 451);
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
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.panelChoose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ModifiedLabel lblHeadName;
        private ModifiedLabel lblName;
        private System.Windows.Forms.PictureBox picImg;
        private ModifiedLabel lblCount;
        private ModifiedLabel lblPrice;
        private System.Windows.Forms.Label lblSellerId;
        private ModifiedLabel lblState;
        private System.Windows.Forms.Label lblGoodId;
        private ImageBtn btnBuy;
        private ModifiedLabel lblDetail;
        private ImageBtn btnFavorite;
        private ImageBtn btnConsultPage;
        private ImageBtn btnGoodPage;
        private System.Windows.Forms.Panel panelChoose;
        private ImageBtn btnChangeInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}