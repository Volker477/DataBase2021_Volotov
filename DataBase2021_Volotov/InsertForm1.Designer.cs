namespace DataBase2021_Volotov
{
    partial class InsertForm1
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
            this.TB = new System.Windows.Forms.TextBox();
            this.BOk = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB.Location = new System.Drawing.Point(0, 0);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(355, 26);
            this.TB.TabIndex = 0;
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(0, 32);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(174, 32);
            this.BOk.TabIndex = 1;
            this.BOk.Text = "Подтвердить";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(180, 32);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(174, 32);
            this.BCancel.TabIndex = 2;
            this.BCancel.Text = "Отменить";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // InsertForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(355, 67);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.TB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertForm1";
            this.Load += new System.EventHandler(this.InsertForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Button BCancel;
    }
}