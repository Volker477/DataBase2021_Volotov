namespace DataBase2021_Volotov
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBLogin
            // 
            this.TBLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBLogin.Location = new System.Drawing.Point(557, 275);
            this.TBLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(157, 26);
            this.TBLogin.TabIndex = 0;
            this.TBLogin.Text = "1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя пользователя:";
            // 
            // BLogin
            // 
            this.BLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BLogin.Location = new System.Drawing.Point(557, 361);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(157, 35);
            this.BLogin.TabIndex = 2;
            this.BLogin.Text = "Авторизоваться";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // TBPass
            // 
            this.TBPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBPass.Location = new System.Drawing.Point(557, 327);
            this.TBPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(157, 26);
            this.TBPass.TabIndex = 1;
            this.TBPass.Text = "1";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.BLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPass;
    }
}

