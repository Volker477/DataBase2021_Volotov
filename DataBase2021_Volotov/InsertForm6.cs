using Npgsql;
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
    public partial class InsertForm6 : Form
    {
        int? id, idP, idM;
        String date, count="";
        public InsertForm6()
        {
            InitializeComponent();
        }
        public InsertForm6(int? id, int? idM, int? idP, String count, String date)
        {
            this.id = id;
            this.idM = idM;
            this.idP = idP;
            this.count = count;
            this.date = date;
            InitializeComponent();
        }

        private void InsertForm6_Load(object sender, EventArgs e)
        {
            DTP.MinDate = DateTime.Now.AddYears(-3);
            DTP.MaxDate = DateTime.Now.AddYears(1);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = new NpgsqlCommand("SELECT id FROM Продукция_", Data.SqlConnection);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1);
            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                CBP.Items.Add(row.ItemArray[0].ToString());
            }
            adapter.SelectCommand = new NpgsqlCommand("SELECT Название FROM Магазин_", Data.SqlConnection);
            DataSet ds2 = new DataSet();
            adapter.Fill(ds2);
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                CBM.Items.Add(row.ItemArray[0].ToString());
            }
            if (count != "")
            {
                if (DTP.MinDate > DateTime.Parse(date))
                    DTP.MinDate = DateTime.Parse(date);
                TBCount.Text = count;
                CBP.SelectedItem = idP.ToString();
                CBM.SelectedItem = new NpgsqlCommand("SELECT Название FROM Магазин_ WHERE id=" + idM, Data.SqlConnection).ExecuteScalar().ToString();
                DTP.Value = DateTime.Parse(date);
            }
        }

        private void CBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBP.SelectedIndex!=-1)
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = new NpgsqlCommand("SELECT * FROM Продукция_сборка WHERE id=" + CBP.SelectedItem.ToString(), Data.SqlConnection);
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                L1.Text = ds1.Tables[0].Rows[0].ItemArray[1].ToString();
                L2.Text = ds1.Tables[0].Rows[0].ItemArray[2].ToString();
                L3.Text = ds1.Tables[0].Rows[0].ItemArray[3].ToString();
                L4.Text = ds1.Tables[0].Rows[0].ItemArray[4].ToString();
            }
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            if (CBM.SelectedIndex != -1 && CBP.SelectedIndex != -1 && TBCount.Text != "")
            {
                if (count == "")
                {
                    new NpgsqlCommand("INSERT INTO Поставка_ (\"Код магазина\",\"Код продукции\",\"Количество кг\",\"Дата поставки\") VALUES (" + new NpgsqlCommand("SELECT id FROM Магазин_ WHERE Название='" + CBM.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString() + "," + CBP.SelectedItem.ToString() + "," + TBCount.Text+ ",'" + DTP.Value.Year + "-" + DTP.Value.Month + "-" + DTP.Value.Day + "')", Data.SqlConnection).ExecuteScalar();
                }
                else
                {
                    new NpgsqlCommand("UPDATE Поставка_ SET \"Код магазина\"=" + new NpgsqlCommand("SELECT id FROM Магазин_ WHERE Название='" + CBM.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString() + ",\"Код продукции\"=" + CBP.SelectedItem.ToString() + ",\"Количество кг\"=" + TBCount.Text + ",\"Дата поставки\"='" + DTP.Value.Year + "-" + DTP.Value.Month + "-" + DTP.Value.Day + "' WHERE id=" + id, Data.SqlConnection).ExecuteScalar();
                }
                this.Close();
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
