
namespace WinForm
{
    partial class SubPageCenter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMailBox = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChangeInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRecord = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblfavorite = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMailBox);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 140);
            this.panel1.TabIndex = 0;
            // 
            // lblMailBox
            // 
            this.lblMailBox.AutoSize = true;
            this.lblMailBox.Location = new System.Drawing.Point(150, 110);
            this.lblMailBox.Name = "lblMailBox";
            this.lblMailBox.Size = new System.Drawing.Size(52, 15);
            this.lblMailBox.TabIndex = 4;
            this.lblMailBox.Text = "邮箱：";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(150, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 15);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "电话：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(150, 50);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(52, 15);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(150, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "昵称：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblChangeInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 1;
            // 
            // lblChangeInfo
            // 
            this.lblChangeInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChangeInfo.AutoSize = true;
            this.lblChangeInfo.Location = new System.Drawing.Point(0, 6);
            this.lblChangeInfo.Name = "lblChangeInfo";
            this.lblChangeInfo.Size = new System.Drawing.Size(97, 15);
            this.lblChangeInfo.TabIndex = 0;
            this.lblChangeInfo.Text = "修改个人信息";
            this.lblChangeInfo.Click += new System.EventHandler(this.lblChangeInfo_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblRecord);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 30);
            this.panel3.TabIndex = 2;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(0, 6);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(67, 15);
            this.lblRecord.TabIndex = 0;
            this.lblRecord.Text = "交易记录";
            this.lblRecord.Click += new System.EventHandler(this.lblRecord_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblfavorite);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 30);
            this.panel4.TabIndex = 3;
            // 
            // lblfavorite
            // 
            this.lblfavorite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblfavorite.AutoSize = true;
            this.lblfavorite.Location = new System.Drawing.Point(0, 6);
            this.lblfavorite.Name = "lblfavorite";
            this.lblfavorite.Size = new System.Drawing.Size(37, 15);
            this.lblfavorite.TabIndex = 0;
            this.lblfavorite.Text = "收藏";
            this.lblfavorite.Click += new System.EventHandler(this.lblfavorite_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblExit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 30);
            this.panel5.TabIndex = 4;
            // 
            // lblExit
            // 
            this.lblExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(0, 6);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(67, 15);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "退出登录";
            // 
            // SubPageCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SubPageCenter";
            this.Size = new System.Drawing.Size(800, 380);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMailBox;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChangeInfo;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblfavorite;
        private System.Windows.Forms.Label lblExit;
    }
}
