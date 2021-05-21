
namespace LoginRegister
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.groupBoxForgetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForgetPassword
            // 
            this.groupBoxForgetPassword.Controls.Add(this.buttonRetrieve);
            this.groupBoxForgetPassword.Controls.Add(this.labelPhone);
            this.groupBoxForgetPassword.Controls.Add(this.labelEmail);
            this.groupBoxForgetPassword.Controls.Add(this.labelUsername);
            this.groupBoxForgetPassword.Controls.Add(this.textBoxPhone);
            this.groupBoxForgetPassword.Controls.Add(this.textBoxEmail);
            this.groupBoxForgetPassword.Controls.Add(this.textBoxUsername);
            this.groupBoxForgetPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxForgetPassword.Location = new System.Drawing.Point(0, 0);
            this.groupBoxForgetPassword.Name = "groupBoxForgetPassword";
            this.groupBoxForgetPassword.Size = new System.Drawing.Size(526, 308);
            this.groupBoxForgetPassword.TabIndex = 0;
            this.groupBoxForgetPassword.TabStop = false;
            this.groupBoxForgetPassword.Text = "忘记密码";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(232, 39);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(163, 25);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(232, 91);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(163, 25);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(232, 145);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(163, 25);
            this.textBoxPhone.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(117, 48);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(52, 15);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "用户名";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(120, 100);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 15);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "邮箱";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(120, 154);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(82, 15);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "注册手机号";
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Location = new System.Drawing.Point(200, 234);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(75, 23);
            this.buttonRetrieve.TabIndex = 6;
            this.buttonRetrieve.Text = "找回密码";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 308);
            this.Controls.Add(this.groupBoxForgetPassword);
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