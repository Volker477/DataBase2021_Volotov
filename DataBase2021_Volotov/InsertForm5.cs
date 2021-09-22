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
    public partial class InsertForm5 : Form
    {
        int? id, idS, idP;
        String price="";
        public InsertForm5()
        {
            InitializeComponent();
        }
        public InsertForm5(int? id, int? idS, int? idP, String price)
        {
            this.id = id;
            this.idS = idS;
            this.idP = idP;
            this.price = price;
            InitializeComponent();
        }

        private void InsertForm5_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = new NpgsqlCommand("SELECT Название FROM Предприятие_", Data.SqlConnection);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1);
            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                CBP.Items.Add(row.ItemArray[0].ToString());
            }
            adapter.SelectCommand = new NpgsqlCommand("SELECT Название FROM Вид_овощей", Data.SqlConnection);
            DataSet ds2 = new DataSet();
            adapter.Fill(ds2);
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                CBO.Items.Add(row.ItemArray[0].ToString());
            }
            if (price != "")
            {
                TBPrice.Text = price;
                CBP.SelectedItem = new NpgsqlCommand("SELECT Название FROM Предприятие_ WHERE id=" + idP, Data.SqlConnection).ExecuteScalar().ToString();
                int i = int.Parse(new NpgsqlCommand("SELECT \"Код вида\" FROM Сорт_овощей WHERE id=" + idS, Data.SqlConnection).ExecuteScalar().ToString());
                CBO.SelectedItem = new NpgsqlCommand("SELECT Название FROM Вид_овощей WHERE id=" + i, Data.SqlConnection).ExecuteScalar().ToString();
                CBS.SelectedItem = new NpgsqlCommand("SELECT Название FROM Сорт_овощей WHERE id=" + idS, Data.SqlConnection).ExecuteScalar().ToString();
            }
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            if (CBS.SelectedIndex!=-1&&CBP.SelectedIndex!=-1&&TBPrice.Text!="")
            {
                if (price == "")
                {
                    new NpgsqlCommand("INSERT INTO Продукция_(\"Код сорта\",\"Код предприятия\",\"Цена руб за кг\") VALUES ("+ new NpgsqlCommand("SELECT id FROM Сорт_овощей WHERE Название='" + CBS.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString()+","+ new NpgsqlCommand("SELECT id FROM Предприятие_ WHERE Название='" + CBP.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString() + ","+TBPrice.Text + ")", Data.SqlConnection).ExecuteScalar();
                }
                else
                {                    
                    new NpgsqlCommand("UPDATE Продукция_ SET \"Код сорта\"=" + new NpgsqlCommand("SELECT id FROM Сорт_овощей WHERE Название='" + CBS.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString() + ",\"Код предприятия\"=" + new NpgsqlCommand("SELECT id FROM Предприятие_ WHERE Название='" + CBP.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString() + ",\"Цена руб за кг\"=" + TBPrice.Text + " WHERE id=" + id, Data.SqlConnection).ExecuteScalar();
                }
                this.Close();
            }
        }

        private void CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBO.SelectedIndex != -1)
            {
                CBS.SelectedIndex = -1;
                CBS.Items.Clear();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = new NpgsqlCommand("SELECT Название FROM Сорт_овощей WHERE \"Код вида\"=" + new NpgsqlCommand("SELECT id FROM Вид_овощей WHERE Название='" + CBO.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString(), Data.SqlConnection);
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                foreach (DataRow row in ds1.Tables[0].Rows)
                {
                    CBS.Items.Add(row.ItemArray[0].ToString());
                }
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
