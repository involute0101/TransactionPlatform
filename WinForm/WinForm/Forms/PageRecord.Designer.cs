
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
            this.cbxSearchOption = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.SalerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionRecordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsRecord = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefrash = new WinForm.ImageBtn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrash)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRefrash);
            this.panel1.Controls.Add(this.cbxSearchOption);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 35);
            this.panel1.TabIndex = 0;
            // 
            // cbxSearchOption
            // 
            this.cbxSearchOption.FormattingEnabled = true;
            this.cbxSearchOption.Items.AddRange(new object[] {
            "商品名称",
            "商品编号",
            "卖家姓名"});
            this.cbxSearchOption.Location = new System.Drawing.Point(20, 5);
            this.cbxSearchOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSearchOption.Name = "cbxSearchOption";
            this.cbxSearchOption.Size = new System.Drawing.Size(119, 23);
            this.cbxSearchOption.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(603, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(153, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(431, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 685);
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
            this.dgvRecord.Location = new System.Drawing.Point(20, 20);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowHeadersWidth = 51;
            this.dgvRecord.RowTemplate.Height = 27;
            this.dgvRecord.Size = new System.Drawing.Size(960, 645);
            this.dgvRecord.TabIndex = 0;
            // 
            // SalerName
            // 
            this.SalerName.DataPropertyName = "SalerName";
            this.SalerName.HeaderText = "卖家姓名";
            this.SalerName.MinimumWidth = 6;
            this.SalerName.Name = "SalerName";
            this.SalerName.Width = 125;
            // 
            // GoodName
            // 
            this.GoodName.DataPropertyName = "GoodName";
            this.GoodName.HeaderText = "商品名称";
            this.GoodName.MinimumWidth = 6;
            this.GoodName.Name = "GoodName";
            this.GoodName.Width = 125;
            // 
            // transactionRecordIdDataGridViewTextBoxColumn
            // 
            this.transactionRecordIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionRecordId";
            this.transactionRecordIdDataGridViewTextBoxColumn.HeaderText = "交易记录编号";
            this.transactionRecordIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionRecordIdDataGridViewTextBoxColumn.Name = "transactionRecordIdDataGridViewTextBoxColumn";
            this.transactionRecordIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "交易时间";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // salerIdDataGridViewTextBoxColumn
            // 
            this.salerIdDataGridViewTextBoxColumn.DataPropertyName = "SalerId";
            this.salerIdDataGridViewTextBoxColumn.HeaderText = "卖家ID";
            this.salerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salerIdDataGridViewTextBoxColumn.Name = "salerIdDataGridViewTextBoxColumn";
            this.salerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodIdDataGridViewTextBoxColumn
            // 
            this.goodIdDataGridViewTextBoxColumn.DataPropertyName = "GoodId";
            this.goodIdDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.goodIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodIdDataGridViewTextBoxColumn.Name = "goodIdDataGridViewTextBoxColumn";
            this.goodIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdsRecord
            // 
            this.bdsRecord.DataSource = typeof(WinForm.EntityClass.TransactionRecord);
            // 
            // btnRefrash
            // 
            this.btnRefrash.ChangeState = false;
            this.btnRefrash.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefrash.Image = global::WinForm.Properties.Resources.新东方_刷新图标;
            this.btnRefrash.ImageChecked = null;
            this.btnRefrash.ImageNormal = null;
            this.btnRefrash.Location = new System.Drawing.Point(970, 0);
            this.btnRefrash.Name = "btnRefrash";
            this.btnRefrash.Size = new System.Drawing.Size(30, 35);
            this.btnRefrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefrash.TabIndex = 4;
            this.btnRefrash.TabStop = false;
            this.btnRefrash.Click += new System.EventHandler(this.btnRefrash_Click);
            // 
            // PageRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.background;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageRecord";
            this.Size = new System.Drawing.Size(1000, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrash)).EndInit();
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
        private ImageBtn btnRefrash;
    }
}
