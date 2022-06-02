using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarangayApasHealthInformationSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usr = UsernameTextbox.Text;
            string psw = PasswordtextBox.Text;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM LOGIN where LOGINUSERNAME='" + UsernameTextbox.Text + "' AND LOGINPASSWORD='" + PasswordtextBox.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Submit sistema = new Submit();
                sistema.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();
        }

        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "Input your username...")
            {
                UsernameTextbox.Text = "";
                UsernameTextbox.ForeColor = SystemColors.WindowText;

            }
        }

        private void UsernameTextbox_MouseLeave(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text.Trim() == "")
            {
                UsernameTextbox.Text = "Input your username...";
                UsernameTextbox.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
