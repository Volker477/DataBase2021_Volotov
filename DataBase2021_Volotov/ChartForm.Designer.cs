namespace DataBase2021_Volotov
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Diag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Diag)).BeginInit();
            this.SuspendLayout();
            // 
            // Diag
            // 
            chartArea3.Name = "ChartArea1";
            this.Diag.ChartAreas.Add(chartArea3);
            this.Diag.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.Diag.Legends.Add(legend3);
            this.Diag.Location = new System.Drawing.Point(0, 0);
            this.Diag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Diag.Name = "Diag";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Diag.Series.Add(series3);
            this.Diag.Size = new System.Drawing.Size(790, 486);
            this.Diag.TabIndex = 0;
            // 
            // BClose
            // 
            this.BClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BClose.Location = new System.Drawing.Point(328, 114);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(10, 10);
            this.BClose.TabIndex = 1;
            this.BClose.Text = "button1";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BClose;
            this.ClientSize = new System.Drawing.Size(790, 486);
            this.Controls.Add(this.Diag);
            this.Controls.Add(this.BClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Diag;
        private System.Windows.Forms.Button BClose;
    }
}