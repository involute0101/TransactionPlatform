
namespace WinForm
{
    partial class ShopTable
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
            this.bdsShop = new System.Windows.Forms.BindingSource(this.components);
            this.dgvShop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bdsShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShop
            // 
            this.dgvShop.AutoGenerateColumns = false;
            this.dgvShop.BackgroundColor = System.Drawing.Color.White;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.DataSource = this.bdsShop;
            this.dgvShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShop.Location = new System.Drawing.Point(0, 0);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.RowHeadersWidth = 51;
            this.dgvShop.RowTemplate.Height = 27;
            this.dgvShop.Size = new System.Drawing.Size(1000, 410);
            this.dgvShop.TabIndex = 0;
            // 
            // ShopTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvShop);
            this.Name = "ShopTable";
            this.Size = new System.Drawing.Size(1000, 410);
            ((System.ComponentModel.ISupportInitialize)(this.bdsShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource bdsShop;
        private System.Windows.Forms.DataGridView dgvShop;
    }
}
