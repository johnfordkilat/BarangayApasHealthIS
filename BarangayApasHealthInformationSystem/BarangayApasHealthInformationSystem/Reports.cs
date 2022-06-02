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
    public partial class Reports : Form
    {

        int numResidents;
        int numFemale;
        int numMale;
        int numKids;
        int numAdults;
        int numSenior;
        int numPWD;
        int numIndigent;
        int numUnvax;
        int numVax;
        int numComorb;
        int numAllergies;

        public Reports()
        {
            InitializeComponent();
        }

        private void SearchSitiobutton_Click(object sender, EventArgs e)
        {
            if (Report_SitiotextBox.Text == "")
            {
                MessageBox.Show("Please enter a SITIO to generate report!");
            }
            else
            {
                String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
                OleDbConnection thisConnection = new OleDbConnection(connectionString);

                thisConnection.Open();

                OleDbCommand thisCommand = thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM PersonalInformation WHERE RESIDENTSITIO LIKE '%" + Report_SitiotextBox.Text + "%'";
                OleDbDataReader thisReader = thisCommand.ExecuteReader();

                while (thisReader.Read())
                {
                    numResidents++;
                    if(thisReader["RESIDENTGENDER"].Equals("Female"))
                    {
                        numFemale++;
                    }
                    if (thisReader["RESIDENTGENDER"].Equals("Male"))
                    {
                        numMale++;
                    }
                    if (int.Parse(thisReader["RESIDENTAGE"].ToString()) < 18)
                    {
                        numKids++;
                    }
                    if (thisReader["RESIDENTCATEGORY"].Equals("Adult"))
                    {
                        numAdults++;
                    }
                    if (thisReader["RESIDENTCATEGORY"].Equals("Senior Citizen"))
                    {
                        numSenior++;
                    }
                    if (thisReader["RESIDENTCATEGORY"].Equals("PWD"))
                    {
                        numPWD++;
                    }
                    if (thisReader["RESIDENTCATEGORY"].Equals("Indigent"))
                    {
                        numIndigent++;
                    }
                    if (thisReader["RESIDENTVAXXSTATUS"].Equals("Unvaccinated"))
                    {
                        numUnvax++;
                    }
                    if (thisReader["RESIDENTVAXXSTATUS"].Equals("Fully Vaccinated") || thisReader["RESIDENTVAXXSTATUS"].Equals("Partially Vaccinated") || thisReader["RESIDENTVAXXSTATUS"].Equals("Fully Vaccinated with Booster"))
                    {
                        numVax++;
                    }
                    if (!thisReader["RESIDENTCOMORBIDITIES"].Equals("None"))
                    {
                        numComorb++;
                    }
                    if (!thisReader["RESIDENTALLERGIES"].Equals("None"))
                    {
                        numAllergies++;
                    }

                }

                thisReader.Close();
                thisConnection.Close();

                int i = 0;
                i = dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells["sitioColumn"].Value = Report_SitiotextBox.Text;
                dataGridView.Rows[i].Cells["totalColumn"].Value = numResidents;
                dataGridView.Rows[i].Cells["femalegenderColumn"].Value = numFemale;
                dataGridView.Rows[i].Cells["malegenderColumn"].Value = numMale;
                dataGridView.Rows[i].Cells["kidsColumn"].Value = numKids;
                dataGridView.Rows[i].Cells["adultsColumn"].Value = numAdults;
                dataGridView.Rows[i].Cells["seniorColumn"].Value = numSenior;
                dataGridView.Rows[i].Cells["pwdColumn"].Value = numPWD;
                dataGridView.Rows[i].Cells["indigentColumn"].Value = numIndigent;
                dataGridView.Rows[i].Cells["unvaxxColumn"].Value = numUnvax;
                dataGridView.Rows[i].Cells["vaxxColumn"].Value = numVax;
                dataGridView.Rows[i].Cells["comorColumn"].Value = numComorb;
                dataGridView.Rows[i].Cells["allergyColumn"].Value = numAllergies;




            }
        }
    }
}
