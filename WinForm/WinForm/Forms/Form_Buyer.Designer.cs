
namespace WinForm.Forms
{
    partial class Form_Buyer
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAmount = new System.Windows.Forms.ComboBox();
            this.btnBuy = new WinForm.ImageBtn();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择购买数量：";
            // 
            // cbxAmount
            // 
            this.cbxAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAmount.FormattingEnabled = true;
            this.cbxAmount.Location = new System.Drawing.Point(120, 60);
            this.cbxAmount.Name = "cbxAmount";
            this.cbxAmount.Size = new System.Drawing.Size(121, 20);
            this.cbxAmount.TabIndex = 1;
            // 
            // btnBuy
            // 
            this.btnBuy.ChangeState = false;
            this.btnBuy.Image = global::WinForm.Properties.Resources.购买;
            this.btnBuy.ImageChecked = null;
            this.btnBuy.ImageNormal = null;
            this.btnBuy.Location = new System.Drawing.Point(120, 105);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(30, 32);
            this.btnBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuy.TabIndex = 2;
            this.btnBuy.TabStop = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Form_Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.cbxAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form_Buyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Buyer";
            ((System.ComponentModel.ISupportInitialize)(this.btnBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAmount;
        private ImageBtn btnBuy;
    }
}