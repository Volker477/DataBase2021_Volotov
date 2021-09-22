namespace DataBase2021_Volotov
{
    partial class FuncDialog
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
            this.P14 = new System.Windows.Forms.Panel();
            this.L14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.P15_17_18 = new System.Windows.Forms.Panel();
            this.L15_17_18 = new System.Windows.Forms.Label();
            this.TBValue = new System.Windows.Forms.TextBox();
            this.P16 = new System.Windows.Forms.Panel();
            this.L16 = new System.Windows.Forms.Label();
            this.TBValueKG = new System.Windows.Forms.TextBox();
            this.TBValueCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.P14.SuspendLayout();
            this.P15_17_18.SuspendLayout();
            this.P16.SuspendLayout();
            this.SuspendLayout();
            // 
            // P14
            // 
            this.P14.Controls.Add(this.L14);
            this.P14.Controls.Add(this.dateTimePicker1);
            this.P14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P14.Location = new System.Drawing.Point(0, 0);
            this.P14.Name = "P14";
            this.P14.Size = new System.Drawing.Size(444, 138);
            this.P14.TabIndex = 0;
            // 
            // L14
            // 
            this.L14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L14.Location = new System.Drawing.Point(0, 0);
            this.L14.Name = "L14";
            this.L14.Size = new System.Drawing.Size(444, 112);
            this.L14.TabIndex = 1;
            this.L14.Text = "Выводит количество поставок к в каждый магазин, которые прибудут в указанный день" +
    ".";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 112);
            this.dateTimePicker1.MaxDate = new System.DateTime(3699, 11, 27, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 9, 18, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(444, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 9, 18, 0, 0, 0, 0);
            // 
            // P15_17_18
            // 
            this.P15_17_18.Controls.Add(this.L15_17_18);
            this.P15_17_18.Controls.Add(this.TBValue);
            this.P15_17_18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P15_17_18.Location = new System.Drawing.Point(0, 0);
            this.P15_17_18.Name = "P15_17_18";
            this.P15_17_18.Size = new System.Drawing.Size(444, 138);
            this.P15_17_18.TabIndex = 1;
            // 
            // L15_17_18
            // 
            this.L15_17_18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L15_17_18.Location = new System.Drawing.Point(0, 0);
            this.L15_17_18.Name = "L15_17_18";
            this.L15_17_18.Size = new System.Drawing.Size(444, 112);
            this.L15_17_18.TabIndex = 2;
            this.L15_17_18.Text = "label1";
            // 
            // TBValue
            // 
            this.TBValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TBValue.Location = new System.Drawing.Point(0, 112);
            this.TBValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBValue.Name = "TBValue";
            this.TBValue.Size = new System.Drawing.Size(444, 26);
            this.TBValue.TabIndex = 7;
            this.TBValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBValueINT_KeyPress);
            // 
            // P16
            // 
            this.P16.Controls.Add(this.L16);
            this.P16.Controls.Add(this.TBValueKG);
            this.P16.Controls.Add(this.TBValueCount);
            this.P16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P16.Location = new System.Drawing.Point(0, 0);
            this.P16.Name = "P16";
            this.P16.Size = new System.Drawing.Size(444, 138);
            this.P16.TabIndex = 2;
            // 
            // L16
            // 
            this.L16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L16.Location = new System.Drawing.Point(0, 0);
            this.L16.Name = "L16";
            this.L16.Size = new System.Drawing.Size(444, 86);
            this.L16.TabIndex = 2;
            this.L16.Text = "Выводит список постоянных заказчиков. Постоянным заказчиком считается  магазин, з" +
    "аказавший товаров более указанной массы(верхняя строка) более указанного количес" +
    "тва(нижняя строка).";
            // 
            // TBValueKG
            // 
            this.TBValueKG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TBValueKG.Location = new System.Drawing.Point(0, 86);
            this.TBValueKG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBValueKG.Name = "TBValueKG";
            this.TBValueKG.Size = new System.Drawing.Size(444, 26);
            this.TBValueKG.TabIndex = 7;
            this.TBValueKG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBValueINT_KeyPress);
            // 
            // TBValueCount
            // 
            this.TBValueCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TBValueCount.Location = new System.Drawing.Point(0, 112);
            this.TBValueCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBValueCount.Name = "TBValueCount";
            this.TBValueCount.Size = new System.Drawing.Size(444, 26);
            this.TBValueCount.TabIndex = 6;
            this.TBValueCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBValueINT_KeyPress);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(444, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FuncDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 176);
            this.Controls.Add(this.P15_17_18);
            this.Controls.Add(this.P16);
            this.Controls.Add(this.P14);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FuncDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FuncDialog";
            this.Load += new System.EventHandler(this.FuncDialog_Load);
            this.P14.ResumeLayout(false);
            this.P15_17_18.ResumeLayout(false);
            this.P15_17_18.PerformLayout();
            this.P16.ResumeLayout(false);
            this.P16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P14;
        private System.Windows.Forms.Label L14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel P15_17_18;
        private System.Windows.Forms.Label L15_17_18;
        private System.Windows.Forms.Panel P16;
        private System.Windows.Forms.Label L16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBValue;
        private System.Windows.Forms.TextBox TBValueKG;
        private System.Windows.Forms.TextBox TBValueCount;
    }
}