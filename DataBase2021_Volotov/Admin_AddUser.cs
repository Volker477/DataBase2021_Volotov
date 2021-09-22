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
    public partial class Admin_AddUser : Form
    {
        String login;
        bool edit=false,admin;
        public Admin_AddUser(String s,bool admin)
        {
            login = s;
            edit = true;
            this.admin = admin;
            InitializeComponent();
        }
        public Admin_AddUser()
        {
            InitializeComponent();
        }

        private void BAddUser_Click(object sender, EventArgs e)
        {
            if(TBLogin.Text!=""&&CBRole.SelectedIndex!=-1)
            {
                NpgsqlCommand command=new NpgsqlCommand();
                command.Connection = Data.SqlConnection;
                if(edit)
                {
                    if(login==Data.Login)
                    {
                        if(MessageBox.Show("Вы уверены что хотиете текущего пользователя? В таком случае вам придется повторно авторизоваться.", "Изменение текущего пользователя", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    if(login!=TBLogin.Text)
                    {
                        command.CommandText = "ALTER ROLE \"" + login + "\" RENAME TO \"" + TBLogin.Text + "\";";
                        command.ExecuteScalar();
                    }
                    if(admin)
                    {
                        if(CBRole.SelectedIndex == 1)
                        {
                            command.CommandText = "REVOKE \"" + TBLogin.Text + "\" FROM \"Admin\";";
                            command.ExecuteScalar();
                            command.CommandText = "GRANT \"User\" TO \"" + TBLogin.Text + "\";";
                            command.ExecuteScalar();
                            command.CommandText = "ALTER ROLE \"" + TBLogin.Text + "\" SET CREATEROLE TO FALSE;";
                            command.ExecuteScalar();
                        }
                    }
                    else
                    {
                        if (CBRole.SelectedIndex == 0)
                        {
                            command.CommandText = "REVOKE \"" + TBLogin.Text + "\" FROM \"User\";";
                            command.ExecuteScalar();
                            command.CommandText = "GRANT \"Admin\" TO \"" + TBLogin.Text + "\";";
                            command.ExecuteScalar();
                            command.CommandText = "ALTER ROLE \"" + TBLogin.Text + "\" SET CREATEROLE TO TRUE;";
                            command.ExecuteScalar();
                        }
                    }
                    if(TBPass.Text!="")
                    {
                        command.CommandText = "ALTER ROLE \""+TBLogin.Text+"\" WITH PASSWORD '"+TBPass.Text+"';";
                        command.ExecuteScalar();
                    }
                    if (login == Data.Login)
                    {
                        this.Owner.Owner.Owner.WindowState = this.Owner.WindowState;
                        this.Owner.Owner.Owner.Size = this.Owner.Size;
                        this.Owner.Owner.Owner.Location = this.Owner.Location;
                        this.Owner.Hide();
                        this.Owner.Owner.Owner.Show();
                    }
                    this.Close();
                }
                else
                {
                    if(CBRole.SelectedIndex == 0)
                    {
                        command.CommandText = "CREATE USER \"" + TBLogin.Text + "\" WITH PASSWORD '" + TBPass.Text + "' CREATEROLE;";
                        command.ExecuteScalar();
                        command.CommandText = "GRANT \"Admin\" TO \"" + TBLogin.Text + "\";";
                        command.ExecuteScalar();
                    }
                    else
                    {
                        command.CommandText = "CREATE USER \"" + TBLogin.Text + "\" WITH PASSWORD '" + TBPass.Text + "';";
                        command.ExecuteScalar();
                        command.CommandText = "GRANT \"User\" TO \"" + TBLogin.Text + "\";";
                        command.ExecuteScalar();

                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все данные","Ошибка");
            }
        }

        private void Admin_AddUser_Load(object sender, EventArgs e)
        {
            TBPass.Text = "";
            if (edit)
            {
                BAddUser.Text = "Изменить";
                label2.Text = "Пароль(оставить пустым если не хотите менять):";
                TBLogin.Text = login;
                NpgsqlCommand command = new NpgsqlCommand("SELECT passwd FROM pg_shadow", Data.SqlConnection);
                if (admin)
                    CBRole.SelectedIndex = 0;
                else
                    CBRole.SelectedIndex = 1;
            }
            else
            {
                BAddUser.Text = "Добавить";
                label2.Text = "Пароль:";
                TBLogin.Text = "";
            }
        }
    }
}
