
namespace WinForm
{
    partial class PageNews
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
            this.dgvNews = new System.Windows.Forms.DataGridView();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsNews = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefrash = new WinForm.ImageBtn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrash)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRefrash);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(470, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(430, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvNews);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 685);
            this.panel2.TabIndex = 1;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // dgvNews
            // 
            this.dgvNews.AutoGenerateColumns = false;
            this.dgvNews.BackgroundColor = System.Drawing.Color.White;
            this.dgvNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.senderIdDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dgvNews.DataSource = this.bdsNews;
            this.dgvNews.Location = new System.Drawing.Point(20, 20);
            this.dgvNews.Name = "dgvNews";
            this.dgvNews.RowHeadersWidth = 51;
            this.dgvNews.RowTemplate.Height = 27;
            this.dgvNews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNews.Size = new System.Drawing.Size(965, 645);
            this.dgvNews.TabIndex = 0;
            this.dgvNews.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNews_CellClick);
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "尚品名称";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // senderIdDataGridViewTextBoxColumn
            // 
            this.senderIdDataGridViewTextBoxColumn.DataPropertyName = "SenderId";
            this.senderIdDataGridViewTextBoxColumn.HeaderText = "发送者id";
            this.senderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senderIdDataGridViewTextBoxColumn.Name = "senderIdDataGridViewTextBoxColumn";
            this.senderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "时间";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdsNews
            // 
            this.bdsNews.DataSource = typeof(WinForm.Util.Message);
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
            this.btnRefrash.TabIndex = 3;
            this.btnRefrash.TabStop = false;
            this.btnRefrash.Click += new System.EventHandler(this.btnRefrash_Click);
            // 
            // PageNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.background;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PageNews";
            this.Size = new System.Drawing.Size(1000, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNews;
        private System.Windows.Forms.BindingSource bdsNews;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private ImageBtn btnRefrash;
    }
}
