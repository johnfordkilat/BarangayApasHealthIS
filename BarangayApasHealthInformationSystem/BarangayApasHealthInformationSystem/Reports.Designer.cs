﻿namespace BarangayApasHealthInformationSystem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Report_SitiotextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SearchSitiobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1200, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // Report_SitiotextBox
            // 
            this.Report_SitiotextBox.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_SitiotextBox.Location = new System.Drawing.Point(265, 238);
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
            this.label22.Location = new System.Drawing.Point(214, 241);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 69;
            this.label22.Text = "Sitio:";
            // 
            // SearchSitiobutton
            // 
            this.SearchSitiobutton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSitiobutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchSitiobutton.Location = new System.Drawing.Point(555, 230);
            this.SearchSitiobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchSitiobutton.Name = "SearchSitiobutton";
            this.SearchSitiobutton.Size = new System.Drawing.Size(83, 34);
            this.SearchSitiobutton.TabIndex = 68;
            this.SearchSitiobutton.Text = "Search";
            this.SearchSitiobutton.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 813);
            this.Controls.Add(this.Report_SitiotextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.SearchSitiobutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Report_SitiotextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button SearchSitiobutton;
    }
}