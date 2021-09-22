using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace DataBase2021_Volotov
{
    public partial class InsertForm1 : Form
    {
        String query,value="",query2= "')";
        public InsertForm1(String query)
        {
            this.query = query;
            InitializeComponent();
        }
        public InsertForm1(String query,String value, String query2)
        {
            this.query = query;
            this.value = value;
            this.query2 = query2;
            InitializeComponent();
        }


        private void InsertForm1_Load(object sender, EventArgs e)
        {
            if(value!="")
            {
                TB.Text = value;
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            if(TB.Text!=""&&TB.Text!=value)
            {
                query += TB.Text + query2;
                NpgsqlCommand command = new NpgsqlCommand(query,Data.SqlConnection);
                command.ExecuteScalar();
                this.Close();
            }
        }
    }
}
