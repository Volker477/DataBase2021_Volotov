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
            this.LLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BUserManeger = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LBViews = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LBTables = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BUserManeger);
            this.panel1.Controls.Add(this.BExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 50);
            this.panel1.TabIndex = 0;
            // 
            // LLogin
            // 
            this.LLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLogin.Location = new System.Drawing.Point(295, 0);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(383, 48);
            this.LLogin.TabIndex = 0;
            this.LLogin.Text = "label1";
            this.LLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // BExit
            // 
            this.BExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BExit.Location = new System.Drawing.Point(1020, 0);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(242, 48);
            this.BExit.TabIndex = 1;
            this.BExit.Text = "Смена пользователя";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 631);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LBViews);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запросы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LBViews
            // 
            this.LBViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBViews.FormattingEnabled = true;
            this.LBViews.ItemHeight = 20;
            this.LBViews.Items.AddRange(new object[] {
            "Все поставки",
            "Заказы у гос поставщиков",
            "Магазины",
            "Не имеющиеся в наличии виды овощей",
            "Объем  поставок и средняя цена ово",
            "Овощи",
            "Предприятия",
            "Продукция_сборка",
            "Состояние поставок",
            "Средняя цена овощей",
            "Срочные поставки",
            "Число видов товаров у предприятий",
            "Число магазинов в районе",
            "Число сортов",
            "Поставки магазинов",
            "Поставлявшие ранее большой объем",
            "Постоянные заказчики",
            "Срок работы предприятия",
            "Число сотрудников предприятия"});
            this.LBViews.Location = new System.Drawing.Point(3, 3);
            this.LBViews.Name = "LBViews";
            this.LBViews.Size = new System.Drawing.Size(1250, 592);
            this.LBViews.TabIndex = 2;
            this.LBViews.DoubleClick += new System.EventHandler(this.LBViews_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LBTables);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблицы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LBTables
            // 
            this.LBTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBTables.FormattingEnabled = true;
            this.LBTables.ItemHeight = 20;
            this.LBTables.Items.AddRange(new object[] {
            "Вид_овощей",
            "Магазин_",
            "Отмененные_поставки",
            "Поставка_",
            "Предприятие_",
            "Продукция_",
            "Район_города",
            "Район_магазина",
            "Район_области",
            "Сорт_овощей",
            "Тип_собственности"});
            this.LBTables.Location = new System.Drawing.Point(3, 3);
            this.LBTables.Name = "LBTables";
            this.LBTables.Size = new System.Drawing.Size(1250, 592);
            this.LBTables.TabIndex = 3;
            this.LBTables.DoubleClick += new System.EventHandler(this.LBTables_DoubleClick);
            // 
            // Admin_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BExit;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin_MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Admin_MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.Admin_MainForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Button BUserManeger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox LBViews;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox LBTables;
    }
}