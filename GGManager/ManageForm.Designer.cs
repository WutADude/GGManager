
namespace GGManager
{
    partial class ManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UrlsGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlUPDStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UrlsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlsGridView
            // 
            this.UrlsGridView.AllowUserToAddRows = false;
            this.UrlsGridView.AllowUserToDeleteRows = false;
            this.UrlsGridView.AllowUserToResizeColumns = false;
            this.UrlsGridView.AllowUserToResizeRows = false;
            this.UrlsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.UrlsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.UrlsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrlsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UrlsGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.UrlsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UrlsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UrlsGridView.ColumnHeadersHeight = 25;
            this.UrlsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UrlsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.UrlColumn,
            this.CountColumn});
            this.UrlsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UrlsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UrlsGridView.EnableHeadersVisualStyles = false;
            this.UrlsGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UrlsGridView.Location = new System.Drawing.Point(0, 0);
            this.UrlsGridView.MultiSelect = false;
            this.UrlsGridView.Name = "UrlsGridView";
            this.UrlsGridView.ReadOnly = true;
            this.UrlsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UrlsGridView.RowHeadersVisible = false;
            this.UrlsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.UrlsGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.UrlsGridView.RowTemplate.Height = 27;
            this.UrlsGridView.RowTemplate.ReadOnly = true;
            this.UrlsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UrlsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UrlsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UrlsGridView.ShowCellErrors = false;
            this.UrlsGridView.ShowCellToolTips = false;
            this.UrlsGridView.ShowEditingIcon = false;
            this.UrlsGridView.ShowRowErrors = false;
            this.UrlsGridView.Size = new System.Drawing.Size(519, 251);
            this.UrlsGridView.TabIndex = 0;
            this.UrlsGridView.TabStop = false;
            this.UrlsGridView.DoubleClick += new System.EventHandler(this.UrlsGridView_DoubleClick);
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdColumn.Frozen = true;
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.MinimumWidth = 70;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdColumn.Width = 70;
            // 
            // UrlColumn
            // 
            this.UrlColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UrlColumn.Frozen = true;
            this.UrlColumn.HeaderText = "Ссылка";
            this.UrlColumn.MinimumWidth = 330;
            this.UrlColumn.Name = "UrlColumn";
            this.UrlColumn.ReadOnly = true;
            this.UrlColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UrlColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UrlColumn.Width = 330;
            // 
            // CountColumn
            // 
            this.CountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CountColumn.HeaderText = "Кол-во переходов";
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.ReadOnly = true;
            this.CountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CountColumn.Width = 120;
            // 
            // UrlUPDStatusLabel
            // 
            this.UrlUPDStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlUPDStatusLabel.Location = new System.Drawing.Point(0, 259);
            this.UrlUPDStatusLabel.Name = "UrlUPDStatusLabel";
            this.UrlUPDStatusLabel.Size = new System.Drawing.Size(519, 16);
            this.UrlUPDStatusLabel.TabIndex = 3;
            this.UrlUPDStatusLabel.Text = "{FoundedURL}";
            this.UrlUPDStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(518, 276);
            this.Controls.Add(this.UrlsGridView);
            this.Controls.Add(this.UrlUPDStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите ссылку для обновления";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.UrlsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView UrlsGridView;
        public System.Windows.Forms.Label UrlUPDStatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
    }
}