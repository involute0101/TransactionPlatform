
namespace WinForm
{
    partial class PageConsult
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
            this.textBox_showing = new System.Windows.Forms.RichTextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.cmbRecord = new System.Windows.Forms.ComboBox();
            this.btnMoreGoods = new WinForm.ImageBtn();
            this.btnMap = new WinForm.ImageBtn();
            this.button_send = new WinForm.ImageBtn();
            this.btnSendImg = new WinForm.ImageBtn();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoreGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendImg)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_showing
            // 
            this.textBox_showing.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_showing.Location = new System.Drawing.Point(0, 0);
            this.textBox_showing.Name = "textBox_showing";
            this.textBox_showing.Size = new System.Drawing.Size(800, 297);
            this.textBox_showing.TabIndex = 1;
            this.textBox_showing.Text = "";
            // 
            // textBox_send
            // 
            this.textBox_send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_send.Location = new System.Drawing.Point(0, 335);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_send.Size = new System.Drawing.Size(800, 76);
            this.textBox_send.TabIndex = 11;
            // 
            // cmbRecord
            // 
            this.cmbRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecord.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRecord.FormattingEnabled = true;
            this.cmbRecord.Location = new System.Drawing.Point(123, 306);
            this.cmbRecord.Name = "cmbRecord";
            this.cmbRecord.Size = new System.Drawing.Size(88, 23);
            this.cmbRecord.TabIndex = 17;
            this.cmbRecord.SelectedIndexChanged += new System.EventHandler(this.cmbRecord_SelectedIndexChanged);
            // 
            // btnMoreGoods
            // 
            this.btnMoreGoods.ChangeState = true;
            this.btnMoreGoods.Image = global::WinForm.Properties.Resources.购物车_更多_商品;
            this.btnMoreGoods.ImageChecked = global::WinForm.Properties.Resources.购物车_更多_商品;
            this.btnMoreGoods.ImageNormal = global::WinForm.Properties.Resources.购物车_更多_商品;
            this.btnMoreGoods.Location = new System.Drawing.Point(82, 300);
            this.btnMoreGoods.Name = "btnMoreGoods";
            this.btnMoreGoods.Size = new System.Drawing.Size(35, 35);
            this.btnMoreGoods.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMoreGoods.TabIndex = 16;
            this.btnMoreGoods.TabStop = false;
            this.btnMoreGoods.Click += new System.EventHandler(this.btnMoreGoods_Click);
            // 
            // btnMap
            // 
            this.btnMap.ChangeState = true;
            this.btnMap.Image = global::WinForm.Properties.Resources.地图;
            this.btnMap.ImageChecked = global::WinForm.Properties.Resources.地图;
            this.btnMap.ImageNormal = global::WinForm.Properties.Resources.地图;
            this.btnMap.Location = new System.Drawing.Point(41, 300);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(35, 35);
            this.btnMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMap.TabIndex = 15;
            this.btnMap.TabStop = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // button_send
            // 
            this.button_send.ChangeState = false;
            this.button_send.Image = global::WinForm.Properties.Resources.发送;
            this.button_send.ImageChecked = null;
            this.button_send.ImageNormal = null;
            this.button_send.Location = new System.Drawing.Point(761, 300);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(35, 35);
            this.button_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_send.TabIndex = 14;
            this.button_send.TabStop = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click_1);
            // 
            // btnSendImg
            // 
            this.btnSendImg.ChangeState = true;
            this.btnSendImg.Image = global::WinForm.Properties.Resources.sendImageIcon;
            this.btnSendImg.ImageChecked = global::WinForm.Properties.Resources.sendImageIcon;
            this.btnSendImg.ImageNormal = global::WinForm.Properties.Resources.sendImageIcon;
            this.btnSendImg.Location = new System.Drawing.Point(0, 300);
            this.btnSendImg.Name = "btnSendImg";
            this.btnSendImg.Size = new System.Drawing.Size(35, 35);
            this.btnSendImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSendImg.TabIndex = 13;
            this.btnSendImg.TabStop = false;
            this.btnSendImg.Click += new System.EventHandler(this.btnSendImg_Click);
            // 
            // PageConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbRecord);
            this.Controls.Add(this.btnMoreGoods);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.btnSendImg);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.textBox_showing);
            this.Name = "PageConsult";
            this.Size = new System.Drawing.Size(800, 411);
            this.Load += new System.EventHandler(this.PageConsult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMoreGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMap)).EndInit();
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
        private ImageBtn btnMap;
        private ImageBtn btnMoreGoods;
        private System.Windows.Forms.ComboBox cmbRecord;
    }
}
