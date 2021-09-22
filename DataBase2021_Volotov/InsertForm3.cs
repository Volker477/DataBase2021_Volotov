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
    public partial class InsertForm3 : Form
    {
        int? id, idR, idTS, count, year;
        String name="", phone;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&e.KeyChar!='\b')
            {
                e.Handled = true;
            }
        }

        public InsertForm3()
        {
            InitializeComponent();
        }
        public InsertForm3(int? id,String name,int? idR,int? idTS,String count,String year,String phone)
        {
            this.id = id;
            this.idR = idR;
            this.idTS = idTS;
            if(count!="")
                this.count = int.Parse(count);
            if(year!="")
                this.year = int.Parse(year);
            this.name = name;
            this.phone = phone;
            InitializeComponent();
        }

        private void InsertForm3_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = new NpgsqlCommand("SELECT Название FROM Район_области", Data.SqlConnection);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1);
            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                CBR.Items.Add(row.ItemArray[0].ToString());
            }
            adapter.SelectCommand = new NpgsqlCommand("SELECT Название FROM Тип_собственности", Data.SqlConnection);
            DataSet ds2 = new DataSet();
            adapter.Fill(ds2);
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                CBTS.Items.Add(row.ItemArray[0].ToString());
            }
            if (name!="")
            {
                TBName.Text = name;
                CBR.SelectedItem = new NpgsqlCommand("SELECT Название FROM Район_области WHERE id=" + idR,Data.SqlConnection).ExecuteScalar().ToString();
                CBTS.SelectedItem = new NpgsqlCommand("SELECT Название FROM Тип_собственности WHERE id=" + idTS, Data.SqlConnection).ExecuteScalar().ToString();
                TBPhone.Text = phone;
                if (count != null)
                    TBCount.Text = count.ToString();
                if (year != null)
                    TBYear.Text = year.ToString();
            }
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            if(TBName.Text!=""&&CBR.SelectedIndex!=-1&&CBTS.SelectedIndex!=-1)
            {
                if(name=="")
                {
                    String sql1, sql2;
                    sql1 = "INSERT INTO Предприятие_(Название,\"Код района\",\"Код типа собственности\",Телефон";
                    sql2 = ") VALUES ('"+TBName.Text+"',"+ new NpgsqlCommand("SELECT id FROM Район_области WHERE Название='" + CBR.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString()+","+ new NpgsqlCommand("SELECT id FROM Тип_собственности WHERE Название='" + CBTS.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString()+",'"+TBPhone.Text+"'";
                    if(TBCount.Text!="")
                    {
                        sql1 += ",\"Число сотрудников\"";
                        sql2 += "," + TBCount.Text;
                    }
                    if(TBYear.Text!="")
                    {
                        sql1 += ",\"Год начала работы\"";
                        sql2 += "," + TBYear.Text;
                    }
                    new NpgsqlCommand(sql1+sql2+")",Data.SqlConnection).ExecuteScalar();
                }
                else
                {
                    String sql = "UPDATE Предприятие_ SET Название='"+ TBName.Text + "',\"Код района\"="+ new NpgsqlCommand("SELECT id FROM Район_области WHERE Название='" + CBR.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString()+ ",\"Код типа собственности\"=" + new NpgsqlCommand("SELECT id FROM Тип_собственности WHERE Название='" + CBTS.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString()+",Телефон='"+TBPhone.Text+"'";
                    if (TBCount.Text != "")
                    {
                        sql += ",\"Число сотрудников\"="+ TBCount.Text;
                    }
                    else
                    {
                        sql += ",\"Число сотрудников\"=NULL";
                    }
                    if (TBYear.Text != "")
                    {
                        sql += ",\"Год начала работы\"="+ TBYear.Text;
                    }
                    else
                    {
                        sql += ",\"Год начала работы\"=NULL";
                    }
                    new NpgsqlCommand(sql+" WHERE id="+id,Data.SqlConnection).ExecuteScalar();
                }
                this.Close();
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
