namespace DataBase2021_Volotov
{
    partial class InsertForm3
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
            this.BCancel = new System.Windows.Forms.Button();
            this.BOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CBTS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TBCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(192, 270);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(174, 32);
            this.BCancel.TabIndex = 6;
            this.BCancel.Text = "Отменить";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(12, 270);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(174, 32);
            this.BOk.TabIndex = 5;
            this.BOk.Text = "Подтвердить";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TBName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 28);
            this.panel1.TabIndex = 7;
            // 
            // TBName
            // 
            this.TBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBName.Location = new System.Drawing.Point(83, 0);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(290, 26);
            this.TBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CBR);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 30);
            this.panel2.TabIndex = 8;
            // 
            // CBR
            // 
            this.CBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBR.FormattingEnabled = true;
            this.CBR.Location = new System.Drawing.Point(57, 0);
            this.CBR.Name = "CBR";
            this.CBR.Size = new System.Drawing.Size(316, 28);
            this.CBR.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Район";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CBTS);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 30);
            this.panel3.TabIndex = 9;
            // 
            // CBTS
            // 
            this.CBTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBTS.FormattingEnabled = true;
            this.CBTS.Location = new System.Drawing.Point(154, 0);
            this.CBTS.Name = "CBTS";
            this.CBTS.Size = new System.Drawing.Size(219, 28);
            this.CBTS.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип собственности";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TBCount);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 28);
            this.panel4.TabIndex = 10;
            // 
            // TBCount
            // 
            this.TBCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBCount.Location = new System.Drawing.Point(158, 0);
            this.TBCount.Name = "TBCount";
            this.TBCount.Size = new System.Drawing.Size(215, 26);
            this.TBCount.TabIndex = 1;
            this.TBCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Число сотрудников";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.TBYear);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 28);
            this.panel5.TabIndex = 11;
            // 
            // TBYear
            // 
            this.TBYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBYear.Location = new System.Drawing.Point(158, 0);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(215, 26);
            this.TBYear.TabIndex = 1;
            this.TBYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Год начала работы";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.TBPhone);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(375, 120);
            this.panel6.TabIndex = 12;
            // 
            // TBPhone
            // 
            this.TBPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBPhone.Location = new System.Drawing.Point(0, 91);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(373, 26);
            this.TBPhone.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 91);
            this.label6.TabIndex = 0;
            this.label6.Text = "Телефон. Шаблон номеров:\r\n+380*********\r\n+7 (***) ***-**-**\r\n+8 (***) ***-**-**";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InsertForm3
            // 
            this.AcceptButton = this.BOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(375, 307);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertForm3";
            this.Load += new System.EventHandler(this.InsertForm3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CBTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TBCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label label6;
    }
}