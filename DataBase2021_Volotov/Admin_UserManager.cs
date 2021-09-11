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
    public partial class Admin_UserManager : Form
    {
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        public Admin_UserManager()
        {
            InitializeComponent();
        }

        private void Admin_UserManager_Load(object sender, EventArgs e)
        {
            LLogin.Text = Data.Login;
            command = new NpgsqlCommand("SELECT * FROM Список_пользователей;",Data.SqlConnection);
            adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds=new DataSet();
            adapter.Fill(ds);
            GVUserList.DataSource = ds.Tables[0];
        }

        private void Admin_UserManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Owner.WindowState = this.WindowState;
            this.Owner.Size = this.Size;
            this.Owner.Location = this.Location;
            this.Owner.Show();
            this.Hide();
        }

        private void BDeleteUser_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены что хотиете удалить пользователя ["+GVUserList.SelectedRows[0].Cells[0].Value.ToString()+"]?","Удаление пользователя",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    NpgsqlCommand comm = new NpgsqlCommand("DROP ROLE \""+GVUserList.SelectedRows[0].Cells[0].Value.ToString() + "\";", Data.SqlConnection);
                    comm.ExecuteScalar();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    MessageBox.Show("Пользователь успешно удален");
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    GVUserList.DataSource = ds.Tables[0];
                }
            }
        }

        private void BEditUser_Click(object sender, EventArgs e)
        {
            bool admin=false;
            if (GVUserList.SelectedRows[0].Cells[1].Value.ToString() == "Администратор")
                admin = true;
            Admin_AddUser addUser = new Admin_AddUser(GVUserList.SelectedRows[0].Cells[0].Value.ToString(),admin);
            addUser.Owner = this;
            addUser.ShowDialog();
        }

        private void BAddUser_Click(object sender, EventArgs e)
        {
            Admin_AddUser addUser = new Admin_AddUser();
            addUser.ShowDialog();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            GVUserList.DataSource = ds.Tables[0];
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            GVUserList.DataSource = ds.Tables[0];
        }
    }
}
