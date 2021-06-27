
namespace WinForm
{
    partial class PageRecord
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.cbxSearchOption = new System.Windows.Forms.ComboBox();
            this.bdsRecord = new System.Windows.Forms.BindingSource(this.components);
            this.transactionRecordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbxSearchOption);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 28);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(452, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 548);
            this.panel2.TabIndex = 1;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // dgvRecord
            // 
            this.dgvRecord.AutoGenerateColumns = false;
            this.dgvRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionRecordIdDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.salerIdDataGridViewTextBoxColumn,
            this.SalerName,
            this.goodIdDataGridViewTextBoxColumn,
            this.GoodName});
            this.dgvRecord.DataSource = this.bdsRecord;
            this.dgvRecord.Location = new System.Drawing.Point(15, 16);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowHeadersWidth = 51;
            this.dgvRecord.RowTemplate.Height = 27;
            this.dgvRecord.Size = new System.Drawing.Size(720, 516);
            this.dgvRecord.TabIndex = 0;
            // 
            // cbxSearchOption
            // 
            this.cbxSearchOption.FormattingEnabled = true;
            this.cbxSearchOption.Items.AddRange(new object[] {
            "商品名称",
            "商品编号",
            "卖家姓名"});
            this.cbxSearchOption.Location = new System.Drawing.Point(15, 4);
            this.cbxSearchOption.Name = "cbxSearchOption";
            this.cbxSearchOption.Size = new System.Drawing.Size(90, 20);
            this.cbxSearchOption.TabIndex = 2;
            // 
            // bdsRecord
            // 
            this.bdsRecord.DataSource = typeof(WinForm.EntityClass.TransactionRecord);
            // 
            // transactionRecordIdDataGridViewTextBoxColumn
            // 
            this.transactionRecordIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionRecordId";
            this.transactionRecordIdDataGridViewTextBoxColumn.HeaderText = "交易记录编号";
            this.transactionRecordIdDataGridViewTextBoxColumn.Name = "transactionRecordIdDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "交易时间";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // salerIdDataGridViewTextBoxColumn
            // 
            this.salerIdDataGridViewTextBoxColumn.DataPropertyName = "SalerId";
            this.salerIdDataGridViewTextBoxColumn.HeaderText = "卖家ID";
            this.salerIdDataGridViewTextBoxColumn.Name = "salerIdDataGridViewTextBoxColumn";
            // 
            // SalerName
            // 
            this.SalerName.DataPropertyName = "SalerName";
            this.SalerName.HeaderText = "卖家姓名";
            this.SalerName.Name = "SalerName";
            // 
            // goodIdDataGridViewTextBoxColumn
            // 
            this.goodIdDataGridViewTextBoxColumn.DataPropertyName = "GoodId";
            this.goodIdDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.goodIdDataGridViewTextBoxColumn.Name = "goodIdDataGridViewTextBoxColumn";
            // 
            // GoodName
            // 
            this.GoodName.DataPropertyName = "GoodName";
            this.GoodName.HeaderText = "商品名称";
            this.GoodName.Name = "GoodName";
            // 
            // PageRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.background;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PageRecord";
            this.Size = new System.Drawing.Size(750, 576);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.BindingSource bdsRecord;
        private System.Windows.Forms.ComboBox cbxSearchOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionRecordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodName;
    }
}
