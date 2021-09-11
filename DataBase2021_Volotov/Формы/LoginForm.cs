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
    public partial class LoginForm : Form
    {
        NpgsqlCommand command;
        Admin_MainForm adminForm;
        User_MainForm userForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Login = TBLogin.Text;
                Data.Pass = TBPass.Text;
                TBLogin.Text = "";
                TBPass.Text = "";
                Data.SqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=" + Data.Login + ";Password=" + Data.Pass + ";Database=postgres;");
                Data.SqlConnection.Open();
                command = new NpgsqlCommand("SELECT Проверка_роли('" + Data.Login + "');", Data.SqlConnection);
                bool b = bool.Parse(command.ExecuteScalar().ToString());
                if (b)
                {
                    if (adminForm == null)
                    {
                        adminForm = new Admin_MainForm();
                        adminForm.Owner = this;
                    }
                    adminForm.Size = this.Size;
                    adminForm.Show();
                    adminForm.Location = this.Location;
                    this.Hide();
                }
                else
                {
                    if (userForm == null)
                    {
                        userForm = new User_MainForm();
                        userForm.Owner = this;
                    }
                    userForm.Size = this.Size;
                    userForm.Show();
                    userForm.Location = this.Location;
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка авторизации");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Data.SqlConnection!=null)
                Data.SqlConnection.Close();
            Application.Exit();
        }
    }
}
