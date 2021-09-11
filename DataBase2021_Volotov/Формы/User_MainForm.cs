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
    public partial class User_MainForm : Form
    {
        public User_MainForm()
        {
            InitializeComponent();
        }

        private void User_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            Data.SqlConnection.Close();
            Data.SqlConnection = null;
            Data.Login = null;
            Data.Pass = null;
            this.Hide();
        }

        private void User_MainForm_Load(object sender, EventArgs e)
        {
            LLogin.Text = Data.Login;
        }
    }
}
