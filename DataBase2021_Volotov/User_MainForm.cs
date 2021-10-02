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
            this.Owner.WindowState = this.WindowState;
            this.Owner.Size = this.Size;
            this.Owner.Location = this.Location;
            this.Owner.Show();
            Data.SqlConnection.Close();
            Data.SqlConnection = null;
            Data.Login = null;
            this.Hide();
        }

        private void User_MainForm_Load(object sender, EventArgs e)
        {
            LLogin.Text = Data.Login;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (LBViews.SelectedIndex != -1)
            {
                if(LBViews.SelectedIndex<14)
                {
                    ViewesTables viewesTables;
                    viewesTables = new ViewesTables("SELECT * FROM \"" + LBViews.Text+ "\"", LBViews.Text, false, false);
                    viewesTables.Owner = this;
                    viewesTables.Show();
                    viewesTables.Size = this.Size;
                    viewesTables.WindowState = this.WindowState;
                    viewesTables.Location = this.Location;
                    this.Hide();
                }
                else
                {
                    FuncDialog dialog = new FuncDialog(LBViews.SelectedIndex);
                    dialog.Owner = this;
                    dialog.ShowDialog();
                }
            }
        }

        private void LBTables_DoubleClick(object sender, EventArgs e)
        {
            if (LBTables.SelectedIndex != -1)
            {
                ViewesTables viewesTables;
                viewesTables = new ViewesTables("SELECT * FROM \"" + LBTables.Text + "\"", LBTables.Text, false, true);
                viewesTables.Owner = this;
                viewesTables.Show();
                viewesTables.Size = this.Size;
                viewesTables.WindowState = this.WindowState;
                viewesTables.Location = this.Location;
                this.Hide();
            }
        }

        private void User_MainForm_VisibleChanged(object sender, EventArgs e)
        {
            LLogin.Text = Data.Login;
        }
    }
}
