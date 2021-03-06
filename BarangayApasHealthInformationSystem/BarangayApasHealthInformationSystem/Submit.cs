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
            validate();
        }
        string dbWord = null;
        string prefix =  Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 11);
        int id = 1;
        string residentNumber = null;
        

        private void Savebutton_Click(object sender, EventArgs e)
        {
            String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\joyce\source\repos\BarangayApasHealthIS\BrgyApasHealthIS.accdb";
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
                thisRow["RESIDENTVAXXBRAND"] = BrandcomboBox.Text;
                thisRow["RESIDENTVAXXSTATUS"] = VaxxStatuscomboBox.Text;
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
            this.Hide();
            Search sistema = new Search();
            sistema.ShowDialog();
            this.Close();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search sistema = new Search();
            sistema.ShowDialog();
            this.Close();
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

        private void VaxxStatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VaxxStatuscomboBox.Text == "Fully Vaccinated")
            {
                boosterComboBox.SelectedItem = "N/A";
                BoosterDatetextbox.Text = "N/A";
            }
            else if (VaxxStatuscomboBox.Text == "Fully Vaccinated with Booster Shot")
            {
                BrandcomboBox.SelectedIndex = -1;
                BrandcomboBox.Text = "Select Brand";
                FirstDosetextBox.Text = "1st dose";
                SecondDosetextBox.Text = "2nd dose";
                boosterComboBox.SelectedIndex = -1;
                boosterComboBox.Text = "Select Brand";
                BoosterDatetextbox.Text = "";
            }
            else if (VaxxStatuscomboBox.Text == "Partially Vaccinated")
            {
                BrandcomboBox.SelectedIndex = -1;
                BrandcomboBox.Text = "Select Brand";
                FirstDosetextBox.Text = "1st dose";
                SecondDosetextBox.Text = "N/A";
                boosterComboBox.SelectedItem = "N/A";
                BoosterDatetextbox.Text = "N/A";
            }
            else if (VaxxStatuscomboBox.Text == "Unvaccinated")
            {
                BrandcomboBox.SelectedItem = "N/A";
                FirstDosetextBox.Text = "N/A";
                SecondDosetextBox.Text = "N/A";
                boosterComboBox.SelectedItem = "N/A";
                BoosterDatetextbox.Text = "N/A";
            }
        }

        private void CovidHistorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CovidHistorycomboBox.Text == "No")
            {
                InfectioncomboBox.SelectedItem = "N/A";
            }
            else
            {
                InfectioncomboBox.SelectedIndex = -1;
                InfectioncomboBox.Text = "Select option";
            }
        }

        private void SitioComboBox_Enter(object sender, EventArgs e)
        {
            if (SitioComboBox.Text == "Select a Sitio")
            {
                SitioComboBox.Text = "";
                SitioComboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void SitioComboBox_Leave(object sender, EventArgs e)
        {
            if (SitioComboBox.Text == "")
            {
                SitioComboBox.Text = "Select a Sitio";
                SitioComboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void LabelcomboBox_Enter(object sender, EventArgs e)
        {
            if (LabelcomboBox.Text == "Select Label")
            {
                LabelcomboBox.Text = "";
                LabelcomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void LabelcomboBox_Leave(object sender, EventArgs e)
        {
            if (LabelcomboBox.Text == "")
            {
                LabelcomboBox.Text = "Select Label";
                LabelcomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void GendercomboBox_Enter(object sender, EventArgs e)
        {
            if (GendercomboBox.Text == "Select Gender")
            {
                GendercomboBox.Text = "";
                GendercomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void GendercomboBox_Leave(object sender, EventArgs e)
        {
            if (GendercomboBox.Text == "")
            {
                GendercomboBox.Text = "Select Gender";
                GendercomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void PositionInFamcomboBox_Enter(object sender, EventArgs e)
        {
            if (PositionInFamcomboBox.Text == "Select Position")
            {
                PositionInFamcomboBox.Text = "";
                PositionInFamcomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void PositionInFamcomboBox_Leave(object sender, EventArgs e)
        {
            if (PositionInFamcomboBox.Text == "")
            {
                PositionInFamcomboBox.Text = "Select Position";
                PositionInFamcomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void CivilstatscomboBox_Enter(object sender, EventArgs e)
        {
            if (CivilstatscomboBox.Text == "Select Status")
            {
                CivilstatscomboBox.Text = "";
                CivilstatscomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void CivilstatscomboBox_Leave(object sender, EventArgs e)
        {
            if (CivilstatscomboBox.Text == "")
            {
                CivilstatscomboBox.Text = "Select Status";
                CivilstatscomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void EducationcomboBox_Enter(object sender, EventArgs e)
        {
            if (EducationcomboBox.Text == "Select Educational Level")
            {
                EducationcomboBox.Text = "";
                EducationcomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void EducationcomboBox_Leave(object sender, EventArgs e)
        {
            if (EducationcomboBox.Text == "")
            {
                EducationcomboBox.Text = "Select Educational Level";
                EducationcomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void IncomecomboBox_Enter(object sender, EventArgs e)
        {
            if (IncomecomboBox.Text == "Select Income")
            {
                IncomecomboBox.Text = "";
                IncomecomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void IncomecomboBox_Leave(object sender, EventArgs e)
        {
            if (IncomecomboBox.Text == "")
            {
                IncomecomboBox.Text = "Select Income";
                IncomecomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void CategorycomboBox_Leave(object sender, EventArgs e)
        {
            if (CategorycomboBox.Text == "")
            {
                CategorycomboBox.Text = "Select Category";
                CategorycomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void CategorycomboBox_Enter(object sender, EventArgs e)
        {
            if (CategorycomboBox.Text == "Select Category")
            {
                CategorycomboBox.Text = "";
                CategorycomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ServicescomboBox_Enter(object sender, EventArgs e)
        {
            if (ServicescomboBox.Text == "Select Services")
            {
                ServicescomboBox.Text = "";
                ServicescomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ServicescomboBox_Leave(object sender, EventArgs e)
        {
            if (ServicescomboBox.Text == "")
            {
                ServicescomboBox.Text = "Select Services";
                ServicescomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void AllergiescomboBox_Enter(object sender, EventArgs e)
        {
            if (AllergiescomboBox.Text == "Select Allergies")
            {
                AllergiescomboBox.Text = "";
                AllergiescomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void AllergiescomboBox_Leave(object sender, EventArgs e)
        {
            if (AllergiescomboBox.Text == "")
            {
                AllergiescomboBox.Text = "Select Allergies";
                AllergiescomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void CovidHistorycomboBox_Enter(object sender, EventArgs e)
        {
            if (CovidHistorycomboBox.Text == "Select option")
            {
                CovidHistorycomboBox.Text = "";
                CovidHistorycomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void CovidHistorycomboBox_Leave(object sender, EventArgs e)
        {
            if (CovidHistorycomboBox.Text == "")
            {
                CovidHistorycomboBox.Text = "Select option";
                CovidHistorycomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void InfectioncomboBox_Enter(object sender, EventArgs e)
        {
            if (InfectioncomboBox.Text == "Select option")
            {
                InfectioncomboBox.Text = "";
                InfectioncomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void InfectioncomboBox_Leave(object sender, EventArgs e)
        {
            if (InfectioncomboBox.Text == "")
            {
                InfectioncomboBox.Text = "Select option";
                InfectioncomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void VaxxStatuscomboBox_Enter(object sender, EventArgs e)
        {
            if (VaxxStatuscomboBox.Text == "Select option")
            {
                VaxxStatuscomboBox.Text = "";
                VaxxStatuscomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void VaxxStatuscomboBox_Leave(object sender, EventArgs e)
        {
            if (VaxxStatuscomboBox.Text == "")
            {
                VaxxStatuscomboBox.Text = "Select option";
                VaxxStatuscomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void BrandcomboBox_Enter(object sender, EventArgs e)
        {
            if (BrandcomboBox.Text == "Select Brand")
            {
                BrandcomboBox.Text = "";
                BrandcomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void BrandcomboBox_Leave(object sender, EventArgs e)
        {
            if (BrandcomboBox.Text == "")
            {
                BrandcomboBox.Text = "Select Brand";
                BrandcomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void FirstDosetextBox_Enter(object sender, EventArgs e)
        {
            if (FirstDosetextBox.Text == "1st dose")
            {
                FirstDosetextBox.Text = "";
                FirstDosetextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void FirstDosetextBox_Leave(object sender, EventArgs e)
        {
            if (FirstDosetextBox.Text == "")
            {
                FirstDosetextBox.Text = "1st dose";
                FirstDosetextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void SecondDosetextBox_Enter(object sender, EventArgs e)
        {
            if (SecondDosetextBox.Text == "2nd dose")
            {
                SecondDosetextBox.Text = "";
                SecondDosetextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void SecondDosetextBox_Leave(object sender, EventArgs e)
        {
            if (SecondDosetextBox.Text == "")
            {
                SecondDosetextBox.Text = "2nd dose";
                SecondDosetextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void boosterComboBox_Enter(object sender, EventArgs e)
        {
            if (boosterComboBox.Text == "Select Brand")
            {
                boosterComboBox.Text = "";
                boosterComboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void boosterComboBox_Leave(object sender, EventArgs e)
        {
            if (boosterComboBox.Text == "")
            {
                boosterComboBox.Text = "Select Brand";
                boosterComboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void GardeningcomboBox_Enter(object sender, EventArgs e)
        {
            if (GardeningcomboBox.Text == "Select option")
            {
                GardeningcomboBox.Text = "";
                GardeningcomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void GardeningcomboBox_Leave(object sender, EventArgs e)
        {
            if (GardeningcomboBox.Text == "")
            {
                GardeningcomboBox.Text = "Select option";
                GardeningcomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void GarbagecomboBox_Enter(object sender, EventArgs e)
        {
            if (GarbagecomboBox.Text == "Select option")
            {
                GarbagecomboBox.Text = "";
                GarbagecomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void GarbagecomboBox_Leave(object sender, EventArgs e)
        {
            if (GarbagecomboBox.Text == "")
            {
                GarbagecomboBox.Text = "Select option";
                GarbagecomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void WaterSourcecomboBox_Enter(object sender, EventArgs e)
        {
            if (WaterSourcecomboBox.Text == "Select water source")
            {
                WaterSourcecomboBox.Text = "";
                WaterSourcecomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void WaterSourcecomboBox_Leave(object sender, EventArgs e)
        {
            if (WaterSourcecomboBox.Text == "")
            {
                WaterSourcecomboBox.Text = "Select water source";
                WaterSourcecomboBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void ToiletscomboBox_Enter(object sender, EventArgs e)
        {
            if (ToiletscomboBox.Text == "Select type of toilet")
            {
                ToiletscomboBox.Text = "";
                ToiletscomboBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ToiletscomboBox_Leave(object sender, EventArgs e)
        {
            if (ToiletscomboBox.Text == "")
            {
                ToiletscomboBox.Text = "Select type of toilet";
                ToiletscomboBox.ForeColor = SystemColors.GrayText;
            }
        }
        private void validate()
        {
            if (SitioComboBox.Text == "")
            {
                SitioComboBox.Text = "Select a Sitio";
                SitioComboBox.ForeColor = SystemColors.GrayText;
            }
            if (LabelcomboBox.Text == "")
            {
                LabelcomboBox.Text = "Select Label";
                LabelcomboBox.ForeColor = SystemColors.GrayText;
            }
            if (GendercomboBox.Text == "")
            {
                GendercomboBox.Text = "Select Gender";
                GendercomboBox.ForeColor = SystemColors.GrayText;
            }
            if (PositionInFamcomboBox.Text == "")
            {
                PositionInFamcomboBox.Text = "Select Position";
                PositionInFamcomboBox.ForeColor = SystemColors.GrayText;
            }
            if (CivilstatscomboBox.Text == "")
            {
                CivilstatscomboBox.Text = "Select Status";
                CivilstatscomboBox.ForeColor = SystemColors.GrayText;
            }
            if (IncomecomboBox.Text == "")
            {
                IncomecomboBox.Text = "Select Income";
                IncomecomboBox.ForeColor = SystemColors.GrayText;
            }
            if (CategorycomboBox.Text == "")
            {
                CategorycomboBox.Text = "Select Category";
                CategorycomboBox.ForeColor = SystemColors.GrayText;
            }
            if (ServicescomboBox.Text == "")
            {
                ServicescomboBox.Text = "Select Services";
                ServicescomboBox.ForeColor = SystemColors.GrayText;
            }
            if (AllergiescomboBox.Text == "")
            {
                AllergiescomboBox.Text = "Select Allergies";
                AllergiescomboBox.ForeColor = SystemColors.GrayText;
            }
            if (CovidHistorycomboBox.Text == "")
            {
                CovidHistorycomboBox.Text = "Select option";
                CovidHistorycomboBox.ForeColor = SystemColors.GrayText;
            }
            if (InfectioncomboBox.Text == "")
            {
                InfectioncomboBox.Text = "Select option";
                InfectioncomboBox.ForeColor = SystemColors.GrayText;
            }
            if (VaxxStatuscomboBox.Text == "")
            {
                VaxxStatuscomboBox.Text = "Select option";
                VaxxStatuscomboBox.ForeColor = SystemColors.GrayText;
            }
            if (BrandcomboBox.Text == "")
            {
                BrandcomboBox.Text = "Select Brand";
                BrandcomboBox.ForeColor = SystemColors.GrayText;
            }
            if (FirstDosetextBox.Text == "")
            {
                FirstDosetextBox.Text = "1st dose";
                FirstDosetextBox.ForeColor = SystemColors.GrayText;
            }
            if (SecondDosetextBox.Text == "")
            {
                SecondDosetextBox.Text = "2nd dose";
                SecondDosetextBox.ForeColor = SystemColors.GrayText;
            }
            if (boosterComboBox.Text == "")
            {
                boosterComboBox.Text = "Select Brand";
                boosterComboBox.ForeColor = SystemColors.GrayText;
            }
            if (GardeningcomboBox.Text == "")
            {
                GardeningcomboBox.Text = "Select option";
                GardeningcomboBox.ForeColor = SystemColors.GrayText;
            }
            if (GarbagecomboBox.Text == "")
            {
                GarbagecomboBox.Text = "Select option";
                GarbagecomboBox.ForeColor = SystemColors.GrayText;
            }
            if (WaterSourcecomboBox.Text == "")
            {
                WaterSourcecomboBox.Text = "Select water source";
                WaterSourcecomboBox.ForeColor = SystemColors.GrayText;
            }
            if (ToiletscomboBox.Text == "")
            {
                ToiletscomboBox.Text = "Select type of toilet";
                ToiletscomboBox.ForeColor = SystemColors.GrayText;
            }

        }
    }
}
