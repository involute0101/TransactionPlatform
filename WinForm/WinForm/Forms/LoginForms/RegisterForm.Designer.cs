
namespace WinForm
{
    partial class RegisterForm
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
            this.groupBoxRegister = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelSex = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSurePassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSurePassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegister
            // 
            this.groupBoxRegister.BackColor = System.Drawing.Color.White;
            this.groupBoxRegister.BackgroundImage = global::WinForm.Properties.Resources.background;
            this.groupBoxRegister.Controls.Add(this.label1);
            this.groupBoxRegister.Controls.Add(this.radioButtonFemale);
            this.groupBoxRegister.Controls.Add(this.radioButtonMale);
            this.groupBoxRegister.Controls.Add(this.labelSex);
            this.groupBoxRegister.Controls.Add(this.buttonRegister);
            this.groupBoxRegister.Controls.Add(this.labelPhoneNumber);
            this.groupBoxRegister.Controls.Add(this.labelEmail);
            this.groupBoxRegister.Controls.Add(this.labelSurePassword);
            this.groupBoxRegister.Controls.Add(this.labelPassword);
            this.groupBoxRegister.Controls.Add(this.labelUsername);
            this.groupBoxRegister.Controls.Add(this.textBoxPhone);
            this.groupBoxRegister.Controls.Add(this.textBoxEmail);
            this.groupBoxRegister.Controls.Add(this.textBoxSurePassword);
            this.groupBoxRegister.Controls.Add(this.textBoxPassword);
            this.groupBoxRegister.Controls.Add(this.textBoxUsername);
            this.groupBoxRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRegister.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRegister.Name = "groupBoxRegister";
            this.groupBoxRegister.Size = new System.Drawing.Size(482, 504);
            this.groupBoxRegister.TabIndex = 0;
            this.groupBoxRegister.TabStop = false;
            this.groupBoxRegister.Text = "注册";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonFemale.Location = new System.Drawing.Point(321, 86);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(48, 22);
            this.radioButtonFemale.TabIndex = 13;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "女";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonMale.Location = new System.Drawing.Point(224, 86);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 22);
            this.radioButtonMale.TabIndex = 12;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "男";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSex.Location = new System.Drawing.Point(142, 86);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(46, 18);
            this.labelSex.TabIndex = 11;
            this.labelSex.Text = "性别";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.HotPink;
            this.buttonRegister.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegister.Location = new System.Drawing.Point(187, 404);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 40);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "注册";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(106, 329);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(65, 18);
            this.labelPhoneNumber.TabIndex = 9;
            this.labelPhoneNumber.Text = "手机号";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmail.Location = new System.Drawing.Point(103, 267);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 18);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "邮箱";
            // 
            // labelSurePassword
            // 
            this.labelSurePassword.AutoSize = true;
            this.labelSurePassword.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSurePassword.Location = new System.Drawing.Point(103, 203);
            this.labelSurePassword.Name = "labelSurePassword";
            this.labelSurePassword.Size = new System.Drawing.Size(84, 18);
            this.labelSurePassword.TabIndex = 7;
            this.labelSurePassword.Text = "确认密码";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPassword.Location = new System.Drawing.Point(103, 141);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(46, 18);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "密码";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("仿宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUsername.Location = new System.Drawing.Point(103, 33);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(65, 18);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "用户名";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(224, 320);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(193, 25);
            this.textBoxPhone.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(224, 258);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(193, 25);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxSurePassword
            // 
            this.textBoxSurePassword.Location = new System.Drawing.Point(224, 194);
            this.textBoxSurePassword.Name = "textBoxSurePassword";
            this.textBoxSurePassword.PasswordChar = '*';
            this.textBoxSurePassword.Size = new System.Drawing.Size(193, 25);
            this.textBoxSurePassword.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(224, 132);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(193, 25);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(227, 24);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(193, 25);
            this.textBoxUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(224, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "密码不得少于6位";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 504);
            this.Controls.Add(this.groupBoxRegister);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.groupBoxRegister.ResumeLayout(false);
            this.groupBoxRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegister;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSurePassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSurePassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label label1;
    }
}