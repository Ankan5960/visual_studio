namespace CADSIM
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
            this.ProjectDetails = new System.Windows.Forms.GroupBox();
            this.SiteDetails = new System.Windows.Forms.GroupBox();
            this.ProjectStatistics = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProjectName_label = new System.Windows.Forms.Label();
            this.ClientName_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.BuildingCategory_label = new System.Windows.Forms.Label();
            this.BulidingType_label = new System.Windows.Forms.Label();
            this.ProjectInformation_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SelectLocation = new System.Windows.Forms.CheckBox();
            this.CustomLocation = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.City_label = new System.Windows.Forms.Label();
            this.RepCity_label = new System.Windows.Forms.Label();
            this.State_label = new System.Windows.Forms.Label();
            this.Lat = new System.Windows.Forms.Label();
            this.Long = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Latitude_label = new System.Windows.Forms.Label();
            this.ProjectNorth = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Ok_button = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProjectDetails.SuspendLayout();
            this.SiteDetails.SuspendLayout();
            this.ProjectStatistics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectDetails
            // 
            this.ProjectDetails.Controls.Add(this.comboBox2);
            this.ProjectDetails.Controls.Add(this.comboBox1);
            this.ProjectDetails.Controls.Add(this.textBox3);
            this.ProjectDetails.Controls.Add(this.textBox2);
            this.ProjectDetails.Controls.Add(this.textBox1);
            this.ProjectDetails.Controls.Add(this.BulidingType_label);
            this.ProjectDetails.Controls.Add(this.BuildingCategory_label);
            this.ProjectDetails.Controls.Add(this.Address_label);
            this.ProjectDetails.Controls.Add(this.ClientName_label);
            this.ProjectDetails.Controls.Add(this.ProjectName_label);
            this.ProjectDetails.Location = new System.Drawing.Point(27, 38);
            this.ProjectDetails.Name = "ProjectDetails";
            this.ProjectDetails.Size = new System.Drawing.Size(525, 238);
            this.ProjectDetails.TabIndex = 1;
            this.ProjectDetails.TabStop = false;
            this.ProjectDetails.Text = "Project Details";
            this.ProjectDetails.Enter += new System.EventHandler(this.ProjectDetails_Enter);
            // 
            // SiteDetails
            // 
            this.SiteDetails.Controls.Add(this.textBox5);
            this.SiteDetails.Controls.Add(this.textBox4);
            this.SiteDetails.Controls.Add(this.Long);
            this.SiteDetails.Controls.Add(this.Lat);
            this.SiteDetails.Controls.Add(this.State_label);
            this.SiteDetails.Controls.Add(this.RepCity_label);
            this.SiteDetails.Controls.Add(this.City_label);
            this.SiteDetails.Controls.Add(this.comboBox5);
            this.SiteDetails.Controls.Add(this.comboBox4);
            this.SiteDetails.Controls.Add(this.comboBox3);
            this.SiteDetails.Controls.Add(this.CustomLocation);
            this.SiteDetails.Controls.Add(this.SelectLocation);
            this.SiteDetails.Location = new System.Drawing.Point(26, 288);
            this.SiteDetails.Name = "SiteDetails";
            this.SiteDetails.Size = new System.Drawing.Size(862, 132);
            this.SiteDetails.TabIndex = 2;
            this.SiteDetails.TabStop = false;
            this.SiteDetails.Text = "Site Details";
            // 
            // ProjectStatistics
            // 
            this.ProjectStatistics.Controls.Add(this.Latitude_label);
            this.ProjectStatistics.Location = new System.Drawing.Point(26, 426);
            this.ProjectStatistics.Name = "ProjectStatistics";
            this.ProjectStatistics.Size = new System.Drawing.Size(856, 61);
            this.ProjectStatistics.TabIndex = 3;
            this.ProjectStatistics.TabStop = false;
            this.ProjectStatistics.Text = "Project Statistics";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ProjectNorth);
            this.groupBox1.Location = new System.Drawing.Point(570, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "North_Direction";
            // 
            // ProjectName_label
            // 
            this.ProjectName_label.AutoSize = true;
            this.ProjectName_label.Location = new System.Drawing.Point(6, 30);
            this.ProjectName_label.Name = "ProjectName_label";
            this.ProjectName_label.Size = new System.Drawing.Size(89, 16);
            this.ProjectName_label.TabIndex = 0;
            this.ProjectName_label.Text = "Project Name";
            // 
            // ClientName_label
            // 
            this.ClientName_label.AutoSize = true;
            this.ClientName_label.Location = new System.Drawing.Point(6, 69);
            this.ClientName_label.Name = "ClientName_label";
            this.ClientName_label.Size = new System.Drawing.Size(80, 16);
            this.ClientName_label.TabIndex = 1;
            this.ClientName_label.Text = "Client Name";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(5, 115);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(58, 16);
            this.Address_label.TabIndex = 2;
            this.Address_label.Text = "Address";
            this.Address_label.Click += new System.EventHandler(this.Address_Click);
            // 
            // BuildingCategory_label
            // 
            this.BuildingCategory_label.AutoSize = true;
            this.BuildingCategory_label.Location = new System.Drawing.Point(5, 160);
            this.BuildingCategory_label.Name = "BuildingCategory_label";
            this.BuildingCategory_label.Size = new System.Drawing.Size(113, 16);
            this.BuildingCategory_label.TabIndex = 3;
            this.BuildingCategory_label.Text = "Building Category";
            this.BuildingCategory_label.Click += new System.EventHandler(this.BuildingCategory_Click);
            // 
            // BulidingType_label
            // 
            this.BulidingType_label.AutoSize = true;
            this.BulidingType_label.Location = new System.Drawing.Point(5, 196);
            this.BulidingType_label.Name = "BulidingType_label";
            this.BulidingType_label.Size = new System.Drawing.Size(90, 16);
            this.BulidingType_label.TabIndex = 4;
            this.BulidingType_label.Text = "Buliding Type";
            this.BulidingType_label.Click += new System.EventHandler(this.BulidingType_Click);
            // 
            // ProjectInformation_label
            // 
            this.ProjectInformation_label.AutoSize = true;
            this.ProjectInformation_label.Location = new System.Drawing.Point(12, 9);
            this.ProjectInformation_label.Name = "ProjectInformation_label";
            this.ProjectInformation_label.Size = new System.Drawing.Size(117, 16);
            this.ProjectInformation_label.TabIndex = 5;
            this.ProjectInformation_label.Text = "Project Information";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(262, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 22);
            this.textBox3.TabIndex = 7;
            // 
            // SelectLocation
            // 
            this.SelectLocation.AutoSize = true;
            this.SelectLocation.Location = new System.Drawing.Point(25, 37);
            this.SelectLocation.Name = "SelectLocation";
            this.SelectLocation.Size = new System.Drawing.Size(121, 20);
            this.SelectLocation.TabIndex = 0;
            this.SelectLocation.Text = "Select Location";
            this.SelectLocation.UseVisualStyleBackColor = true;
            // 
            // CustomLocation
            // 
            this.CustomLocation.AutoSize = true;
            this.CustomLocation.Location = new System.Drawing.Point(25, 78);
            this.CustomLocation.Name = "CustomLocation";
            this.CustomLocation.Size = new System.Drawing.Size(128, 20);
            this.CustomLocation.TabIndex = 1;
            this.CustomLocation.Text = "Custom Location";
            this.CustomLocation.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hospitality",
            "Educational",
            "Health Care",
            "Shopping Complex",
            "Business",
            "Assembly"});
            this.comboBox1.Location = new System.Drawing.Point(264, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Building used for Transport Services (24 Hrs)",
            "College (24 Hrs)",
            "College (Day)",
            "Hospital (24 Hrs)",
            "Institution (24 Hrs)",
            "Institution (Day)",
            "Large Office (24 Hrs)",
            "Large Office (Day)",
            "Medium Office (24 Hrs)",
            "Medium Office (Day)",
            "Multiplex (24 Hrs)",
            "No Star Hotel (24 Hrs)",
            "Open Gallery Malls (24 Hrs)",
            "Out-Patient Healthcare (Day)",
            "Resort (24 Hrs)",
            "School (24 Hrs)",
            "School (Day)",
            "Shopping Mall (24 Hrs)",
            "Small Office (24 Hrs)",
            "Small Office (Day)",
            "Stand-alone Retail (24 Hrs)",
            "Stand-alone Retail (Day)",
            "Star Hotel (24 Hrs)",
            "Super Markets (24 Hrs)",
            "Super Markets (Day)",
            "Theatre (24 Hrs)",
            "University (24 Hrs)",
            "University (Day)"});
            this.comboBox2.Location = new System.Drawing.Point(263, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(244, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(318, 33);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(208, 24);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(691, 33);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(165, 24);
            this.comboBox4.TabIndex = 10;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(691, 74);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(165, 24);
            this.comboBox5.TabIndex = 11;
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Location = new System.Drawing.Point(572, 36);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(29, 16);
            this.City_label.TabIndex = 10;
            this.City_label.Text = "City";
            // 
            // RepCity_label
            // 
            this.RepCity_label.AutoSize = true;
            this.RepCity_label.Location = new System.Drawing.Point(572, 77);
            this.RepCity_label.Name = "RepCity_label";
            this.RepCity_label.Size = new System.Drawing.Size(61, 16);
            this.RepCity_label.TabIndex = 12;
            this.RepCity_label.Text = "Rep. City";
            // 
            // State_label
            // 
            this.State_label.AutoSize = true;
            this.State_label.Location = new System.Drawing.Point(222, 37);
            this.State_label.Name = "State_label";
            this.State_label.Size = new System.Drawing.Size(38, 16);
            this.State_label.TabIndex = 13;
            this.State_label.Text = "State";
            // 
            // Lat
            // 
            this.Lat.AutoSize = true;
            this.Lat.Location = new System.Drawing.Point(222, 82);
            this.Lat.Name = "Lat";
            this.Lat.Size = new System.Drawing.Size(28, 16);
            this.Lat.TabIndex = 14;
            this.Lat.Text = "Lat.";
            // 
            // Long
            // 
            this.Long.AutoSize = true;
            this.Long.Location = new System.Drawing.Point(384, 82);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(40, 16);
            this.Long.TabIndex = 15;
            this.Long.Text = "Long.";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(293, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 22);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(454, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 22);
            this.textBox5.TabIndex = 17;
            // 
            // Latitude_label
            // 
            this.Latitude_label.AutoSize = true;
            this.Latitude_label.Location = new System.Drawing.Point(29, 30);
            this.Latitude_label.Name = "Latitude_label";
            this.Latitude_label.Size = new System.Drawing.Size(57, 16);
            this.Latitude_label.TabIndex = 18;
            this.Latitude_label.Text = "Latitude:";
            // 
            // ProjectNorth
            // 
            this.ProjectNorth.AutoSize = true;
            this.ProjectNorth.Location = new System.Drawing.Point(28, 222);
            this.ProjectNorth.Name = "ProjectNorth";
            this.ProjectNorth.Size = new System.Drawing.Size(119, 16);
            this.ProjectNorth.TabIndex = 1;
            this.ProjectNorth.Text = "Project North(deg.)";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(36, 493);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(72, 29);
            this.Insert.TabIndex = 6;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(452, 489);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(44, 33);
            this.Ok_button.TabIndex = 7;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = true;
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(810, 493);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(72, 29);
            this.Cancle.TabIndex = 8;
            this.Cancle.Text = "Cancle";
            this.Cancle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\ankan\\Downloads\\img1.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(31, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 180);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 523);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.ProjectInformation_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProjectStatistics);
            this.Controls.Add(this.SiteDetails);
            this.Controls.Add(this.ProjectDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ProjectDetails.ResumeLayout(false);
            this.ProjectDetails.PerformLayout();
            this.SiteDetails.ResumeLayout(false);
            this.SiteDetails.PerformLayout();
            this.ProjectStatistics.ResumeLayout(false);
            this.ProjectStatistics.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProjectDetails;
        private System.Windows.Forms.GroupBox SiteDetails;
        private System.Windows.Forms.GroupBox ProjectStatistics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BulidingType_label;
        private System.Windows.Forms.Label BuildingCategory_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label ClientName_label;
        private System.Windows.Forms.Label ProjectName_label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ProjectInformation_label;
        private System.Windows.Forms.CheckBox CustomLocation;
        private System.Windows.Forms.CheckBox SelectLocation;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Long;
        private System.Windows.Forms.Label Lat;
        private System.Windows.Forms.Label State_label;
        private System.Windows.Forms.Label RepCity_label;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Latitude_label;
        private System.Windows.Forms.Label ProjectNorth;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

