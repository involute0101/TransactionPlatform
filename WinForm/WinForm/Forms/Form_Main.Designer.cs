
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnState = new WinForm.ImageBtn();
            this.btnNews = new WinForm.ImageBtn();
            this.btnLogOut = new WinForm.ImageBtn();
            this.btnFavorite = new WinForm.SwitchBtn();
            this.btnRecord = new WinForm.SwitchBtn();
            this.btnShop = new WinForm.SwitchBtn();
            this.btnCenter = new WinForm.SwitchBtn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageCenter = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.shopTable = new WinForm.ShopTable();
            this.goodsTable = new WinForm.GoodsTable();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRefrash = new WinForm.ImageBtn();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPublish = new WinForm.ImageBtn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMailBox = new WinForm.ModifiedLabel();
            this.lblPhone = new WinForm.ModifiedLabel();
            this.lblSex = new WinForm.ModifiedLabel();
            this.lblName = new WinForm.ModifiedLabel();
            this.picHead = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangeInfo = new WinForm.ImageBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            this.panel2.SuspendLayout();
            this.pageCenter.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrash)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPublish)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnState);
            this.panel1.Controls.Add(this.btnNews);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnFavorite);
            this.panel1.Controls.Add(this.btnRecord);
            this.panel1.Controls.Add(this.btnShop);
            this.panel1.Controls.Add(this.btnCenter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnState
            // 
            this.btnState.ChangeState = true;
            this.btnState.Image = global::WinForm.Properties.Resources.买家;
            this.btnState.ImageChecked = global::WinForm.Properties.Resources.卖家;
            this.btnState.ImageNormal = global::WinForm.Properties.Resources.买家;
            this.btnState.Location = new System.Drawing.Point(900, 2);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(30, 30);
            this.btnState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnState.TabIndex = 1;
            this.btnState.TabStop = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnNews
            // 
            this.btnNews.ChangeState = false;
            this.btnNews.Image = global::WinForm.Properties.Resources.消_息;
            this.btnNews.ImageChecked = global::WinForm.Properties.Resources.消_息;
            this.btnNews.ImageNormal = global::WinForm.Properties.Resources.消_息;
            this.btnNews.Location = new System.Drawing.Point(935, 2);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(30, 30);
            this.btnNews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNews.TabIndex = 4;
            this.btnNews.TabStop = false;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.ChangeState = false;
            this.btnLogOut.Image = global::WinForm.Properties.Resources.退出登录;
            this.btnLogOut.ImageChecked = global::WinForm.Properties.Resources.退出登录;
            this.btnLogOut.ImageNormal = global::WinForm.Properties.Resources.退出登录;
            this.btnLogOut.Location = new System.Drawing.Point(970, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(30, 30);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnFavorite
            // 
            this.btnFavorite.AutoSize = true;
            this.btnFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.Location = new System.Drawing.Point(270, 5);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(45, 20);
            this.btnFavorite.TabIndex = 3;
            this.btnFavorite.Text = "收藏";
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.AutoSize = true;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(170, 5);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(81, 20);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "交易记录";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnShop
            // 
            this.btnShop.AutoSize = true;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(110, 5);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(45, 20);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "商城";
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.AutoSize = true;
            this.btnCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCenter.ForeColor = System.Drawing.Color.Yellow;
            this.btnCenter.Location = new System.Drawing.Point(10, 5);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(81, 20);
            this.btnCenter.TabIndex = 0;
            this.btnCenter.Text = "个人中心";
            this.btnCenter.Click += new System.EventHandler(this.lblCenter_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WinForm.Properties.Resources.background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pageCenter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 762);
            this.panel2.TabIndex = 1;
            // 
            // pageCenter
            // 
            this.pageCenter.BackColor = System.Drawing.Color.Transparent;
            this.pageCenter.Controls.Add(this.panel7);
            this.pageCenter.Controls.Add(this.panel6);
            this.pageCenter.Controls.Add(this.panel4);
            this.pageCenter.Controls.Add(this.panel3);
            this.pageCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageCenter.Location = new System.Drawing.Point(0, 0);
            this.pageCenter.Name = "pageCenter";
            this.pageCenter.Size = new System.Drawing.Size(1018, 762);
            this.pageCenter.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.shopTable);
            this.panel7.Controls.Add(this.goodsTable);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 310);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1018, 452);
            this.panel7.TabIndex = 3;
            // 
            // shopTable
            // 
            this.shopTable.Location = new System.Drawing.Point(20, 20);
            this.shopTable.Name = "shopTable";
            this.shopTable.Size = new System.Drawing.Size(960, 370);
            this.shopTable.TabIndex = 0;
            // 
            // goodsTable
            // 
            this.goodsTable.Location = new System.Drawing.Point(20, 20);
            this.goodsTable.Name = "goodsTable";
            this.goodsTable.Size = new System.Drawing.Size(960, 370);
            this.goodsTable.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnRefrash);
            this.panel6.Controls.Add(this.cmbChoice);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 280);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1018, 30);
            this.panel6.TabIndex = 2;
            // 
            // btnRefrash
            // 
            this.btnRefrash.ChangeState = false;
            this.btnRefrash.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefrash.Image = global::WinForm.Properties.Resources.新东方_刷新图标;
            this.btnRefrash.ImageChecked = null;
            this.btnRefrash.ImageNormal = null;
            this.btnRefrash.Location = new System.Drawing.Point(988, 0);
            this.btnRefrash.Name = "btnRefrash";
            this.btnRefrash.Size = new System.Drawing.Size(30, 30);
            this.btnRefrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefrash.TabIndex = 2;
            this.btnRefrash.TabStop = false;
            this.btnRefrash.Click += new System.EventHandler(this.btnRefrash_Click);
            // 
            // cmbChoice
            // 
            this.cmbChoice.BackColor = System.Drawing.Color.White;
            this.cmbChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Items.AddRange(new object[] {
            "商城",
            "预售商品"});
            this.cmbChoice.Location = new System.Drawing.Point(13, 5);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(99, 26);
            this.cmbChoice.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1018, 80);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "待定功能区";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 200);
            this.panel3.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.btnPublish);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(898, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 200);
            this.panel8.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(13, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "发布商品";
            // 
            // btnPublish
            // 
            this.btnPublish.ChangeState = false;
            this.btnPublish.Image = global::WinForm.Properties.Resources.发布商品;
            this.btnPublish.ImageChecked = global::WinForm.Properties.Resources.发布商品;
            this.btnPublish.ImageNormal = global::WinForm.Properties.Resources.发布商品;
            this.btnPublish.Location = new System.Drawing.Point(25, 55);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(70, 70);
            this.btnPublish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPublish.TabIndex = 3;
            this.btnPublish.TabStop = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblMailBox);
            this.panel5.Controls.Add(this.lblPhone);
            this.panel5.Controls.Add(this.lblSex);
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Controls.Add(this.picHead);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnChangeInfo);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1018, 200);
            this.panel5.TabIndex = 7;
            // 
            // lblMailBox
            // 
            this.lblMailBox.BackColor = System.Drawing.Color.Transparent;
            this.lblMailBox.InputText = "312432@163.com";
            this.lblMailBox.Location = new System.Drawing.Point(275, 145);
            this.lblMailBox.Name = "lblMailBox";
            this.lblMailBox.Size = new System.Drawing.Size(350, 30);
            this.lblMailBox.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.InputText = "40088208820";
            this.lblPhone.Location = new System.Drawing.Point(275, 105);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(350, 30);
            this.lblPhone.TabIndex = 9;
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.InputText = "男";
            this.lblSex.Location = new System.Drawing.Point(275, 65);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(150, 30);
            this.lblSex.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.InputText = "Test";
            this.lblName.Location = new System.Drawing.Point(275, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 29);
            this.lblName.TabIndex = 7;
            // 
            // picHead
            // 
            this.picHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picHead.Image = global::WinForm.Properties.Resources.头像;
            this.picHead.Location = new System.Drawing.Point(25, 25);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(150, 150);
            this.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHead.TabIndex = 0;
            this.picHead.TabStop = false;
            this.picHead.Click += new System.EventHandler(this.picHead_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(190, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "邮箱：";
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.ChangeState = true;
            this.btnChangeInfo.Image = global::WinForm.Properties.Resources.修_改;
            this.btnChangeInfo.ImageChecked = global::WinForm.Properties.Resources.修_改_中;
            this.btnChangeInfo.ImageNormal = global::WinForm.Properties.Resources.修_改;
            this.btnChangeInfo.Location = new System.Drawing.Point(825, 25);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(35, 35);
            this.btnChangeInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChangeInfo.TabIndex = 2;
            this.btnChangeInfo.TabStop = false;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(190, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(190, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(190, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "性别：";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 797);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1018, 797);
            this.Name = "Form_Main";
            this.Text = "实时通讯交易平台";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.SizeChanged += new System.EventHandler(this.Form_Main_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pageCenter.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrash)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPublish)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SwitchBtn btnCenter;
        private SwitchBtn btnFavorite;
        private SwitchBtn btnRecord;
        private SwitchBtn btnShop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picHead;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.Panel pageCenter;
        private ShopTable shopTable;
        private GoodsTable goodsTable;
        private ImageBtn btnLogOut;
        private ImageBtn btnNews;
        private ImageBtn btnState;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private ImageBtn btnChangeInfo;
        private System.Windows.Forms.Label label1;
        private ImageBtn btnPublish;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ModifiedLabel lblName;
        private ModifiedLabel lblSex;
        private ModifiedLabel lblMailBox;
        private ModifiedLabel lblPhone;
        private ImageBtn btnRefrash;
    }
}

