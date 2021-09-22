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
    public partial class InsertForm2 : Form
    {
        int id,id_type;
        String name = "";
        NpgsqlCommand command;
        public InsertForm2()
        {
            InitializeComponent();
        }
        public InsertForm2(int id,int id_type,String name)
        {
            this.name = name;
            this.id = id;
            this.id_type = id_type;
            InitializeComponent();
        }

        private void InsertForm2_Load(object sender, EventArgs e)
        {
            command = new NpgsqlCommand("SELECT Название FROM Вид_овощей", Data.SqlConnection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1);
            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                CB.Items.Add(row.ItemArray[0].ToString());
            }
            if(name!="")
            {
                TB.Text = name;
                command.CommandText = "SELECT Название FROM Вид_овощей WHERE id="+id_type;
                CB.SelectedItem=command.ExecuteScalar().ToString();
            }
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            int type = int.Parse(new NpgsqlCommand("SELECT id FROM Вид_овощей WHERE Название='" + CB.SelectedItem.ToString() + "'", Data.SqlConnection).ExecuteScalar().ToString());
            if (CB.SelectedIndex!=-1&&TB.Text!=""&&(TB.Text!=name||type!=id_type))
            {
                if(name=="")
                {
                    command.CommandText = "INSERT INTO Сорт_овощей(\"Код вида\",Название) VALUES("+ type + ",'"+TB.Text+"')";
                    command.ExecuteScalar();
                }
                else
                {
                    command.CommandText = "UPDATE Сорт_овощей SET \"Код вида\"=" + type + ",Название = '" + TB.Text + "' WHERE id="+id;
                    command.ExecuteScalar();
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
