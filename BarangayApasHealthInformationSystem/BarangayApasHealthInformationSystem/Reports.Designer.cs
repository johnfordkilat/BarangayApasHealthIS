namespace BarangayApasHealthInformationSystem
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Report_SitiotextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SearchSitiobutton = new System.Windows.Forms.Button();
            this.sitioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfBabies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofRenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femalegenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malegenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kidsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indigentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvaxxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaxxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sitioColumn,
            this.numberOfBabies,
            this.numberofRenter,
            this.totalColumn,
            this.femalegenderColumn,
            this.malegenderColumn,
            this.kidsColumn,
            this.adultsColumn,
            this.seniorColumn,
            this.pwdColumn,
            this.indigentColumn,
            this.unvaxxColumn,
            this.vaxxColumn,
            this.comorColumn,
            this.allergyColumn});
            this.dataGridView.Location = new System.Drawing.Point(67, 192);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1344, 599);
            this.dataGridView.TabIndex = 0;
            // 
            // Report_SitiotextBox
            // 
            this.Report_SitiotextBox.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_SitiotextBox.Location = new System.Drawing.Point(144, 149);
            this.Report_SitiotextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Report_SitiotextBox.Name = "Report_SitiotextBox";
            this.Report_SitiotextBox.Size = new System.Drawing.Size(284, 21);
            this.Report_SitiotextBox.TabIndex = 67;
            this.Report_SitiotextBox.Text = "Enter Sitio name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(93, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 69;
            this.label22.Text = "Sitio:";
            // 
            // SearchSitiobutton
            // 
            this.SearchSitiobutton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSitiobutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchSitiobutton.Location = new System.Drawing.Point(434, 141);
            this.SearchSitiobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchSitiobutton.Name = "SearchSitiobutton";
            this.SearchSitiobutton.Size = new System.Drawing.Size(83, 34);
            this.SearchSitiobutton.TabIndex = 68;
            this.SearchSitiobutton.Text = "Search";
            this.SearchSitiobutton.UseVisualStyleBackColor = true;
            this.SearchSitiobutton.Click += new System.EventHandler(this.SearchSitiobutton_Click);
            // 
            // sitioColumn
            // 
            this.sitioColumn.HeaderText = "Sitio";
            this.sitioColumn.Name = "sitioColumn";
            // 
            // numberOfBabies
            // 
            this.numberOfBabies.HeaderText = "Total Number of Babies";
            this.numberOfBabies.Name = "numberOfBabies";
            // 
            // numberofRenter
            // 
            this.numberofRenter.HeaderText = "Total Number of Renters";
            this.numberofRenter.Name = "numberofRenter";
            // 
            // totalColumn
            // 
            this.totalColumn.HeaderText = "Total Number of Residents";
            this.totalColumn.Name = "totalColumn";
            // 
            // femalegenderColumn
            // 
            this.femalegenderColumn.HeaderText = "Total number of Female";
            this.femalegenderColumn.Name = "femalegenderColumn";
            // 
            // malegenderColumn
            // 
            this.malegenderColumn.HeaderText = "Total Number of Male";
            this.malegenderColumn.Name = "malegenderColumn";
            // 
            // kidsColumn
            // 
            this.kidsColumn.HeaderText = "Total Number of Kids Ages below 18";
            this.kidsColumn.Name = "kidsColumn";
            // 
            // adultsColumn
            // 
            this.adultsColumn.HeaderText = "Total Number of Adults";
            this.adultsColumn.Name = "adultsColumn";
            // 
            // seniorColumn
            // 
            this.seniorColumn.HeaderText = "Total Number of Senior Citizen";
            this.seniorColumn.Name = "seniorColumn";
            // 
            // pwdColumn
            // 
            this.pwdColumn.HeaderText = "Total Number of PWD\'s";
            this.pwdColumn.Name = "pwdColumn";
            // 
            // indigentColumn
            // 
            this.indigentColumn.HeaderText = "Total Number of Indigent People";
            this.indigentColumn.Name = "indigentColumn";
            // 
            // unvaxxColumn
            // 
            this.unvaxxColumn.HeaderText = "Total Number of Unvaccinated People";
            this.unvaxxColumn.Name = "unvaxxColumn";
            // 
            // vaxxColumn
            // 
            this.vaxxColumn.HeaderText = "Total Number of Vaccinated People";
            this.vaxxColumn.Name = "vaxxColumn";
            // 
            // comorColumn
            // 
            this.comorColumn.HeaderText = "People with Comorbidities";
            this.comorColumn.Name = "comorColumn";
            // 
            // allergyColumn
            // 
            this.allergyColumn.HeaderText = "People with Allergies";
            this.allergyColumn.Name = "allergyColumn";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1460, 813);
            this.Controls.Add(this.Report_SitiotextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.SearchSitiobutton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox Report_SitiotextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button SearchSitiobutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBabies;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofRenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn femalegenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malegenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kidsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indigentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvaxxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaxxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergyColumn;
    }
}