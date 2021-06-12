
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
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.goodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodDetailDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsShop = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsShop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShop
            // 
            this.dgvShop.AutoGenerateColumns = false;
            this.dgvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShop.BackgroundColor = System.Drawing.Color.White;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodIdDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.goodDetailDescDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.dgvShop.DataSource = this.bdsShop;
            this.dgvShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShop.Location = new System.Drawing.Point(0, 0);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.RowHeadersWidth = 51;
            this.dgvShop.RowTemplate.Height = 27;
            this.dgvShop.Size = new System.Drawing.Size(1000, 410);
            this.dgvShop.TabIndex = 0;
            this.dgvShop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShop_CellClick);
            // 
            // goodIdDataGridViewTextBoxColumn
            // 
            this.goodIdDataGridViewTextBoxColumn.DataPropertyName = "GoodId";
            this.goodIdDataGridViewTextBoxColumn.Frozen = true;
            this.goodIdDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.goodIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodIdDataGridViewTextBoxColumn.Name = "goodIdDataGridViewTextBoxColumn";
            this.goodIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodIdDataGridViewTextBoxColumn.Width = 96;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.Frozen = true;
            this.imageDataGridViewTextBoxColumn.HeaderText = "图片";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imageDataGridViewTextBoxColumn.Width = 43;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNameDataGridViewTextBoxColumn.Width = 96;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 66;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "数量";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 66;
            // 
            // goodDetailDescDataGridViewTextBoxColumn
            // 
            this.goodDetailDescDataGridViewTextBoxColumn.DataPropertyName = "GoodDetailDesc";
            this.goodDetailDescDataGridViewTextBoxColumn.HeaderText = "商品描述";
            this.goodDetailDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodDetailDescDataGridViewTextBoxColumn.Name = "goodDetailDescDataGridViewTextBoxColumn";
            this.goodDetailDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodDetailDescDataGridViewTextBoxColumn.Width = 96;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "商品状态";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 96;
            // 
            // bdsShop
            // 
            this.bdsShop.DataSource = typeof(WinForm.EntityClass.Good);
            // 
            // ShopTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvShop);
            this.Name = "ShopTable";
            this.Size = new System.Drawing.Size(1000, 410);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource bdsShop;
        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDetailDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}
