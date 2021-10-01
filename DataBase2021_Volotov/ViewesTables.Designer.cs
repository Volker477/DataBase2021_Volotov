namespace DataBase2021_Volotov
{
    partial class ViewesTables
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BChart = new System.Windows.Forms.Button();
            this.LTableName = new System.Windows.Forms.Label();
            this.BAdd = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.BExport = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GVQuery = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.CBSearch = new System.Windows.Forms.ComboBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVQuery)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BChart);
            this.panel1.Controls.Add(this.LTableName);
            this.panel1.Controls.Add(this.BAdd);
            this.panel1.Controls.Add(this.BEdit);
            this.panel1.Controls.Add(this.BDelete);
            this.panel1.Controls.Add(this.BExport);
            this.panel1.Controls.Add(this.BExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 50);
            this.panel1.TabIndex = 2;
            // 
            // BChart
            // 
            this.BChart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.BChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BChart.Location = new System.Drawing.Point(561, 0);
            this.BChart.Name = "BChart";
            this.BChart.Size = new System.Drawing.Size(135, 48);
            this.BChart.TabIndex = 13;
            this.BChart.Text = "Диаграмма";
            this.BChart.UseVisualStyleBackColor = true;
            this.BChart.Visible = false;
            this.BChart.Click += new System.EventHandler(this.BChart_Click);
            // 
            // LTableName
            // 
            this.LTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTableName.Location = new System.Drawing.Point(237, 0);
            this.LTableName.Name = "LTableName";
            this.LTableName.Size = new System.Drawing.Size(459, 48);
            this.LTableName.TabIndex = 0;
            this.LTableName.Text = "label1";
            this.LTableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BAdd
            // 
            this.BAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.BAdd.Location = new System.Drawing.Point(696, 0);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(131, 48);
            this.BAdd.TabIndex = 10;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Visible = false;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BEdit
            // 
            this.BEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BEdit.Location = new System.Drawing.Point(827, 0);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(126, 48);
            this.BEdit.TabIndex = 9;
            this.BEdit.Text = "Изменить";
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Visible = false;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BDelete
            // 
            this.BDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.BDelete.Location = new System.Drawing.Point(953, 0);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(129, 48);
            this.BDelete.TabIndex = 8;
            this.BDelete.Text = "Удалить";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Visible = false;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BExport
            // 
            this.BExport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.BExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExport.Location = new System.Drawing.Point(1082, 0);
            this.BExport.Name = "BExport";
            this.BExport.Size = new System.Drawing.Size(94, 48);
            this.BExport.TabIndex = 11;
            this.BExport.Text = "Экспорт в Excel";
            this.BExport.UseVisualStyleBackColor = true;
            this.BExport.Click += new System.EventHandler(this.BExport_Click);
            // 
            // BExit
            // 
            this.BExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BExit.Location = new System.Drawing.Point(1176, 0);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(86, 48);
            this.BExit.TabIndex = 1;
            this.BExit.Text = "Назад";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Открытая таблица:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GVQuery
            // 
            this.GVQuery.AllowUserToAddRows = false;
            this.GVQuery.AllowUserToDeleteRows = false;
            this.GVQuery.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GVQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVQuery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GVQuery.Location = new System.Drawing.Point(0, 50);
            this.GVQuery.MultiSelect = false;
            this.GVQuery.Name = "GVQuery";
            this.GVQuery.ReadOnly = true;
            this.GVQuery.RowHeadersVisible = false;
            this.GVQuery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GVQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVQuery.Size = new System.Drawing.Size(1264, 603);
            this.GVQuery.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TBSearch);
            this.panel2.Controls.Add(this.CBSearch);
            this.panel2.Controls.Add(this.BSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 653);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 28);
            this.panel2.TabIndex = 5;
            // 
            // TBSearch
            // 
            this.TBSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBSearch.Location = new System.Drawing.Point(238, 0);
            this.TBSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(805, 26);
            this.TBSearch.TabIndex = 0;
            // 
            // CBSearch
            // 
            this.CBSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.CBSearch.Location = new System.Drawing.Point(0, 0);
            this.CBSearch.MaxDropDownItems = 12;
            this.CBSearch.Name = "CBSearch";
            this.CBSearch.Size = new System.Drawing.Size(238, 28);
            this.CBSearch.TabIndex = 1;
            // 
            // BSearch
            // 
            this.BSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.BSearch.Location = new System.Drawing.Point(1043, 0);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(221, 28);
            this.BSearch.TabIndex = 7;
            this.BSearch.Text = "Найти";
            this.BSearch.UseVisualStyleBackColor = true;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // ViewesTables
            // 
            this.AcceptButton = this.BSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BExit;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.GVQuery);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewesTables";
            this.Text = "ViewesTables";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewesTables_FormClosed);
            this.Load += new System.EventHandler(this.ViewesTables_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVQuery)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTableName;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GVQuery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBSearch;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BExport;
        private System.Windows.Forms.Button BChart;
    }
}