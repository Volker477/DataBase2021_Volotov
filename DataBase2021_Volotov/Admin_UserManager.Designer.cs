namespace DataBase2021_Volotov
{
    partial class Admin_UserManager
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
            this.BExit = new System.Windows.Forms.Button();
            this.LLogin = new System.Windows.Forms.Label();
            this.BDeleteUser = new System.Windows.Forms.Button();
            this.BEditUser = new System.Windows.Forms.Button();
            this.BAddUser = new System.Windows.Forms.Button();
            this.GVUserList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BUpdate);
            this.panel1.Controls.Add(this.LLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BAddUser);
            this.panel1.Controls.Add(this.BEditUser);
            this.panel1.Controls.Add(this.BDeleteUser);
            this.panel1.Controls.Add(this.BExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 50);
            this.panel1.TabIndex = 2;
            // 
            // BExit
            // 
            this.BExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BExit.Location = new System.Drawing.Point(1172, 0);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(90, 48);
            this.BExit.TabIndex = 1;
            this.BExit.Text = "Назад";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // LLogin
            // 
            this.LLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLogin.Location = new System.Drawing.Point(295, 0);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(491, 48);
            this.LLogin.TabIndex = 0;
            this.LLogin.Text = "label1";
            this.LLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BDeleteUser
            // 
            this.BDeleteUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.BDeleteUser.Location = new System.Drawing.Point(1043, 0);
            this.BDeleteUser.Name = "BDeleteUser";
            this.BDeleteUser.Size = new System.Drawing.Size(129, 48);
            this.BDeleteUser.TabIndex = 2;
            this.BDeleteUser.Text = "Удалить";
            this.BDeleteUser.UseVisualStyleBackColor = true;
            this.BDeleteUser.Click += new System.EventHandler(this.BDeleteUser_Click);
            // 
            // BEditUser
            // 
            this.BEditUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.BEditUser.Location = new System.Drawing.Point(917, 0);
            this.BEditUser.Name = "BEditUser";
            this.BEditUser.Size = new System.Drawing.Size(126, 48);
            this.BEditUser.TabIndex = 3;
            this.BEditUser.Text = "Изменить";
            this.BEditUser.UseVisualStyleBackColor = true;
            this.BEditUser.Click += new System.EventHandler(this.BEditUser_Click);
            // 
            // BAddUser
            // 
            this.BAddUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.BAddUser.Location = new System.Drawing.Point(786, 0);
            this.BAddUser.Name = "BAddUser";
            this.BAddUser.Size = new System.Drawing.Size(131, 48);
            this.BAddUser.TabIndex = 4;
            this.BAddUser.Text = "Добавить";
            this.BAddUser.UseVisualStyleBackColor = true;
            this.BAddUser.Click += new System.EventHandler(this.BAddUser_Click);
            // 
            // GVUserList
            // 
            this.GVUserList.AllowUserToAddRows = false;
            this.GVUserList.AllowUserToDeleteRows = false;
            this.GVUserList.AllowUserToResizeColumns = false;
            this.GVUserList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GVUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVUserList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GVUserList.Location = new System.Drawing.Point(0, 50);
            this.GVUserList.MultiSelect = false;
            this.GVUserList.Name = "GVUserList";
            this.GVUserList.ReadOnly = true;
            this.GVUserList.RowHeadersVisible = false;
            this.GVUserList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GVUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVUserList.Size = new System.Drawing.Size(1264, 631);
            this.GVUserList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Текущий пользователь:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUpdate
            // 
            this.BUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.BUpdate.Location = new System.Drawing.Point(660, 0);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(126, 48);
            this.BUpdate.TabIndex = 7;
            this.BUpdate.Text = "Обновить";
            this.BUpdate.UseVisualStyleBackColor = true;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // Admin_UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.GVUserList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_UserManager_FormClosed);
            this.Load += new System.EventHandler(this.Admin_UserManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Button BAddUser;
        private System.Windows.Forms.Button BEditUser;
        private System.Windows.Forms.Button BDeleteUser;
        private System.Windows.Forms.DataGridView GVUserList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BUpdate;
    }
}