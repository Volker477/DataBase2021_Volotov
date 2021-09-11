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
    public partial class Admin_MainForm : Form
    {
        Admin_UserManager userManager;
        public Admin_MainForm()
        {
            InitializeComponent();
        }

        private void Admin_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_MainForm_Load(object sender, EventArgs e)
        {
            LLogin.Text = Data.Login;
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Owner.WindowState = this.WindowState;
            this.Owner.Size = this.Size;
            this.Owner.Location = this.Location;
            this.Owner.Show();
            Data.SqlConnection.Close();
            Data.SqlConnection = null;
            Data.Login = null;
            this.Hide();
        }

        private void BUserManeger_Click(object sender, EventArgs e)
        {
            if (userManager == null)
            {
                userManager = new Admin_UserManager();
                userManager.Owner = this;
            }
            userManager.Show();
            userManager.Size = this.Size;
            userManager.Location = this.Location;
            userManager.WindowState = this.WindowState;
            this.Hide();
        }
    }
}
