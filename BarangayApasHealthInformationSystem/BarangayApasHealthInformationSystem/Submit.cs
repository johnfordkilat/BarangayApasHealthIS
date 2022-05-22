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
    public partial class Submit : Form
    {
        public Submit()
        {
            InitializeComponent();
        }
        string dbWord = null;
        string prefix =  Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 11);
        int id = 1;
        string residentNumber = null;
        

        private void Savebutton_Click(object sender, EventArgs e)
        {
            String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jfkta\OneDrive\Documents\BarangayApasHealthInformationSystemDatabase\BrgyApasHealthIS.accdb";
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string sql = "SELECT * FROM PersonalInformation";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);

            thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "PersonalInformation");
            DataRow findRow = thisDataSet.Tables["PersonalInformation"].Rows.Find(ResidentNumtextBox.Text);



            if (SitioComboBox.Text == "" || HouseNumtextBox.Text == "" || LabelcomboBox.Text == "" || ResidentNumtextBox.Text == "" || FnametextBox.Text == ""
                || MnametextBox.Text == "" || LnametextBox.Text == "" || BirthdateTextbox.Text == ""
                || BirthplacetextBox.Text == "" || AgetextBox.Text == ""
                || GendercomboBox.Text == "" || PositionInFamcomboBox.Text == "" || CivilstatscomboBox.Text == ""
                || EducationcomboBox.Text == "" || OccupationtextBox.Text == "" || IncomecomboBox.Text == ""
                || PhonenumtextBox.Text == "" || CategorycomboBox.Text == "" || WeighttextBox.Text == ""
                || HeighttextBox.Text == "" || ServicescomboBox.Text == "" || ComorbiditiescomboBox.Text == ""
                || AllergiescomboBox.Text == "" || CovidHistorycomboBox.Text == "" || InfectioncomboBox.Text == ""
                || VaxxStatuscomboBox.Text == "" || GarbagecomboBox.Text == ""
                || GardeningcomboBox.Text == "" || WaterSourcecomboBox.Text == "" || ToiletscomboBox.Text == "")
            {
                MessageBox.Show("Please input empty fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            

            if (findRow == null)
            {
                DataRow thisRow = thisDataSet.Tables["PersonalInformation"].NewRow();

                

                thisRow["RESIDENTSITIO"] = SitioComboBox.Text;
                thisRow["RESIDENTHOUSENUM"] = HouseNumtextBox.Text;
                thisRow["RESIDENTFAMLABEL"] = LabelcomboBox.Text;
                thisRow["RESIDENTNUMBER"] = ResidentNumtextBox.Text;
                thisRow["RESIDENTFIRSTNAME"] = FnametextBox.Text;
                thisRow["RESIDENTMIDDLENAME"] = MnametextBox.Text;
                thisRow["RESIDENTLASTNAME"] = LnametextBox.Text;
                thisRow["RESIDENTBIRTHDATE"] = BirthdateTextbox.Text;
                thisRow["RESIDENTBIRTHPLACE"] = BirthplacetextBox.Text;
                thisRow["RESIDENTAGE"] = AgetextBox.Text;
                thisRow["RESIDENTGENDER"] = GendercomboBox.Text;
                thisRow["RESIDENTPOSITION"] = PositionInFamcomboBox.Text;
                thisRow["RESIDENTCIVILSTATS"] = CivilstatscomboBox.Text;
                thisRow["RESIDENTEDUCLEVEL"] = EducationcomboBox.Text;
                thisRow["RESIDENTOCCUPATION"] = OccupationtextBox.Text;
                thisRow["RESIDENTINCOME"] = IncomecomboBox.Text;
                thisRow["RESIDENTCONTACTNUM"] = PhonenumtextBox.Text;
                thisRow["RESIDENTCATEGORY"] = CategorycomboBox.Text;
                thisRow["RESIDENTWEIGHT"] = WeighttextBox.Text;
                thisRow["RESIDENTHEIGHT"] = HeighttextBox.Text;
                thisRow["RESIDENTAVAILEDSERV"] = ServicescomboBox.Text;
                thisRow["RESIDENTCOMORBIDITIES"] = ComorbiditiescomboBox.Text;
                thisRow["RESIDENTALLERGIES"] = AllergiescomboBox.Text;
                thisRow["RESIDENTCOVIDHISTORY"] = CovidHistorycomboBox.Text;
                thisRow["RESIDENTINFECTION"] = InfectioncomboBox.Text;
                thisRow["RESIDENTVAXXBRAND"] = VaxxStatuscomboBox.Text;
                thisRow["RESIDENTVAXXSTATUS"] = BrandcomboBox.Text;
                thisRow["RESIDENTFIRSTDATE"] = FirstDosetextBox.Text;
                thisRow["RESIDENTSECONDDATE"] = SecondDosetextBox.Text;
                thisRow["RESIDENTBOOSTERBRAND"] = boosterComboBox.Text;
                thisRow["RESIDENTBOOSTERDATE"] = BoosterDatetextbox.Text;
                thisRow["RESIDENTPETS"] = dbWord;
                thisRow["RESIDENTDISPOSAL"] = GarbagecomboBox.Text;
                thisRow["RESIDENTGARDENING"] = GardeningcomboBox.Text;
                thisRow["RESIDENTWATERSOURCE"] = WaterSourcecomboBox.Text;
                thisRow["RESIDENTTOILETTYPE"] = ToiletscomboBox.Text;

                thisDataSet.Tables["PersonalInformation"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "PersonalInformation");

                MessageBox.Show("Entries Recorded.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Duplicate Entries!", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            HouseNumtextBox.Clear();
            FnametextBox.Clear();
            MnametextBox.Clear();
            PhonenumtextBox.Clear();
            OccupationtextBox.Clear();
            WeighttextBox.Clear();
            HeighttextBox.Clear();
            LnametextBox.Clear();
            BirthplacetextBox.Clear();
            BirthdateTextbox.Clear();
            AgetextBox.Clear();
            petsTextbox.Clear();
            noOfPetTextbox.Clear();
            BoosterDatetextbox.Clear();
            SitioComboBox.SelectedIndex = -1;
            SitioComboBox.Text = "Select Sitio";
            PositionInFamcomboBox.SelectedIndex = -1;
            PositionInFamcomboBox.Text = "Select Position";
            CivilstatscomboBox.SelectedIndex = -1;
            CivilstatscomboBox.Text = "Select Status";
            EducationcomboBox.SelectedIndex = -1;
            EducationcomboBox.Text = "Select Educational Level";
            IncomecomboBox.SelectedIndex = -1;
            IncomecomboBox.Text = "Select Income";
            CategorycomboBox.SelectedIndex = -1;
            CategorycomboBox.Text = "Select Category";
            LabelcomboBox.SelectedIndex = -1;
            LabelcomboBox.Text = "Select Label";
            ServicescomboBox.SelectedIndex = -1;
            ServicescomboBox.Text = "Select Services";
            ComorbiditiescomboBox.Clear();
            ComorbiditiescomboBox.Text = "Select Comorbidities";
            AllergiescomboBox.SelectedIndex = -1;
            AllergiescomboBox.Text = "Select Allergies";
            CovidHistorycomboBox.SelectedIndex = -1;
            CovidHistorycomboBox.Text = "Select option";
            InfectioncomboBox.SelectedIndex = -1;
            InfectioncomboBox.Text = "Select option";
            VaxxStatuscomboBox.SelectedIndex = -1;
            VaxxStatuscomboBox.Text = "Select option";
            BrandcomboBox.SelectedIndex = -1;
            BrandcomboBox.Text = "Select Brand";
            boosterComboBox.SelectedIndex = -1;
            boosterComboBox.Text = "Select Brand";
            GendercomboBox.SelectedIndex = -1;
            GendercomboBox.Text = "Select Gender";
            GarbagecomboBox.SelectedIndex = -1;
            GarbagecomboBox.Text = "Select option";
            WaterSourcecomboBox.SelectedIndex = -1;
            WaterSourcecomboBox.Text = "Select water source";
            ToiletscomboBox.SelectedIndex = -1;
            ToiletscomboBox.Text = "Select type of toilet";
            GardeningcomboBox.SelectedIndex = -1;
            GardeningcomboBox.Text = "Select option";

        }

        private void SearchRecordbutton_Click(object sender, EventArgs e)
        {
            var newForm = new Search();
            newForm.Show();
        }



        private void WeighttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void PhonenumtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void HeighttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void HouseNumtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void j(object sender, EventArgs e)
        {

        }

        private void insertpetButton_Click(object sender, EventArgs e)
        {

        }

        private void add_Data(string pets, string numofpets)
        {
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView);
                newRow.Cells[0].Value = pets;
                newRow.Cells[1].Value = numofpets;
                dataGridView.Rows.Add(newRow);
            }
            catch { }
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            //String connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\joyce\OneDrive\Desktop\BarangayApasSystemFinal\Barangay Apas DB.mdb";
            //OleDbConnection thisConnection = new OleDbConnection(connectionString);
            //string sql = "SELECT * FROM BarangayApasDB";
            //OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, thisConnection);
            //OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);

            //thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //DataSet thisDataSet = new DataSet();
            //thisAdapter.Fill(thisDataSet, "BarangayApasDB");
            //DataColumn[] keys = new DataColumn[2];
            //keys[0] = thisDataSet.Tables[""].Columns[""];
            //keys[1] = thisDataSet.Tables[""].Columns[""];
            //thisDataSet.Tables[""].PrimaryKey = keys;

            //String[] valuesToSearch = new String[2];
            //valuesToSearch[0] = petsTextbox.Text;
            //valuesToSearch[]

            //DataRow findRow = thisDataSet.Tables["BarangayApasDB"].Rows.Find(ResidentNumtextBox.Text);
        }

        private void insertpetButton_Click_1(object sender, EventArgs e)
        {
            add_Data(petsTextbox.Text, noOfPetTextbox.Text);
            string word = petsTextbox.Text + "=" + noOfPetTextbox.Text+",";

            if(dbWord == null)
            {
                dbWord = word;
                Console.WriteLine(dbWord);

            }
            else
            {
                dbWord = dbWord + word;
                Console.WriteLine(dbWord);

            }



        }

        private void SearchRecordbutton_Click_1(object sender, EventArgs e)
        {
            var newForm = new Search();
            newForm.Show();
        }

        private void Submit_Load(object sender, EventArgs e)
        {
            ResidentNumtextBox.Text = prefix;
            ResidentNumtextBox.Enabled = false;
        }

        private void Clearbutton_Click_1(object sender, EventArgs e)
        {
            HouseNumtextBox.Clear();
            FnametextBox.Clear();
            MnametextBox.Clear();
            PhonenumtextBox.Clear();
            OccupationtextBox.Clear();
            WeighttextBox.Clear();
            HeighttextBox.Clear();
            LnametextBox.Clear();
            BirthplacetextBox.Clear();
            BirthdateTextbox.Clear();
            AgetextBox.Clear();
            petsTextbox.Clear();
            noOfPetTextbox.Clear();
            BoosterDatetextbox.Clear();
            SitioComboBox.SelectedIndex = -1;
            SitioComboBox.Text = "Select Sitio";
            PositionInFamcomboBox.SelectedIndex = -1;
            PositionInFamcomboBox.Text = "Select Position";
            CivilstatscomboBox.SelectedIndex = -1;
            CivilstatscomboBox.Text = "Select Status";
            EducationcomboBox.SelectedIndex = -1;
            EducationcomboBox.Text = "Select Educational Level";
            IncomecomboBox.SelectedIndex = -1;
            IncomecomboBox.Text = "Select Income";
            CategorycomboBox.SelectedIndex = -1;
            CategorycomboBox.Text = "Select Category";
            LabelcomboBox.SelectedIndex = -1;
            LabelcomboBox.Text = "Select Label";
            ServicescomboBox.SelectedIndex = -1;
            ServicescomboBox.Text = "Select Services";
            ComorbiditiescomboBox.Clear();
            ComorbiditiescomboBox.Text = "Select Comorbidities";
            AllergiescomboBox.SelectedIndex = -1;
            AllergiescomboBox.Text = "Select Allergies";
            CovidHistorycomboBox.SelectedIndex = -1;
            CovidHistorycomboBox.Text = "Select option";
            InfectioncomboBox.SelectedIndex = -1;
            InfectioncomboBox.Text = "Select option";
            VaxxStatuscomboBox.SelectedIndex = -1;
            VaxxStatuscomboBox.Text = "Select option";
            BrandcomboBox.SelectedIndex = -1;
            BrandcomboBox.Text = "Select Brand";
            boosterComboBox.SelectedIndex = -1;
            boosterComboBox.Text = "Select Brand";
            GendercomboBox.SelectedIndex = -1;
            GendercomboBox.Text = "Select Gender";
            GarbagecomboBox.SelectedIndex = -1;
            GarbagecomboBox.Text = "Select option";
            WaterSourcecomboBox.SelectedIndex = -1;
            WaterSourcecomboBox.Text = "Select water source";
            ToiletscomboBox.SelectedIndex = -1;
            ToiletscomboBox.Text = "Select type of toilet";
            GardeningcomboBox.SelectedIndex = -1;
            GardeningcomboBox.Text = "Select option";
        }

        private void checkedListBoxComorbidities_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s = string.Empty;

            for(int i = 0; i < checkedListBoxComorbidities.Items.Count; i++)
            {

                if (checkedListBoxComorbidities.GetItemChecked(i))
                {
                    s += checkedListBoxComorbidities.Items[i].ToString() + Environment.NewLine;
                }

            }
            ComorbiditiescomboBox.Text = s;
        }
    }
}
