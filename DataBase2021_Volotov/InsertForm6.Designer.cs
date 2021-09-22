namespace DataBase2021_Volotov
{
    partial class InsertForm6
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TBCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.L1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.L3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.L2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.L4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.BOk = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CBM);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 30);
            this.panel2.TabIndex = 10;
            // 
            // CBM
            // 
            this.CBM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBM.FormattingEnabled = true;
            this.CBM.Location = new System.Drawing.Point(73, 0);
            this.CBM.Name = "CBM";
            this.CBM.Size = new System.Drawing.Size(510, 28);
            this.CBM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Магазин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CBP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 30);
            this.panel1.TabIndex = 13;
            // 
            // CBP
            // 
            this.CBP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBP.FormattingEnabled = true;
            this.CBP.Location = new System.Drawing.Point(100, 0);
            this.CBP.Name = "CBP";
            this.CBP.Size = new System.Drawing.Size(483, 28);
            this.CBP.TabIndex = 1;
            this.CBP.SelectedIndexChanged += new System.EventHandler(this.CBS_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продукция";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TBCount);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 28);
            this.panel4.TabIndex = 14;
            // 
            // TBCount
            // 
            this.TBCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBCount.Location = new System.Drawing.Point(127, 0);
            this.TBCount.Name = "TBCount";
            this.TBCount.Size = new System.Drawing.Size(456, 26);
            this.TBCount.TabIndex = 1;
            this.TBCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Количество кг";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DTP);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 28);
            this.panel3.TabIndex = 15;
            // 
            // DTP
            // 
            this.DTP.CustomFormat = "yyyy-MM-dd";
            this.DTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP.Location = new System.Drawing.Point(127, 0);
            this.DTP.MaxDate = new System.DateTime(3699, 11, 27, 0, 0, 0, 0);
            this.DTP.MinDate = new System.DateTime(2021, 9, 22, 0, 0, 0, 0);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(456, 26);
            this.DTP.TabIndex = 1;
            this.DTP.Value = new System.DateTime(2021, 9, 22, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата поставки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.L1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 30);
            this.panel5.TabIndex = 16;
            // 
            // L1
            // 
            this.L1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L1.Location = new System.Drawing.Point(100, 0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(483, 28);
            this.L1.TabIndex = 1;
            this.L1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Овощ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.L3);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 120);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(585, 30);
            this.panel6.TabIndex = 17;
            // 
            // L3
            // 
            this.L3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L3.Location = new System.Drawing.Point(100, 0);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(483, 28);
            this.L3.TabIndex = 1;
            this.L3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Цена:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.L2);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 90);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(585, 30);
            this.panel7.TabIndex = 18;
            // 
            // L2
            // 
            this.L2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L2.Location = new System.Drawing.Point(100, 0);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(483, 28);
            this.L2.TabIndex = 1;
            this.L2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Сорт:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.L4);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 150);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(585, 30);
            this.panel8.TabIndex = 19;
            // 
            // L4
            // 
            this.L4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L4.Location = new System.Drawing.Point(100, 0);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(483, 28);
            this.L4.TabIndex = 1;
            this.L4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Поставщик:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(298, 242);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(275, 32);
            this.BCancel.TabIndex = 21;
            this.BCancel.Text = "Отменить";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(17, 242);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(275, 32);
            this.BOk.TabIndex = 20;
            this.BOk.Text = "Подтвердить";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // InsertForm6
            // 
            this.AcceptButton = this.BOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(585, 283);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertForm6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertForm6";
            this.Load += new System.EventHandler(this.InsertForm6_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TBCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BOk;
    }
}