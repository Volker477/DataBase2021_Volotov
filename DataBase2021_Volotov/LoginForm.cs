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
                TBLogin.Text = "";
                Data.SqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=" + Data.Login + ";Password=" + TBPass.Text + ";Database=postgres;");
                TBPass.Text = "";
                Data.SqlConnection.Open();
                command = new NpgsqlCommand("SELECT pg_has_role('" + Data.Login + "',16920,'member');", Data.SqlConnection);
                bool b = bool.Parse(command.ExecuteScalar().ToString());
                if (b)
                {
                    if (adminForm == null)
                    {
                        adminForm = new Admin_MainForm();
                        adminForm.Owner = this;
                    }
                    adminForm.Show();
                    adminForm.Size = this.Size;
                    adminForm.WindowState = this.WindowState;
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
                    userForm.Show();
                    userForm.Size = this.Size;
                    userForm.WindowState = this.WindowState;
                    userForm.Location = this.Location;
                    this.Hide();
                }
            }
            catch(Exception exc)
            {
                byte[] b = Encoding.UTF8.GetBytes(exc.Message);
                MessageBox.Show( Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(exc.Message)),"Ошибка авторизации");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Data.SqlConnection!=null)
                Data.SqlConnection.Close();
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
