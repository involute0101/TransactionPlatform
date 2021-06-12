
namespace WinForm
{
    partial class ForgetPassword
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
            this.groupBoxForgetPassword = new System.Windows.Forms.GroupBox();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.groupBoxForgetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForgetPassword
            // 
            this.groupBoxForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxForgetPassword.Controls.Add(this.buttonRetrieve);
            this.groupBoxForgetPassword.Controls.Add(this.labelPhone);
            this.groupBoxForgetPassword.Controls.Add(this.labelEmail);
            this.groupBoxForgetPassword.Controls.Add(this.labelUsername);
            this.groupBoxForgetPassword.Controls.Add(this.textBoxPhone);
            this.groupBoxForgetPassword.Controls.Add(this.textBoxEmail);
            this.groupBoxForgetPassword.Controls.Add(this.textBoxUsername);
            this.groupBoxForgetPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxForgetPassword.Location = new System.Drawing.Point(0, 0);
            this.groupBoxForgetPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxForgetPassword.Name = "groupBoxForgetPassword";
            this.groupBoxForgetPassword.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxForgetPassword.Size = new System.Drawing.Size(362, 403);
            this.groupBoxForgetPassword.TabIndex = 0;
            this.groupBoxForgetPassword.TabStop = false;
            this.groupBoxForgetPassword.Text = "忘记密码";
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.BackColor = System.Drawing.Color.DimGray;
            this.buttonRetrieve.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRetrieve.Location = new System.Drawing.Point(136, 288);
            this.buttonRetrieve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(75, 32);
            this.buttonRetrieve.TabIndex = 6;
            this.buttonRetrieve.Text = "找回密码";
            this.buttonRetrieve.UseVisualStyleBackColor = false;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhone.Location = new System.Drawing.Point(90, 197);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(82, 14);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "注册手机号";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmail.Location = new System.Drawing.Point(90, 118);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 14);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "邮箱";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUsername.Location = new System.Drawing.Point(88, 38);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(52, 14);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "用户名";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(174, 190);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(123, 21);
            this.textBoxPhone.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(174, 110);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(123, 21);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(174, 31);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(123, 21);
            this.textBoxUsername.TabIndex = 0;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(362, 403);
            this.Controls.Add(this.groupBoxForgetPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.groupBoxForgetPassword.ResumeLayout(false);
            this.groupBoxForgetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForgetPassword;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}