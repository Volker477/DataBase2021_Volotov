namespace DataBase2021_Volotov
{
    partial class Admin_MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BExit = new System.Windows.Forms.Button();
            this.LLogin = new System.Windows.Forms.Label();
            this.BUserManeger = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BUserManeger);
            this.panel1.Controls.Add(this.BExit);
            this.panel1.Controls.Add(this.LLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 50);
            this.panel1.TabIndex = 0;
            // 
            // BExit
            // 
            this.BExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BExit.Location = new System.Drawing.Point(1020, 0);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(242, 48);
            this.BExit.TabIndex = 1;
            this.BExit.Text = "Смена пользователя";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // LLogin
            // 
            this.LLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.LLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLogin.Location = new System.Drawing.Point(0, 0);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(321, 48);
            this.LLogin.TabIndex = 0;
            this.LLogin.Text = "label1";
            this.LLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUserManeger
            // 
            this.BUserManeger.Dock = System.Windows.Forms.DockStyle.Right;
            this.BUserManeger.Location = new System.Drawing.Point(678, 0);
            this.BUserManeger.Name = "BUserManeger";
            this.BUserManeger.Size = new System.Drawing.Size(342, 48);
            this.BUserManeger.TabIndex = 2;
            this.BUserManeger.Text = "Управление пользователями";
            this.BUserManeger.UseVisualStyleBackColor = true;
            this.BUserManeger.Click += new System.EventHandler(this.BUserManeger_Click);
            // 
            // Admin_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin_MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Admin_MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Button BUserManeger;
    }
}