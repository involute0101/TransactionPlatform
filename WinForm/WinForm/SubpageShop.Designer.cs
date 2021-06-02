
namespace WinForm
{
    partial class SubpageShop
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.bdsGoods = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNews);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvGoods);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // dgvGoods
            // 
            this.dgvGoods.AutoGenerateColumns = false;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.DataSource = this.bdsGoods;
            this.dgvGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoods.Location = new System.Drawing.Point(0, 0);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.RowHeadersWidth = 51;
            this.dgvGoods.RowTemplate.Height = 27;
            this.dgvGoods.Size = new System.Drawing.Size(800, 350);
            this.dgvGoods.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 25);
            this.textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(359, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNews
            // 
            this.btnNews.BackgroundImage = global::WinForm.Properties.Resources.问答;
            this.btnNews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNews.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNews.Location = new System.Drawing.Point(770, 0);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(30, 30);
            this.btnNews.TabIndex = 2;
            this.btnNews.UseVisualStyleBackColor = true;
            // 
            // SubpageShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SubpageShop";
            this.Size = new System.Drawing.Size(800, 380);
            this.Load += new System.EventHandler(this.Subpage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.BindingSource bdsGoods;
    }
}
