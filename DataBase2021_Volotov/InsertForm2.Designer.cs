namespace DataBase2021_Volotov
{
    partial class InsertForm2
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
            this.CB = new System.Windows.Forms.ComboBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.BOk = new System.Windows.Forms.Button();
            this.TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CB
            // 
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(2, 12);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(174, 28);
            this.CB.TabIndex = 0;
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(182, 46);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(174, 32);
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Отменить";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(2, 46);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(174, 32);
            this.BOk.TabIndex = 3;
            this.BOk.Text = "Подтвердить";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(182, 12);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(174, 26);
            this.TB.TabIndex = 5;
            // 
            // InsertForm2
            // 
            this.AcceptButton = this.BOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(359, 81);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.CB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertForm2";
            this.Load += new System.EventHandler(this.InsertForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.TextBox TB;
    }
}