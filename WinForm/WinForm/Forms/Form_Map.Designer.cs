
namespace WinForm
{
    partial class Form_Map
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
            this.components = new System.ComponentModel.Container();
            this.wbsMap = new System.Windows.Forms.WebBrowser();
            this.btnSend = new System.Windows.Forms.Button();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new WinForm.ImageBtn();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // wbsMap
            // 
            this.wbsMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbsMap.Location = new System.Drawing.Point(0, 0);
            this.wbsMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbsMap.Name = "wbsMap";
            this.wbsMap.Size = new System.Drawing.Size(800, 450);
            this.wbsMap.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(27, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 32);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送位置";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timerShow
            // 
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ChangeState = false;
            this.btnRefresh.Image = global::WinForm.Properties.Resources.新东方_刷新图标;
            this.btnRefresh.ImageChecked = global::WinForm.Properties.Resources.新东方_刷新图标;
            this.btnRefresh.ImageNormal = global::WinForm.Properties.Resources.新东方_刷新图标;
            this.btnRefresh.Location = new System.Drawing.Point(27, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 35);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.wbsMap);
            this.Name = "Form_Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "地图";
            this.Load += new System.EventHandler(this.Form_Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbsMap;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timerShow;
        private ImageBtn btnRefresh;
    }
}