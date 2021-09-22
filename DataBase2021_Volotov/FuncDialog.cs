using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase2021_Volotov
{
    public partial class FuncDialog : Form
    {
        int number;
        String table;
        public FuncDialog(int number)
        {
            this.number = number;
            InitializeComponent();
        }

        private void FuncDialog_Load(object sender, EventArgs e)
        {
            switch (number)
            {
                case 14:
                    P14.BringToFront();
                    table = "\"Поставки магазинов\"";
                    dateTimePicker1.MinDate = DateTime.Now;
                    dateTimePicker1.MaxDate = DateTime.Now.AddYears(1);
                    break;
                case 15:
                    P15_17_18.BringToFront();
                    L15_17_18.Text = "Выводит суммарный объем поставок предприятий, у которых сумма поставок превышает указанное число кг.";
                    table = "\"Поставлявшие ранее большой объем\"";
                    break;
                case 16:
                    P16.BringToFront();
                    table = "\"Постоянные заказчики\"";
                    break;
                case 17:
                    P15_17_18.BringToFront();
                    L15_17_18.Text = "Выводит все предприятия, имеющие опыт работы более указанного числа.";
                    table = "\"Срок работы предприятия\"";
                    break;
                case 18:
                    P15_17_18.BringToFront();
                    L15_17_18.Text = "Выводит все предприятия, штат которого превышает указанное число.";
                    table = "\"Число сотрудников предприятия\"";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewesTables viewesTables;
            switch (number)
            {
                case 14:
                    table += ("('"+dateTimePicker1.Value.Year+"-"+ dateTimePicker1.Value .Month+"-"+ dateTimePicker1.Value.Day + "')");
                    viewesTables = new ViewesTables("SELECT " + table , table+"", false, false);
                    viewesTables.Owner = this.Owner;
                    viewesTables.Show();
                    viewesTables.Size = this.Owner.Size;
                    viewesTables.WindowState = this.Owner.WindowState;
                    viewesTables.Location = this.Owner.Location;
                    this.Owner.Hide();
                    this.Close();
                    break;
                case 15:
                    if (TBValue.Text != "")
                    {
                        table += ("(" + TBValue.Text + ")");
                        viewesTables = new ViewesTables("SELECT * FROM " + table, table + "", false, false);
                        viewesTables.Owner = this.Owner;
                        viewesTables.Show();
                        viewesTables.Size = this.Owner.Size;
                        viewesTables.WindowState = this.Owner.WindowState;
                        viewesTables.Location = this.Owner.Location;
                        this.Owner.Hide();
                        this.Close();
                    }
                    break;
                case 16:
                    if (TBValueKG.Text != ""&& TBValueCount.Text != "")
                    {
                        table += ("(" + TBValueKG.Text + "," + TBValueCount.Text + ")");
                        viewesTables = new ViewesTables("SELECT * FROM " + table, table + "", false, false);
                        viewesTables.Owner = this.Owner;
                        viewesTables.Show();
                        viewesTables.Size = this.Owner.Size;
                        viewesTables.WindowState = this.Owner.WindowState;
                        viewesTables.Location = this.Owner.Location;
                        this.Owner.Hide();
                        this.Close();
                    }
                    break;
                case 17:
                    if (TBValue.Text != "")
                    {
                        table += ("(" + TBValue.Text + ")");
                        viewesTables = new ViewesTables("SELECT * FROM " + table, table + "", false, false);
                        viewesTables.Owner = this.Owner;
                        viewesTables.Show();
                        viewesTables.Size = this.Owner.Size;
                        viewesTables.WindowState = this.Owner.WindowState;
                        viewesTables.Location = this.Owner.Location;
                        this.Owner.Hide();
                        this.Close();
                    }
                    break;
                case 18:
                    if (TBValue.Text != "")
                    {
                        table += ("(" + TBValue.Text + ")");
                        viewesTables = new ViewesTables("SELECT * FROM " + table, table + "", false, false);
                        viewesTables.Owner = this.Owner;
                        viewesTables.Show();
                        viewesTables.Size = this.Owner.Size;
                        viewesTables.WindowState = this.Owner.WindowState;
                        viewesTables.Location = this.Owner.Location;
                        this.Owner.Hide();
                        this.Close();
                    }
                    break;
            }
        }

        private void TBValueINT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
