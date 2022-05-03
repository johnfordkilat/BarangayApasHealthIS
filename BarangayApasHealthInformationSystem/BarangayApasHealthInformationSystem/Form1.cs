using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BarangayApasHealthInformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            if(houseNumberSearch.Text == "")
            {
                MessageBox.Show("Please enter HOUSE NUMBER!");
            }
            else
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
                OleDbConnection thisConnection = new OleDbConnection(connectionString);

                string sql = "SELECT * FROM PersonalInformation WHERE HouseNumber LIKE '%" + houseNumberSearch.Text + "%'";

                OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

                DataSet thisDataSet = new DataSet();
                thisDataAdapter.Fill(thisDataSet, "PersonalInformation");
                houseNumberGridView.DataSource = thisDataSet.Tables["PersonalInformation"];
                
               
               

            }


        }

        private void houseNumberSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brgyApasHealthISDataSet.PersonalInformation' table. You can move, or remove it, as needed.
            this.personalInformationTableAdapter.Fill(this.brgyApasHealthISDataSet.PersonalInformation);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void houseNumberGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            houseNumberGridView.CurrentRow.Selected = true;
            houseNumberTxt.Text = houseNumberGridView.Rows[e.RowIndex].Cells["HouseNumber"].Value.ToString();
            firstNameTxt.Text = houseNumberGridView.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            lastNameTxt.Text = houseNumberGridView.Rows[e.RowIndex].Cells["LastName"].Value.ToString();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();

            //string sql = "UPDATE PersonalInformation set FirstName = '" + firstNameTxt.Text + "'";
            //OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

            OleDbCommand command = new OleDbCommand("UPDATE PersonalInformation SET HouseNumber = '" + houseNumberTxt.Text + "',FirstName = '" + firstNameTxt.Text + "',LastName = '" + lastNameTxt.Text + "' ", thisConnection);
            command.ExecuteNonQuery();
            thisConnection.Close();
            MessageBox.Show("Updated Successfully");

            
   
            
        }
    }
}
