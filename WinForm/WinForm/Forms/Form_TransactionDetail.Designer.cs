
namespace WinForm
{
    partial class Form_TransactionDetail
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
            this.lblGoodId = new System.Windows.Forms.Label();
            this.lblGoodName = new System.Windows.Forms.Label();
            this.lblBuyerId = new System.Windows.Forms.Label();
            this.lblSalerId = new System.Windows.Forms.Label();
            this.lblSalerName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGoodId
            // 
            this.lblGoodId.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoodId.Location = new System.Drawing.Point(60, 30);
            this.lblGoodId.Name = "lblGoodId";
            this.lblGoodId.Size = new System.Drawing.Size(184, 18);
            this.lblGoodId.TabIndex = 0;
            this.lblGoodId.Text = "lblGoodId";
            // 
            // lblGoodName
            // 
            this.lblGoodName.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoodName.Location = new System.Drawing.Point(60, 70);
            this.lblGoodName.Name = "lblGoodName";
            this.lblGoodName.Size = new System.Drawing.Size(184, 18);
            this.lblGoodName.TabIndex = 1;
            this.lblGoodName.Text = "lblGoodName";
            // 
            // lblBuyerId
            // 
            this.lblBuyerId.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyerId.Location = new System.Drawing.Point(60, 110);
            this.lblBuyerId.Name = "lblBuyerId";
            this.lblBuyerId.Size = new System.Drawing.Size(184, 18);
            this.lblBuyerId.TabIndex = 2;
            this.lblBuyerId.Text = "lblBuyerId";
            // 
            // lblSalerId
            // 
            this.lblSalerId.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSalerId.Location = new System.Drawing.Point(60, 150);
            this.lblSalerId.Name = "lblSalerId";
            this.lblSalerId.Size = new System.Drawing.Size(184, 18);
            this.lblSalerId.TabIndex = 3;
            this.lblSalerId.Text = "lblSalerId";
            // 
            // lblSalerName
            // 
            this.lblSalerName.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSalerName.Location = new System.Drawing.Point(60, 190);
            this.lblSalerName.Name = "lblSalerName";
            this.lblSalerName.Size = new System.Drawing.Size(184, 18);
            this.lblSalerName.TabIndex = 4;
            this.lblSalerName.Text = "lblSalerName";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(60, 230);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(184, 18);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "lblTime";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(105, 270);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 25);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form_TransactionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 303);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSalerName);
            this.Controls.Add(this.lblSalerId);
            this.Controls.Add(this.lblBuyerId);
            this.Controls.Add(this.lblGoodName);
            this.Controls.Add(this.lblGoodId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "Form_TransactionDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "交易明细";
            this.Load += new System.EventHandler(this.Form_TransacationDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGoodId;
        private System.Windows.Forms.Label lblGoodName;
        private System.Windows.Forms.Label lblBuyerId;
        private System.Windows.Forms.Label lblSalerId;
        private System.Windows.Forms.Label lblSalerName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSend;
    }
}