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
    public partial class ViewesTables : Form
    {
        bool admin,edited,bexit;
        String query, table;
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        
        private void ViewesTables_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!bexit)
                Application.Exit();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            if(TBSearch.Text=="")
            {
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                GVQuery.DataSource = ds1.Tables[0];
            }
            else if(CBSearch.SelectedIndex!=-1)
            {
                command = new NpgsqlCommand(query+" WHERE "+CBSearch.Text+" LIKE '%"+TBSearch.Text+"%'", Data.SqlConnection);
                adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                GVQuery.DataSource = ds1.Tables[0];
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            switch (table)
            {
                case "Вид_овощей":
                    InsertForm1 insertForm1 = new InsertForm1("INSERT INTO \"Вид_овощей\"(\"Название\")	VALUES ('");
                    insertForm1.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
                case "Район_области":
                    InsertForm1 insertForm2 = new InsertForm1("INSERT INTO \"Район_области\"(\"Название\")	VALUES ('");
                    insertForm2.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
                case "Тип_собственности":
                    InsertForm1 insertForm3 = new InsertForm1("INSERT INTO \"Тип_собственности\"(\"Название\")	VALUES ('");
                    insertForm3.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
                case "Район_города":
                    InsertForm1 insertForm4 = new InsertForm1("INSERT INTO \"Район_города\"(\"Название\")	VALUES ('");
                    insertForm4.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
                case "Сорт_овощей":
                    InsertForm2 insertForm5 = new InsertForm2();
                    insertForm5.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
                case "Предприятие_":
                    InsertForm3 insertForm6 = new InsertForm3();
                    insertForm6.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
                case "Продукция_":
                    InsertForm5 insertForm7 = new InsertForm5();
                    insertForm7.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
                case "Магазин_":
                    InsertForm4 insertForm8 = new InsertForm4();
                    insertForm8.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
                case "Поставка_":
                    InsertForm6 insertForm9 = new InsertForm6();
                    insertForm9.ShowDialog();
                    adapter.Fill(ds1);
                    GVQuery.DataSource = ds1.Tables[0];
                    break;
            }
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            if (GVQuery.SelectedRows.Count > 0)
            {
                DataSet ds1 = new DataSet();
                switch (table)
                {
                    case "Вид_овощей":
                        InsertForm1 insertForm1 = new InsertForm1("UPDATE \"Вид_овощей\" SET \"Название\" = '", GVQuery.SelectedRows[0].Cells[1].Value.ToString(), "' WHERE \"id\"=" + GVQuery.SelectedRows[0].Cells[0].Value);
                        insertForm1.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                    case "Район_области":
                        InsertForm1 insertForm2 = new InsertForm1("UPDATE \"Район_области\" SET \"Название\" = '", GVQuery.SelectedRows[0].Cells[1].Value.ToString(), "' WHERE \"id\"=" + GVQuery.SelectedRows[0].Cells[0].Value);
                        insertForm2.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                    case "Тип_собственности":
                        InsertForm1 insertForm3 = new InsertForm1("UPDATE \"Тип_собственности\" SET \"Название\" = '", GVQuery.SelectedRows[0].Cells[1].Value.ToString(), "' WHERE \"id\"=" + GVQuery.SelectedRows[0].Cells[0].Value);
                        insertForm3.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                    case "Район_города":
                        InsertForm1 insertForm4 = new InsertForm1("UPDATE \"Район_города\" SET \"Название\" = '", GVQuery.SelectedRows[0].Cells[1].Value.ToString(), "' WHERE \"id\"=" + GVQuery.SelectedRows[0].Cells[0].Value);
                        insertForm4.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                    case "Сорт_овощей":
                        InsertForm2 insertForm5 = new InsertForm2(int.Parse(GVQuery.SelectedRows[0].Cells[0].Value.ToString()), int.Parse(GVQuery.SelectedRows[0].Cells[1].Value.ToString()), GVQuery.SelectedRows[0].Cells[2].Value.ToString());
                        insertForm5.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                    case "Предприятие_":
                        InsertForm3 insertForm6 = new InsertForm3(int.Parse(GVQuery.SelectedRows[0].Cells[0].Value.ToString()),GVQuery.SelectedRows[0].Cells[1].Value.ToString(), int.Parse(GVQuery.SelectedRows[0].Cells[2].Value.ToString()), int.Parse(GVQuery.SelectedRows[0].Cells[3].Value.ToString()), GVQuery.SelectedRows[0].Cells[4].Value.ToString(), GVQuery.SelectedRows[0].Cells[5].Value.ToString(), GVQuery.SelectedRows[0].Cells[6].Value.ToString());
                        insertForm6.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                    case "Продукция_":
                        InsertForm5 insertForm7 = new InsertForm5(int.Parse(GVQuery.SelectedRows[0].Cells[0].Value.ToString()), int.Parse(GVQuery.SelectedRows[0].Cells[1].Value.ToString()), int.Parse(GVQuery.SelectedRows[0].Cells[2].Value.ToString()), GVQuery.SelectedRows[0].Cells[3].Value.ToString());
                        insertForm7.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                    case "Магазин_":
                        InsertForm4 insertForm8 = new InsertForm4(int.Parse(GVQuery.SelectedRows[0].Cells[0].Value.ToString()), GVQuery.SelectedRows[0].Cells[1].Value.ToString(), int.Parse(GVQuery.SelectedRows[0].Cells[2].Value.ToString()), GVQuery.SelectedRows[0].Cells[3].Value.ToString(), GVQuery.SelectedRows[0].Cells[4].Value.ToString());
                        insertForm8.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                    case "Поставка_":
                        InsertForm6 insertForm9 = new InsertForm6(int.Parse(GVQuery.SelectedRows[0].Cells[0].Value.ToString()), int.Parse(GVQuery.SelectedRows[0].Cells[1].Value.ToString()), int.Parse(GVQuery.SelectedRows[0].Cells[2].Value.ToString()), GVQuery.SelectedRows[0].Cells[3].Value.ToString(), GVQuery.SelectedRows[0].Cells[4].Value.ToString());
                        insertForm9.ShowDialog();
                        adapter.Fill(ds1);
                        GVQuery.DataSource = ds1.Tables[0];
                        break;
                }
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            new NpgsqlCommand("DELETE FROM "+table+" WHERE id="+ GVQuery.SelectedRows[0].Cells[0].Value.ToString(), Data.SqlConnection).ExecuteScalar();
            adapter.Fill(ds1);
            GVQuery.DataSource = ds1.Tables[0];
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Owner.WindowState = this.WindowState;
            this.Owner.Size = this.Size;
            this.Owner.Location = this.Location;
            this.Owner.Show();
            bexit = true;
            this.Close();
        }

        public ViewesTables(String query, String table, bool admin,bool edited)
        {
            this.query = query;
            this.table = table;
            this.admin = admin;
            this.edited = edited;
            InitializeComponent();
        }
        private void ViewesTables_Load(object sender, EventArgs e)
        {
            bexit = false;
            LTableName.Text = table;
            TBSearch.Text = "";
            if(admin&&edited)
            {
                BAdd.Visible = true;
                BEdit.Visible = true;
                BDelete.Visible = true;
            }
            else
            {
                BAdd.Visible = false;
                BEdit.Visible = false;
                BDelete.Visible = false;
            }
            command = new NpgsqlCommand(query, Data.SqlConnection);
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1);
            GVQuery.DataSource = ds1.Tables[0];
            foreach (var column in ds1.Tables[0].Columns)
            {
                CBSearch.Items.Add(column.ToString());
            }
        }
    }
}
