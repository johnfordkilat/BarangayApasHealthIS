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
        List<String> listPets = new List<string>();
        List<String> listNumOfPets = new List<String>();
        int cnt = 0;
        String[] data = new string[10];


        private void button1_Click(object sender, EventArgs e)
        {

            


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
            //this.personalInformationTableAdapter.Fill(this.brgyApasHealthISDataSet.PersonalInformation);

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void houseNumberGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            /*
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            string sql = "UPDATE PersonalInformation SET FirstName = '" + firstNameTxt.Text + "', LastName = '" + lastNameTxt.Text + "' WHERE Id = '" + idTxt.Text + "' AND HouseNumber = '" + houseNumberTxt.Text + "'";
                        

            OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

            thisDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisDataAdapter);

            DataSet thisDataSet = new DataSet();

            thisDataAdapter.Fill(thisDataSet, "PersonalInformation");

            bindData();

            MessageBox.Show("Updated Succesfully");
            */
           

        }

        private void bindData()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            string sql = "SELECT * FROM PersonalInformation WHERE RESIDENTHOUSENUM LIKE '%" + Search_HouseNumtextBox.Text + "%'";

            OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

            DataSet thisDataSet = new DataSet();
            thisDataAdapter.Fill(thisDataSet, "PersonalInformation");
            SearchdataGridView.DataSource = thisDataSet.Tables["PersonalInformation"];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void petsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
            OleDbConnection thisConnection = new OleDbConnection(connectionString);


            string sql = "INSERT INTO PersonalInformation (Id,HouseNumber,FirstName,LastName,Pets) VALUES ('6','41','Sample','Sample','" + data[0] + "')";
            OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

            thisDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet thisDataSet = new DataSet();
            thisDataAdapter.Fill(thisDataSet, "PersonalInformation");

            if(cnt > 1)
            {
                for(int i = 1; i < cnt; i++)
                {
                    string sql1 = "UPDATE PersonalInformation SET Pets = '" + data[i] + "' WHERE Id = '6'";
                    OleDbDataAdapter thisDataAdapter1 = new OleDbDataAdapter(sql, thisConnection);

                    thisDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                    DataSet thisDataSet1 = new DataSet();
                    thisDataAdapter.Fill(thisDataSet, "PersonalInformation");
                }
                
            }

              
            
            MessageBox.Show("Data Saved");


        }

        private void SearchHouseNumbutton_Click(object sender, EventArgs e)
        {
            if (Search_HouseNumtextBox.Text == "")
            {
                MessageBox.Show("Please enter HOUSE NUMBER!");
            }
            else
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
                OleDbConnection thisConnection = new OleDbConnection(connectionString);

                string sql = "SELECT * FROM PersonalInformation WHERE RESIDENTHOUSENUM LIKE '%" + Search_HouseNumtextBox.Text + "%'";

                OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

                DataSet thisDataSet = new DataSet();
                thisDataAdapter.Fill(thisDataSet, "PersonalInformation");
                SearchdataGridView.DataSource = thisDataSet.Tables["PersonalInformation"];

                SitioComboBox.Enabled = false;
                HouseNumtextBox.Enabled = false;
                LabelcomboBox.Enabled = false;
                ResidentNumtextBox.Enabled = false;
                FnametextBox.Enabled = false;
                MnametextBox.Enabled = false;
                LnametextBox.Enabled = false;
                BirthdateTextbox.Enabled = false;
                BirthplacetextBox.Enabled = false;


            }
        }

        private void SearchdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SearchdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchdataGridView.CurrentRow.Selected = true;
            SitioComboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTSITIO"].Value.ToString();
            HouseNumtextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTHOUSENUM"].Value.ToString();
            LabelcomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTFAMLABEL"].Value.ToString();
            ResidentNumtextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTNUMBER"].Value.ToString();
            FnametextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTFIRSTNAME"].Value.ToString();
            MnametextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTMIDDLENAME"].Value.ToString();
            LnametextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTLASTNAME"].Value.ToString();
            BirthdateTextbox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTBIRTHDATE"].Value.ToString();
            BirthplacetextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTBIRTHPLACE"].Value.ToString();
            AgetextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTAGE"].Value.ToString();
            GendercomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTGENDER"].Value.ToString();
            PositionInFamcomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTPOSITION"].Value.ToString();
            CivilstatscomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTCIVILSTATS"].Value.ToString();
            EducationcomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTEDUCLEVEL"].Value.ToString();
            OccupationtextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTOCCUPATION"].Value.ToString();
            IncomecomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTINCOME"].Value.ToString();
            PhonenumtextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTCONTACTNUM"].Value.ToString();
            CategorycomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTCATEGORY"].Value.ToString();
            WeighttextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTWEIGHT"].Value.ToString();
            HeighttextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTHEIGHT"].Value.ToString();
            ServicescomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTAVAILEDSERV"].Value.ToString();
            ComorbiditiescomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTCOMORBIDITIES"].Value.ToString();
            AllergiescomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTALLERGIES"].Value.ToString();
            CovidHistorycomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTCOVIDHISTORY"].Value.ToString();
            InfectioncomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTINFECTION"].Value.ToString();
            VaxxStatuscomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTVAXXBRAND"].Value.ToString();
            BrandcomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTVAXXSTATUS"].Value.ToString();
            FirstDosetextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTFIRSTDATE"].Value.ToString();
            SecondDosetextBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTSECONDDATE"].Value.ToString();
            boosterComboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTBOOSTERBRAND"].Value.ToString();
            BoosterDatetextbox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTBOOSTERDATE"].Value.ToString();
            petsTextbox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTPETS"].Value.ToString();
            GardeningcomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTDISPOSAL"].Value.ToString();
            GarbagecomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTGARDENING"].Value.ToString();
            WaterSourcecomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTWATERSOURCE"].Value.ToString();
            ToiletscomboBox.Text = SearchdataGridView.Rows[e.RowIndex].Cells["RESIDENTTOILETTYPE"].Value.ToString();
        }

        private void Search_Savebutton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            string sql = "UPDATE PersonalInformation SET RESIDENTAGE = '" + Int32.Parse(AgetextBox.Text) + "', " +
                "RESIDENTGENDER = '" + GendercomboBox.Text + "'," +
                "RESIDENTPOSITION = '" + PositionInFamcomboBox.Text + "'," +
                "RESIDENTCIVILSTATS = '" + CivilstatscomboBox.Text + "'," +
                "RESIDENTEDUCLEVEL = '" + EducationcomboBox.Text + "'," +
                "RESIDENTOCCUPATION = '" + OccupationtextBox.Text + "'," +
                "RESIDENTINCOME = '" + IncomecomboBox.Text + "'," +
                "RESIDENTCONTACTNUM = '" + PhonenumtextBox.Text + "'," +
                "RESIDENTCATEGORY = '" + CategorycomboBox.Text + "'," +
                "RESIDENTWEIGHT = '" + Int32.Parse(WeighttextBox.Text) + "'," +
                "RESIDENTHEIGHT = '" + Int32.Parse(HeighttextBox.Text) + "'," +
                "RESIDENTAVAILEDSERV = '" + ServicescomboBox.Text + "'," +
                "RESIDENTCOMORBIDITIES = '" + ComorbiditiescomboBox.Text + "'," +
                "RESIDENTALLERGIES = '" + AllergiescomboBox.Text + "'," +
                "RESIDENTCOVIDHISTORY = '" + CovidHistorycomboBox.Text + "'," +
                "RESIDENTINFECTION = '" + InfectioncomboBox.Text + "'," +
                "RESIDENTVAXXBRAND = '" + VaxxStatuscomboBox.Text + "'," +
                "RESIDENTVAXXSTATUS = '" + BrandcomboBox.Text + "'," +
                "RESIDENTFIRSTDATE = '" + FirstDosetextBox.Text + "'," +
                "RESIDENTSECONDDATE = '" + SecondDosetextBox.Text + "'," +
                "RESIDENTBOOSTERBRAND = '" + boosterComboBox.Text + "'," +
                "RESIDENTBOOSTERDATE = '" + BoosterDatetextbox.Text + "'," +
                "RESIDENTPETS = '" + petsTextbox.Text + "'," +
                "RESIDENTDISPOSAL = '" + GardeningcomboBox.Text + "'," +
                "RESIDENTGARDENING = '" + GarbagecomboBox.Text + "'," +
                "RESIDENTWATERSOURCE = '" + WaterSourcecomboBox.Text + "'," +
                "RESIDENTTOILETTYPE = '" + ToiletscomboBox.Text + "'" +
                "WHERE RESIDENTNUMBER = '"+ ResidentNumtextBox.Text+ "'";

            OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisDataAdapter);

            DataSet thisDataSet = new DataSet();

            thisDataAdapter.Fill(thisDataSet, "PersonalInformation");

            bindData();

            MessageBox.Show("Updated Succesfully");
        }


        private void Clearbutton_Click(object sender, EventArgs e)
        {
            SitioComboBox.Text = "";
            HouseNumtextBox.Text = "";
            LabelcomboBox.Text = "";
            ResidentNumtextBox.Text = "";
            FnametextBox.Text = "";
            MnametextBox.Text = "";
            LnametextBox.Text = "";
            BirthdateTextbox.Text = "";
            BirthplacetextBox.Text = "";
            AgetextBox.Text = "";
            GendercomboBox.Text = "";
            PositionInFamcomboBox.Text = "";
            CivilstatscomboBox.Text = "";
            EducationcomboBox.Text = "";
            OccupationtextBox.Text = "";
            IncomecomboBox.Text = "";
            PhonenumtextBox.Text = "";
            CategorycomboBox.Text = "";
            WeighttextBox.Text = "";
            HeighttextBox.Text = "";
            ServicescomboBox.Text = "";
            ComorbiditiescomboBox.Text = "";
            AllergiescomboBox.Text = "";
            CovidHistorycomboBox.Text = "";
            InfectioncomboBox.Text = "";
            VaxxStatuscomboBox.Text = "";
            BrandcomboBox.Text = "";
            FirstDosetextBox.Text = "";
            SecondDosetextBox.Text = "";
            boosterComboBox.Text = "";
            BoosterDatetextbox.Text = "";
            petsTextbox.Text = "";
            GardeningcomboBox.Text = "";
            GarbagecomboBox.Text = "";
            WaterSourcecomboBox.Text = "";
            ToiletscomboBox.Text = "";
        }

        private void Search_HouseNumtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_HouseNumtextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
