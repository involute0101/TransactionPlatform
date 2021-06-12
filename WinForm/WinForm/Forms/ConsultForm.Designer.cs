
namespace WinForm
{
    partial class ConsultForm
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
            this.textBox_showing = new System.Windows.Forms.RichTextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button_send = new WinForm.ImageBtn();
            this.btnSendImg = new WinForm.ImageBtn();
            ((System.ComponentModel.ISupportInitialize)(this.button_send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendImg)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_showing
            // 
            this.textBox_showing.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_showing.Location = new System.Drawing.Point(0, 0);
            this.textBox_showing.Name = "textBox_showing";
            this.textBox_showing.Size = new System.Drawing.Size(800, 316);
            this.textBox_showing.TabIndex = 0;
            this.textBox_showing.Text = "";
            // 
            // textBox_send
            // 
            this.textBox_send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_send.Location = new System.Drawing.Point(0, 366);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_send.Size = new System.Drawing.Size(800, 84);
            this.textBox_send.TabIndex = 10;
            // 
            // button_send
            // 
            this.button_send.ChangeState = false;
            this.button_send.Image = global::WinForm.Properties.Resources.发送;
            this.button_send.ImageChecked = null;
            this.button_send.ImageNormal = null;
            this.button_send.Location = new System.Drawing.Point(747, 327);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(30, 30);
            this.button_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_send.TabIndex = 13;
            this.button_send.TabStop = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click_1);
            // 
            // btnSendImg
            // 
            this.btnSendImg.ChangeState = true;
            this.btnSendImg.Image = global::WinForm.Properties.Resources.sendImageIcon;
            this.btnSendImg.ImageChecked = global::WinForm.Properties.Resources.修_改_中;
            this.btnSendImg.ImageNormal = global::WinForm.Properties.Resources.修_改;
            this.btnSendImg.Location = new System.Drawing.Point(12, 322);
            this.btnSendImg.Name = "btnSendImg";
            this.btnSendImg.Size = new System.Drawing.Size(35, 35);
            this.btnSendImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSendImg.TabIndex = 12;
            this.btnSendImg.TabStop = false;
            this.btnSendImg.Click += new System.EventHandler(this.btnSendImg_Click);
            // 
            // ConsultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.btnSendImg);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.textBox_showing);
            this.Name = "ConsultForm";
            this.Text = "ConsultForm";
            ((System.ComponentModel.ISupportInitialize)(this.button_send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox_showing;
        private System.Windows.Forms.TextBox textBox_send;
        private ImageBtn btnSendImg;
        private ImageBtn button_send;
    }
}