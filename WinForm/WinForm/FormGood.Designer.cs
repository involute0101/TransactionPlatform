
namespace WinForm
{
    partial class FormGood
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvGoodPictures = new System.Windows.Forms.DataGridView();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.bdsGoodPictures = new System.Windows.Forms.BindingSource(this.components);
            this.picGood = new System.Windows.Forms.PictureBox();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoodPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFavorite);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNumber);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblGood);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 390);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBuy);
            this.panel3.Controls.Add(this.btnConsult);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 30);
            this.panel3.TabIndex = 2;
            // 
            // btnConsult
            // 
            this.btnConsult.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsult.Location = new System.Drawing.Point(0, 0);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(400, 28);
            this.btnConsult.TabIndex = 0;
            this.btnConsult.Text = "咨询商家";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuy.Location = new System.Drawing.Point(398, 0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(400, 28);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "购买";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvGoodPictures);
            this.panel4.Controls.Add(this.picGood);
            this.panel4.Location = new System.Drawing.Point(40, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 250);
            this.panel4.TabIndex = 0;
            // 
            // dgvGoodPictures
            // 
            this.dgvGoodPictures.AutoGenerateColumns = false;
            this.dgvGoodPictures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodPictures.DataSource = this.bdsGoodPictures;
            this.dgvGoodPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoodPictures.Location = new System.Drawing.Point(0, 200);
            this.dgvGoodPictures.Name = "dgvGoodPictures";
            this.dgvGoodPictures.RowHeadersWidth = 51;
            this.dgvGoodPictures.RowTemplate.Height = 27;
            this.dgvGoodPictures.Size = new System.Drawing.Size(300, 50);
            this.dgvGoodPictures.TabIndex = 1;
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Location = new System.Drawing.Point(380, 40);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(37, 15);
            this.lblGood.TabIndex = 1;
            this.lblGood.Text = "商品";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(380, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "价格：";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(380, 120);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(45, 15);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "库存:";
            // 
            // picGood
            // 
            this.picGood.Dock = System.Windows.Forms.DockStyle.Top;
            this.picGood.Location = new System.Drawing.Point(0, 0);
            this.picGood.Name = "picGood";
            this.picGood.Size = new System.Drawing.Size(300, 200);
            this.picGood.TabIndex = 0;
            this.picGood.TabStop = false;
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackgroundImage = global::WinForm.Properties.Resources.收藏;
            this.btnFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFavorite.Location = new System.Drawing.Point(768, 0);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(30, 28);
            this.btnFavorite.TabIndex = 1;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::WinForm.Properties.Resources.返回;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FormGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGood";
            this.Text = "商品";
            this.Load += new System.EventHandler(this.FormGood_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoodPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvGoodPictures;
        private System.Windows.Forms.BindingSource bdsGoodPictures;
        private System.Windows.Forms.PictureBox picGood;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGood;
    }
}