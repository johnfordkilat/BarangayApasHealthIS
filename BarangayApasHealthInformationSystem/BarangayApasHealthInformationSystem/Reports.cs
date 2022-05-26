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

        int count1 = 0;
        int count = 0;
        int x = 0;

        public Reports()
        {
            InitializeComponent();
        }

        private void SearchSitiobutton_Click(object sender, EventArgs e)
        {
            //if (Report_SitiotextBox.Text == "")
            //{
            //    MessageBox.Show("Please enter a SITIO to generate report!");
            //}
            //else
            //{
            //    String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\joyce\source\repos\BarangayApasHealthIS\BrgyApasHealthIS.accdb";
            //    OleDbConnection thisConnection = new OleDbConnection(connectionString);
            //    thisConnection.Open();
            //    OleDbCommand thisCommand = thisConnection.CreateCommand();
            //    thisCommand.CommandText = "SELECT * FROM PersonalInformation WHERE RESIDENTSITIO LIKE '%" + Report_SitiotextBox.Text + "%'";
            //    OleDbDataReader thisReader = thisCommand.ExecuteReader();

            //    bool found = false;

            //    {
            //        if (thisReader["RESIDENTSITIO"].ToString() == Report_SitiotextBox.Text)
            //        {
            //            found = true;
            //            string sql = "SELECT DIAGCODE, DIAGNAME FROM DIAGNOSISFILE WHERE DIAGCODE LIKE '" + DiagnosisCodeTextBox.Text + "%'";
            //            OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

            //            DataSet thisDataSet = new DataSet();
            //            thisDataAdapter.Fill(thisDataSet, "DIAGNOSISFILE");

            //            count1 = x + 1;
            //            for (int i = 0; i < count1; i++)
            //            {
            //                if (object.Equals(dataGridView.Rows[i].Cells["DIAGCODE"].Value, DiagnosisCodeTextBox.Text))
            //                {
            //                    MessageBox.Show("DIAGNOSIS CODE ALREADY EXIST IN DATA GRID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //                    break;
            //                }
            //                else
            //                {
            //                    if (i == count1 - 1)
            //                    {
            //                        x = DiagnosisDataGridView.Rows.Add();
            //                        DiagnosisDataGridView.Rows[x].Cells["DIAGCODE"].Value = thisDataSet.Tables["DIAGNOSISFILE"].Rows[0]["DIAGCODE"];
            //                        DiagnosisDataGridView.Rows[x].Cells["DIAGNAME"].Value = thisDataSet.Tables["DIAGNOSISFILE"].Rows[0]["DIAGNAME"];

            //                        PhysicianNoteDirectionTextBox.Focus();
            //                        break;
            //                    }
            //                }
            //            }
            //            count1++;
            //        }
            //    }


            //}
        }
    }
}
