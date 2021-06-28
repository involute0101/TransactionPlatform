
namespace WinForm
{
    partial class Form_MoreGoods
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
            this.dgvMoreGoods = new System.Windows.Forms.DataGridView();
            this.goodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodDetailDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsMoreGoods = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoreGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMoreGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMoreGoods
            // 
            this.dgvMoreGoods.AutoGenerateColumns = false;
            this.dgvMoreGoods.BackgroundColor = System.Drawing.Color.White;
            this.dgvMoreGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoreGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodIdDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.goodDetailDescDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.dgvMoreGoods.DataSource = this.bdsMoreGoods;
            this.dgvMoreGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMoreGoods.Location = new System.Drawing.Point(0, 0);
            this.dgvMoreGoods.Name = "dgvMoreGoods";
            this.dgvMoreGoods.RowHeadersWidth = 51;
            this.dgvMoreGoods.RowTemplate.Height = 27;
            this.dgvMoreGoods.Size = new System.Drawing.Size(800, 450);
            this.dgvMoreGoods.TabIndex = 0;
            this.dgvMoreGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoreGoods_CellClick);
            // 
            // goodIdDataGridViewTextBoxColumn
            // 
            this.goodIdDataGridViewTextBoxColumn.DataPropertyName = "GoodId";
            this.goodIdDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.goodIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodIdDataGridViewTextBoxColumn.Name = "goodIdDataGridViewTextBoxColumn";
            this.goodIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "图片";
            this.imageDataGridViewImageColumn.MinimumWidth = 6;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodDetailDescDataGridViewTextBoxColumn
            // 
            this.goodDetailDescDataGridViewTextBoxColumn.DataPropertyName = "GoodDetailDesc";
            this.goodDetailDescDataGridViewTextBoxColumn.HeaderText = "商品描述";
            this.goodDetailDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodDetailDescDataGridViewTextBoxColumn.Name = "goodDetailDescDataGridViewTextBoxColumn";
            this.goodDetailDescDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "状态";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdsMoreGoods
            // 
            this.bdsMoreGoods.DataSource = typeof(WinForm.EntityClass.Good);
            // 
            // Form_MoreGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMoreGoods);
            this.Name = "Form_MoreGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "其他商品";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoreGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMoreGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsMoreGoods;
        private System.Windows.Forms.DataGridView dgvMoreGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDetailDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}