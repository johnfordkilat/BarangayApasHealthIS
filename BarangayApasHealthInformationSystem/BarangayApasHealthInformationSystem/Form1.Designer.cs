
namespace BarangayApasHealthInformationSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.houseNumberSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.brgyApasHealthISDataSet = new BarangayApasHealthInformationSystem.BrgyApasHealthISDataSet();
            this.personalInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalInformationTableAdapter = new BarangayApasHealthInformationSystem.BrgyApasHealthISDataSetTableAdapters.PersonalInformationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.houseNumberTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.houseNumberGridView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brgyApasHealthISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumberGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // houseNumberSearch
            // 
            this.houseNumberSearch.Location = new System.Drawing.Point(37, 54);
            this.houseNumberSearch.Name = "houseNumberSearch";
            this.houseNumberSearch.Size = new System.Drawing.Size(149, 20);
            this.houseNumberSearch.TabIndex = 0;
            this.houseNumberSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.houseNumberSearch_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(204, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // brgyApasHealthISDataSet
            // 
            this.brgyApasHealthISDataSet.DataSetName = "BrgyApasHealthISDataSet";
            this.brgyApasHealthISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalInformationBindingSource
            // 
            this.personalInformationBindingSource.DataMember = "PersonalInformation";
            this.personalInformationBindingSource.DataSource = this.brgyApasHealthISDataSet;
            // 
            // personalInformationTableAdapter
            // 
            this.personalInformationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "House Number";
            // 
            // houseNumberTxt
            // 
            this.houseNumberTxt.Location = new System.Drawing.Point(118, 140);
            this.houseNumberTxt.Name = "houseNumberTxt";
            this.houseNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.houseNumberTxt.TabIndex = 4;
            this.houseNumberTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(118, 166);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(118, 192);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // houseNumberGridView
            // 
            this.houseNumberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.houseNumberGridView.Location = new System.Drawing.Point(287, 106);
            this.houseNumberGridView.Name = "houseNumberGridView";
            this.houseNumberGridView.Size = new System.Drawing.Size(420, 179);
            this.houseNumberGridView.TabIndex = 9;
            this.houseNumberGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.houseNumberGridView_CellClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(37, 242);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(181, 43);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(118, 114);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 600);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.houseNumberGridView);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.houseNumberTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.houseNumberSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brgyApasHealthISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumberGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox houseNumberSearch;
        private System.Windows.Forms.Button SearchButton;
        private BrgyApasHealthISDataSet brgyApasHealthISDataSet;
        private System.Windows.Forms.BindingSource personalInformationBindingSource;
        private BrgyApasHealthISDataSetTableAdapters.PersonalInformationTableAdapter personalInformationTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox houseNumberTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView houseNumberGridView;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label4;
    }
}

