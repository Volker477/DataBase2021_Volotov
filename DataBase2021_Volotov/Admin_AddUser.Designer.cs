namespace DataBase2021_Volotov
{
    partial class Admin_AddUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.BAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBPass
            // 
            this.TBPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBPass.Location = new System.Drawing.Point(0, 67);
            this.TBPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(444, 26);
            this.TBPass.TabIndex = 6;
            // 
            // BAddUser
            // 
            this.BAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BAddUser.Location = new System.Drawing.Point(0, 141);
            this.BAddUser.Name = "BAddUser";
            this.BAddUser.Size = new System.Drawing.Size(444, 35);
            this.BAddUser.TabIndex = 8;
            this.BAddUser.Text = "Добавить";
            this.BAddUser.UseVisualStyleBackColor = true;
            this.BAddUser.Click += new System.EventHandler(this.BAddUser_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя пользователя:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBLogin
            // 
            this.TBLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBLogin.Location = new System.Drawing.Point(0, 20);
            this.TBLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(444, 26);
            this.TBLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Роль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBRole
            // 
            this.CBRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRole.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.CBRole.Location = new System.Drawing.Point(0, 113);
            this.CBRole.Name = "CBRole";
            this.CBRole.Size = new System.Drawing.Size(444, 28);
            this.CBRole.TabIndex = 11;
            // 
            // Admin_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 176);
            this.Controls.Add(this.BAddUser);
            this.Controls.Add(this.CBRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin_AddUser";
            this.Load += new System.EventHandler(this.Admin_AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Button BAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBRole;
    }
}