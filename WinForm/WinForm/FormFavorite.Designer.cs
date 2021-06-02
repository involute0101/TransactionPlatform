
namespace WinForm
{
    partial class FormFavorite
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
            this.dgvFavorite = new System.Windows.Forms.DataGridView();
            this.bdsFavorite = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFavorite
            // 
            this.dgvFavorite.AutoGenerateColumns = false;
            this.dgvFavorite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavorite.DataSource = this.bdsFavorite;
            this.dgvFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFavorite.Location = new System.Drawing.Point(0, 0);
            this.dgvFavorite.Name = "dgvFavorite";
            this.dgvFavorite.RowHeadersWidth = 51;
            this.dgvFavorite.RowTemplate.Height = 27;
            this.dgvFavorite.Size = new System.Drawing.Size(800, 450);
            this.dgvFavorite.TabIndex = 0;
            // 
            // FormFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFavorite);
            this.Name = "FormFavorite";
            this.Text = "收藏";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFavorite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFavorite;
        private System.Windows.Forms.BindingSource bdsFavorite;
    }
}