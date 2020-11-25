
namespace Car_Rental
{
    partial class Branch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.branchTable = new System.Windows.Forms.DataGridView();
            this.Branch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BranchID_Tbox = new System.Windows.Forms.TextBox();
            this.BranchID_Label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.streetName_Tbox = new System.Windows.Forms.TextBox();
            this.City_Label = new System.Windows.Forms.Label();
            this.City_Tbox = new System.Windows.Forms.TextBox();
            this.Province_Label = new System.Windows.Forms.Label();
            this.Province_Tbox = new System.Windows.Forms.TextBox();
            this.Zip_Label = new System.Windows.Forms.Label();
            this.Zip_Tbox = new System.Windows.Forms.TextBox();
            this.PhNum_Label = new System.Windows.Forms.Label();
            this.PhNum_Tbox = new System.Windows.Forms.TextBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.streetNum_Tbox = new System.Windows.Forms.TextBox();
            this.ClearSearch_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.branchTable)).BeginInit();
            this.SuspendLayout();
            // 
            // branchTable
            // 
            this.branchTable.AllowUserToAddRows = false;
            this.branchTable.AllowUserToDeleteRows = false;
            this.branchTable.AllowUserToResizeColumns = false;
            this.branchTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.branchTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.branchTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.branchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Branch_ID,
            this.street_number,
            this.street_name,
            this.city,
            this.province,
            this.zip,
            this.phone_number});
            this.branchTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.branchTable.Location = new System.Drawing.Point(52, 473);
            this.branchTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.branchTable.Name = "branchTable";
            this.branchTable.ReadOnly = true;
            this.branchTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            this.branchTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.branchTable.RowTemplate.Height = 24;
            this.branchTable.Size = new System.Drawing.Size(1124, 242);
            this.branchTable.TabIndex = 0;
            this.branchTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branchTable_CellContentClick);
            // 
            // Branch_ID
            // 
            this.Branch_ID.HeaderText = "Branch_ID";
            this.Branch_ID.MinimumWidth = 6;
            this.Branch_ID.Name = "Branch_ID";
            this.Branch_ID.ReadOnly = true;
            this.Branch_ID.Width = 80;
            // 
            // street_number
            // 
            this.street_number.HeaderText = "street_number";
            this.street_number.MinimumWidth = 6;
            this.street_number.Name = "street_number";
            this.street_number.ReadOnly = true;
            this.street_number.Width = 80;
            // 
            // street_name
            // 
            this.street_name.HeaderText = "street_name";
            this.street_name.MinimumWidth = 6;
            this.street_name.Name = "street_name";
            this.street_name.ReadOnly = true;
            this.street_name.Width = 190;
            // 
            // city
            // 
            this.city.HeaderText = "city";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 110;
            // 
            // province
            // 
            this.province.HeaderText = "province";
            this.province.MinimumWidth = 6;
            this.province.Name = "province";
            this.province.ReadOnly = true;
            this.province.Width = 130;
            // 
            // zip
            // 
            this.zip.HeaderText = "zip";
            this.zip.MinimumWidth = 6;
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            this.zip.Width = 80;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "phone_number";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            this.phone_number.Width = 125;
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(741, 271);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(139, 30);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Branch Summary";
            // 
            // BranchID_Tbox
            // 
            this.BranchID_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID_Tbox.Location = new System.Drawing.Point(263, 181);
            this.BranchID_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BranchID_Tbox.Name = "BranchID_Tbox";
            this.BranchID_Tbox.Size = new System.Drawing.Size(160, 27);
            this.BranchID_Tbox.TabIndex = 3;
            this.BranchID_Tbox.TextChanged += new System.EventHandler(this.BranchID_Tbox_TextChanged);
            // 
            // BranchID_Label
            // 
            this.BranchID_Label.AutoSize = true;
            this.BranchID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID_Label.Location = new System.Drawing.Point(104, 181);
            this.BranchID_Label.Name = "BranchID_Label";
            this.BranchID_Label.Size = new System.Drawing.Size(85, 20);
            this.BranchID_Label.TabIndex = 4;
            this.BranchID_Label.Text = "Branch ID";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Label.Location = new System.Drawing.Point(104, 233);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(71, 20);
            this.Address_Label.TabIndex = 6;
            this.Address_Label.Text = "Address";
            // 
            // streetName_Tbox
            // 
            this.streetName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetName_Tbox.Location = new System.Drawing.Point(384, 233);
            this.streetName_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.streetName_Tbox.Name = "streetName_Tbox";
            this.streetName_Tbox.Size = new System.Drawing.Size(241, 27);
            this.streetName_Tbox.TabIndex = 5;
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Label.Location = new System.Drawing.Point(104, 290);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(38, 20);
            this.City_Label.TabIndex = 8;
            this.City_Label.Text = "City";
            // 
            // City_Tbox
            // 
            this.City_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Tbox.Location = new System.Drawing.Point(263, 289);
            this.City_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.City_Tbox.Name = "City_Tbox";
            this.City_Tbox.Size = new System.Drawing.Size(199, 27);
            this.City_Tbox.TabIndex = 7;
            // 
            // Province_Label
            // 
            this.Province_Label.AutoSize = true;
            this.Province_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Province_Label.Location = new System.Drawing.Point(104, 340);
            this.Province_Label.Name = "Province_Label";
            this.Province_Label.Size = new System.Drawing.Size(74, 20);
            this.Province_Label.TabIndex = 10;
            this.Province_Label.Text = "Province";
            // 
            // Province_Tbox
            // 
            this.Province_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Province_Tbox.Location = new System.Drawing.Point(263, 338);
            this.Province_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Province_Tbox.Name = "Province_Tbox";
            this.Province_Tbox.Size = new System.Drawing.Size(199, 27);
            this.Province_Tbox.TabIndex = 9;
            // 
            // Zip_Label
            // 
            this.Zip_Label.AutoSize = true;
            this.Zip_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip_Label.Location = new System.Drawing.Point(487, 293);
            this.Zip_Label.Name = "Zip_Label";
            this.Zip_Label.Size = new System.Drawing.Size(31, 20);
            this.Zip_Label.TabIndex = 12;
            this.Zip_Label.Text = "Zip";
            // 
            // Zip_Tbox
            // 
            this.Zip_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip_Tbox.Location = new System.Drawing.Point(531, 290);
            this.Zip_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zip_Tbox.Name = "Zip_Tbox";
            this.Zip_Tbox.Size = new System.Drawing.Size(95, 27);
            this.Zip_Tbox.TabIndex = 11;
            // 
            // PhNum_Label
            // 
            this.PhNum_Label.AutoSize = true;
            this.PhNum_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNum_Label.Location = new System.Drawing.Point(104, 391);
            this.PhNum_Label.Name = "PhNum_Label";
            this.PhNum_Label.Size = new System.Drawing.Size(120, 20);
            this.PhNum_Label.TabIndex = 14;
            this.PhNum_Label.Text = "Phone Number";
            // 
            // PhNum_Tbox
            // 
            this.PhNum_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNum_Tbox.Location = new System.Drawing.Point(263, 391);
            this.PhNum_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhNum_Tbox.Name = "PhNum_Tbox";
            this.PhNum_Tbox.Size = new System.Drawing.Size(199, 27);
            this.PhNum_Tbox.TabIndex = 13;
            // 
            // Update_Button
            // 
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(925, 271);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(139, 30);
            this.Update_Button.TabIndex = 15;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(741, 329);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(139, 30);
            this.Delete_Button.TabIndex = 16;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.Location = new System.Drawing.Point(925, 329);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(139, 30);
            this.Search_Button.TabIndex = 17;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // streetNum_Tbox
            // 
            this.streetNum_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetNum_Tbox.Location = new System.Drawing.Point(263, 233);
            this.streetNum_Tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.streetNum_Tbox.Name = "streetNum_Tbox";
            this.streetNum_Tbox.Size = new System.Drawing.Size(115, 27);
            this.streetNum_Tbox.TabIndex = 18;
            // 
            // ClearSearch_Button
            // 
            this.ClearSearch_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSearch_Button.Location = new System.Drawing.Point(925, 388);
            this.ClearSearch_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearSearch_Button.Name = "ClearSearch_Button";
            this.ClearSearch_Button.Size = new System.Drawing.Size(139, 30);
            this.ClearSearch_Button.TabIndex = 19;
            this.ClearSearch_Button.Text = "Clear Search";
            this.ClearSearch_Button.UseVisualStyleBackColor = true;
            this.ClearSearch_Button.Click += new System.EventHandler(this.ClearSearch_Button_Click);
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 790);
            this.Controls.Add(this.ClearSearch_Button);
            this.Controls.Add(this.streetNum_Tbox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.PhNum_Label);
            this.Controls.Add(this.PhNum_Tbox);
            this.Controls.Add(this.Zip_Label);
            this.Controls.Add(this.Zip_Tbox);
            this.Controls.Add(this.Province_Label);
            this.Controls.Add(this.Province_Tbox);
            this.Controls.Add(this.City_Label);
            this.Controls.Add(this.City_Tbox);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.streetName_Tbox);
            this.Controls.Add(this.BranchID_Label);
            this.Controls.Add(this.BranchID_Tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.branchTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Branch";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.Branch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branchTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView branchTable;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BranchID_Tbox;
        private System.Windows.Forms.Label BranchID_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.TextBox streetName_Tbox;
        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.TextBox City_Tbox;
        private System.Windows.Forms.Label Province_Label;
        private System.Windows.Forms.TextBox Province_Tbox;
        private System.Windows.Forms.Label Zip_Label;
        private System.Windows.Forms.TextBox Zip_Tbox;
        private System.Windows.Forms.Label PhNum_Label;
        private System.Windows.Forms.TextBox PhNum_Tbox;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.TextBox streetNum_Tbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn street_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn street_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.Button ClearSearch_Button;
    }
}