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
    public partial class InsertForm4 : Form
    {
        int? id, idR;
        String name = "", phone, adres;

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "" && CBR.SelectedIndex != -1)
            {
                if (name == "")
                {
                    String sql1, sql2;
                    sql1 = "INSERT INTO Магазин_(Название,\"Код района\",Телефон";
                    sql2 = ") VALUES ('" + TBName.Text + "'," + new NpgsqlCommand("SELECT id FROM Район_города WHERE Название='" + CBR.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString() +",'" + TBPhone.Text + "'";
                    if (TBAdres.Text != "")
                    {
                        sql1 += ",Адрес";
                        sql2 += ",'" + TBAdres.Text+"'";
                    }
                    new NpgsqlCommand(sql1 + sql2 + ")", Data.SqlConnection).ExecuteScalar();
                }
                else
                {
                    String sql = "UPDATE Магазин_ SET Название='" + TBName.Text + "',\"Код района\"=" + new NpgsqlCommand("SELECT id FROM Район_города WHERE Название='" + CBR.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString() + ",Телефон='" + TBPhone.Text + "'";
                    if (TBAdres.Text != "")
                    {
                        sql += ",Адрес='" + TBAdres.Text+"'";
                    }
                    else
                    {
                        sql += ",Адрес=NULL";
                    }                    
                    new NpgsqlCommand(sql + " WHERE id=" + id, Data.SqlConnection).ExecuteScalar();
                }
                this.Close();
            }
        }

        public InsertForm4()
        {
            InitializeComponent();
        }
        public InsertForm4(int? id, String name, int? idR,String phone, String adres)
        {
            this.id = id;
            this.idR = idR;
            this.name = name;
            this.phone = phone;
            this.adres = adres;
            InitializeComponent();
        }

        private void InsertForm4_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = new NpgsqlCommand("SELECT Название FROM Район_города", Data.SqlConnection);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1);
            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                CBR.Items.Add(row.ItemArray[0].ToString());
            }
            if (name != "")
            {
                TBName.Text = name;
                TBAdres.Text = adres;
                CBR.SelectedItem = new NpgsqlCommand("SELECT Название FROM Район_города WHERE id=" + idR, Data.SqlConnection).ExecuteScalar().ToString();
                TBPhone.Text = phone;
            }

        }
    }
}
