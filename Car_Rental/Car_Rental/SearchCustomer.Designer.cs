namespace Car_Rental
{
    partial class SearchCustomer
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
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.CustomerSummary_Label = new System.Windows.Forms.Label();
            this.firstName_Tbox = new System.Windows.Forms.TextBox();
            this.PhNum_Label = new System.Windows.Forms.Label();
            this.PhNum_Tbox = new System.Windows.Forms.TextBox();
            this.Province_Label = new System.Windows.Forms.Label();
            this.Province_Tbox = new System.Windows.Forms.TextBox();
            this.City_Label = new System.Windows.Forms.Label();
            this.City_Tbox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.lastName_Tbox = new System.Windows.Forms.TextBox();
            this.CustomerID_Label = new System.Windows.Forms.Label();
            this.CustID_Tbox = new System.Windows.Forms.TextBox();
            this.ClearSearch_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.AddUpdate_Button = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driving_License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apt_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // customersTable
            // 
            this.customersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customersTable.ColumnHeadersHeight = 29;
            this.customersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.first_name,
            this.last_name,
            this.Driving_License,
            this.membership,
            this.street_name,
            this.street_number,
            this.apt_number,
            this.city,
            this.province,
            this.zip,
            this.phone_number});
            this.customersTable.Location = new System.Drawing.Point(33, 482);
            this.customersTable.Margin = new System.Windows.Forms.Padding(4);
            this.customersTable.Name = "customersTable";
            this.customersTable.RowHeadersWidth = 51;
            this.customersTable.Size = new System.Drawing.Size(1152, 390);
            this.customersTable.TabIndex = 37;
            this.customersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersTable_CellContentClick);
            // 
            // CustomerSummary_Label
            // 
            this.CustomerSummary_Label.AutoSize = true;
            this.CustomerSummary_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSummary_Label.Location = new System.Drawing.Point(548, 447);
            this.CustomerSummary_Label.Name = "CustomerSummary_Label";
            this.CustomerSummary_Label.Size = new System.Drawing.Size(144, 25);
            this.CustomerSummary_Label.TabIndex = 47;
            this.CustomerSummary_Label.Text = "Search Results";
            // 
            // firstName_Tbox
            // 
            this.firstName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_Tbox.Location = new System.Drawing.Point(303, 220);
            this.firstName_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstName_Tbox.Name = "firstName_Tbox";
            this.firstName_Tbox.Size = new System.Drawing.Size(160, 27);
            this.firstName_Tbox.TabIndex = 3;
            // 
            // PhNum_Label
            // 
            this.PhNum_Label.AutoSize = true;
            this.PhNum_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNum_Label.Location = new System.Drawing.Point(144, 378);
            this.PhNum_Label.Name = "PhNum_Label";
            this.PhNum_Label.Size = new System.Drawing.Size(120, 20);
            this.PhNum_Label.TabIndex = 59;
            this.PhNum_Label.Text = "Phone Number";
            // 
            // PhNum_Tbox
            // 
            this.PhNum_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNum_Tbox.Location = new System.Drawing.Point(303, 378);
            this.PhNum_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhNum_Tbox.Name = "PhNum_Tbox";
            this.PhNum_Tbox.Size = new System.Drawing.Size(199, 27);
            this.PhNum_Tbox.TabIndex = 7;
            // 
            // Province_Label
            // 
            this.Province_Label.AutoSize = true;
            this.Province_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Province_Label.Location = new System.Drawing.Point(144, 327);
            this.Province_Label.Name = "Province_Label";
            this.Province_Label.Size = new System.Drawing.Size(74, 20);
            this.Province_Label.TabIndex = 55;
            this.Province_Label.Text = "Province";
            // 
            // Province_Tbox
            // 
            this.Province_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Province_Tbox.Location = new System.Drawing.Point(303, 325);
            this.Province_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Province_Tbox.Name = "Province_Tbox";
            this.Province_Tbox.Size = new System.Drawing.Size(199, 27);
            this.Province_Tbox.TabIndex = 6;
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Label.Location = new System.Drawing.Point(144, 276);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(38, 20);
            this.City_Label.TabIndex = 53;
            this.City_Label.Text = "City";
            // 
            // City_Tbox
            // 
            this.City_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Tbox.Location = new System.Drawing.Point(303, 276);
            this.City_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.City_Tbox.Name = "City_Tbox";
            this.City_Tbox.Size = new System.Drawing.Size(199, 27);
            this.City_Tbox.TabIndex = 5;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(144, 220);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(146, 20);
            this.Name_Label.TabIndex = 51;
            this.Name_Label.Text = "Name (First, Last)";
            // 
            // lastName_Tbox
            // 
            this.lastName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_Tbox.Location = new System.Drawing.Point(474, 220);
            this.lastName_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastName_Tbox.Name = "lastName_Tbox";
            this.lastName_Tbox.Size = new System.Drawing.Size(160, 27);
            this.lastName_Tbox.TabIndex = 4;
            // 
            // CustomerID_Label
            // 
            this.CustomerID_Label.AutoSize = true;
            this.CustomerID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID_Label.Location = new System.Drawing.Point(144, 168);
            this.CustomerID_Label.Name = "CustomerID_Label";
            this.CustomerID_Label.Size = new System.Drawing.Size(104, 20);
            this.CustomerID_Label.TabIndex = 49;
            this.CustomerID_Label.Text = "Customer ID";
            // 
            // CustID_Tbox
            // 
            this.CustID_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustID_Tbox.Location = new System.Drawing.Point(303, 168);
            this.CustID_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustID_Tbox.Name = "CustID_Tbox";
            this.CustID_Tbox.Size = new System.Drawing.Size(160, 27);
            this.CustID_Tbox.TabIndex = 2;
            // 
            // ClearSearch_Button
            // 
            this.ClearSearch_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSearch_Button.Location = new System.Drawing.Point(643, 348);
            this.ClearSearch_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearSearch_Button.Name = "ClearSearch_Button";
            this.ClearSearch_Button.Size = new System.Drawing.Size(139, 30);
            this.ClearSearch_Button.TabIndex = 10;
            this.ClearSearch_Button.Text = "Clear Search";
            this.ClearSearch_Button.UseVisualStyleBackColor = true;
            this.ClearSearch_Button.Click += new System.EventHandler(this.ClearSearch_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.Location = new System.Drawing.Point(643, 297);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(139, 30);
            this.Search_Button.TabIndex = 8;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(802, 297);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(139, 30);
            this.Delete_Button.TabIndex = 9;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // AddUpdate_Button
            // 
            this.AddUpdate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUpdate_Button.Location = new System.Drawing.Point(420, 109);
            this.AddUpdate_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUpdate_Button.Name = "AddUpdate_Button";
            this.AddUpdate_Button.Size = new System.Drawing.Size(405, 32);
            this.AddUpdate_Button.TabIndex = 1;
            this.AddUpdate_Button.Text = "Add New / Update Existing";
            this.AddUpdate_Button.UseVisualStyleBackColor = true;
            this.AddUpdate_Button.Click += new System.EventHandler(this.AddUpdate_Button_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 75;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First Name";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.Width = 80;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last Name";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.Width = 80;
            // 
            // Driving_License
            // 
            this.Driving_License.HeaderText = "License";
            this.Driving_License.MinimumWidth = 6;
            this.Driving_License.Name = "Driving_License";
            this.Driving_License.Width = 70;
            // 
            // membership
            // 
            this.membership.HeaderText = "Membership";
            this.membership.MinimumWidth = 6;
            this.membership.Name = "membership";
            this.membership.Width = 90;
            // 
            // street_name
            // 
            this.street_name.HeaderText = "St. Name";
            this.street_name.MinimumWidth = 6;
            this.street_name.Name = "street_name";
            this.street_name.Width = 80;
            // 
            // street_number
            // 
            this.street_number.HeaderText = "St. Number";
            this.street_number.MinimumWidth = 6;
            this.street_number.Name = "street_number";
            this.street_number.Width = 80;
            // 
            // apt_number
            // 
            this.apt_number.HeaderText = "Apt. Number";
            this.apt_number.MinimumWidth = 6;
            this.apt_number.Name = "apt_number";
            this.apt_number.Width = 80;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.Width = 50;
            // 
            // province
            // 
            this.province.HeaderText = "Province";
            this.province.MinimumWidth = 6;
            this.province.Name = "province";
            this.province.Width = 80;
            // 
            // zip
            // 
            this.zip.HeaderText = "Zip";
            this.zip.MinimumWidth = 6;
            this.zip.Name = "zip";
            this.zip.Width = 40;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Phone Number";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.Width = 130;
            // 
            // SearchCustomer
            // 
            this.AccessibleName = "SearchCustoer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 885);
            this.Controls.Add(this.AddUpdate_Button);
            this.Controls.Add(this.ClearSearch_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.firstName_Tbox);
            this.Controls.Add(this.PhNum_Label);
            this.Controls.Add(this.PhNum_Tbox);
            this.Controls.Add(this.Province_Label);
            this.Controls.Add(this.Province_Tbox);
            this.Controls.Add(this.City_Label);
            this.Controls.Add(this.City_Tbox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.lastName_Tbox);
            this.Controls.Add(this.CustomerID_Label);
            this.Controls.Add(this.CustID_Tbox);
            this.Controls.Add(this.CustomerSummary_Label);
            this.Controls.Add(this.customersTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView customersTable;
        private System.Windows.Forms.Label CustomerSummary_Label;
        private System.Windows.Forms.TextBox firstName_Tbox;
        private System.Windows.Forms.Label PhNum_Label;
        private System.Windows.Forms.TextBox PhNum_Tbox;
        private System.Windows.Forms.Label Province_Label;
        private System.Windows.Forms.TextBox Province_Tbox;
        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.TextBox City_Tbox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox lastName_Tbox;
        private System.Windows.Forms.Label CustomerID_Label;
        private System.Windows.Forms.TextBox CustID_Tbox;
        private System.Windows.Forms.Button ClearSearch_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button AddUpdate_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driving_License;
        private System.Windows.Forms.DataGridViewTextBoxColumn membership;
        private System.Windows.Forms.DataGridViewTextBoxColumn street_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn street_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn apt_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
    }
}