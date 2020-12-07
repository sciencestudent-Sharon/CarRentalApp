namespace Car_Rental
{
    partial class Customer
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
            this.NewCust_Label = new System.Windows.Forms.Label();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.License_Label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.City_Label = new System.Windows.Forms.Label();
            this.Province_Label = new System.Windows.Forms.Label();
            this.PhoneNum_Label = new System.Windows.Forms.Label();
            this.Zip_Label = new System.Windows.Forms.Label();
            this.Membership_Label = new System.Windows.Forms.Label();
            this.FirstName_Tbox = new System.Windows.Forms.TextBox();
            this.LastName_Tbox = new System.Windows.Forms.TextBox();
            this.License_Tbox = new System.Windows.Forms.TextBox();
            this.PhNum_Tbox = new System.Windows.Forms.TextBox();
            this.Province_Tbox = new System.Windows.Forms.TextBox();
            this.City_Tbox = new System.Windows.Forms.TextBox();
            this.Zip_Tbox = new System.Windows.Forms.TextBox();
            this.StName_Tbox = new System.Windows.Forms.TextBox();
            this.StNum_Tbox = new System.Windows.Forms.TextBox();
            this.AptNum_Tbox = new System.Windows.Forms.TextBox();
            this.CustomerID_Label = new System.Windows.Forms.Label();
            this.CustID_Tbox = new System.Windows.Forms.TextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NewCust_Label
            // 
            this.NewCust_Label.AutoSize = true;
            this.NewCust_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCust_Label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewCust_Label.Location = new System.Drawing.Point(244, 27);
            this.NewCust_Label.Name = "NewCust_Label";
            this.NewCust_Label.Size = new System.Drawing.Size(347, 31);
            this.NewCust_Label.TabIndex = 1;
            this.NewCust_Label.Text = "New Customer Registration";
            this.NewCust_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewCust_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_Label.Location = new System.Drawing.Point(41, 132);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(86, 20);
            this.FirstName_Label.TabIndex = 2;
            this.FirstName_Label.Text = "First Name";
            this.FirstName_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_Label.Location = new System.Drawing.Point(451, 132);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(86, 20);
            this.LastName_Label.TabIndex = 3;
            this.LastName_Label.Text = "Last Name";
            this.LastName_Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // License_Label
            // 
            this.License_Label.AutoSize = true;
            this.License_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.License_Label.Location = new System.Drawing.Point(41, 187);
            this.License_Label.Name = "License_Label";
            this.License_Label.Size = new System.Drawing.Size(116, 20);
            this.License_Label.TabIndex = 4;
            this.License_Label.Text = "Driving License";
            this.License_Label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Label.Location = new System.Drawing.Point(41, 275);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(321, 20);
            this.Address_Label.TabIndex = 5;
            this.Address_Label.Text = "Address (St Name, St Number, Apt Number)";
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Label.Location = new System.Drawing.Point(576, 275);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(35, 20);
            this.City_Label.TabIndex = 6;
            this.City_Label.Text = "City";
            this.City_Label.Click += new System.EventHandler(this.label6_Click);
            // 
            // Province_Label
            // 
            this.Province_Label.AutoSize = true;
            this.Province_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Province_Label.Location = new System.Drawing.Point(702, 275);
            this.Province_Label.Name = "Province_Label";
            this.Province_Label.Size = new System.Drawing.Size(69, 20);
            this.Province_Label.TabIndex = 7;
            this.Province_Label.Text = "Province";
            // 
            // PhoneNum_Label
            // 
            this.PhoneNum_Label.AutoSize = true;
            this.PhoneNum_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNum_Label.Location = new System.Drawing.Point(451, 187);
            this.PhoneNum_Label.Name = "PhoneNum_Label";
            this.PhoneNum_Label.Size = new System.Drawing.Size(115, 20);
            this.PhoneNum_Label.TabIndex = 8;
            this.PhoneNum_Label.Text = "Phone Number";
            // 
            // Zip_Label
            // 
            this.Zip_Label.AutoSize = true;
            this.Zip_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip_Label.Location = new System.Drawing.Point(457, 275);
            this.Zip_Label.Name = "Zip_Label";
            this.Zip_Label.Size = new System.Drawing.Size(31, 20);
            this.Zip_Label.TabIndex = 9;
            this.Zip_Label.Text = "Zip";
            this.Zip_Label.Click += new System.EventHandler(this.label9_Click);
            // 
            // Membership_Label
            // 
            this.Membership_Label.AutoSize = true;
            this.Membership_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Membership_Label.Location = new System.Drawing.Point(41, 384);
            this.Membership_Label.Name = "Membership_Label";
            this.Membership_Label.Size = new System.Drawing.Size(96, 20);
            this.Membership_Label.TabIndex = 10;
            this.Membership_Label.Text = "Membership";
            // 
            // FirstName_Tbox
            // 
            this.FirstName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_Tbox.Location = new System.Drawing.Point(153, 132);
            this.FirstName_Tbox.Name = "FirstName_Tbox";
            this.FirstName_Tbox.Size = new System.Drawing.Size(285, 24);
            this.FirstName_Tbox.TabIndex = 11;
            // 
            // LastName_Tbox
            // 
            this.LastName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_Tbox.Location = new System.Drawing.Point(563, 132);
            this.LastName_Tbox.Name = "LastName_Tbox";
            this.LastName_Tbox.Size = new System.Drawing.Size(303, 24);
            this.LastName_Tbox.TabIndex = 12;
            // 
            // License_Tbox
            // 
            this.License_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.License_Tbox.Location = new System.Drawing.Point(192, 187);
            this.License_Tbox.Name = "License_Tbox";
            this.License_Tbox.Size = new System.Drawing.Size(246, 24);
            this.License_Tbox.TabIndex = 13;
            // 
            // PhNum_Tbox
            // 
            this.PhNum_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNum_Tbox.Location = new System.Drawing.Point(602, 190);
            this.PhNum_Tbox.Name = "PhNum_Tbox";
            this.PhNum_Tbox.Size = new System.Drawing.Size(264, 24);
            this.PhNum_Tbox.TabIndex = 14;
            // 
            // Province_Tbox
            // 
            this.Province_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Province_Tbox.Location = new System.Drawing.Point(707, 303);
            this.Province_Tbox.Name = "Province_Tbox";
            this.Province_Tbox.Size = new System.Drawing.Size(159, 24);
            this.Province_Tbox.TabIndex = 15;
            // 
            // City_Tbox
            // 
            this.City_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Tbox.Location = new System.Drawing.Point(581, 303);
            this.City_Tbox.Name = "City_Tbox";
            this.City_Tbox.Size = new System.Drawing.Size(125, 24);
            this.City_Tbox.TabIndex = 16;
            // 
            // Zip_Tbox
            // 
            this.Zip_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip_Tbox.Location = new System.Drawing.Point(460, 303);
            this.Zip_Tbox.Name = "Zip_Tbox";
            this.Zip_Tbox.Size = new System.Drawing.Size(97, 24);
            this.Zip_Tbox.TabIndex = 17;
            // 
            // StName_Tbox
            // 
            this.StName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StName_Tbox.Location = new System.Drawing.Point(46, 303);
            this.StName_Tbox.Name = "StName_Tbox";
            this.StName_Tbox.Size = new System.Drawing.Size(115, 24);
            this.StName_Tbox.TabIndex = 18;
            // 
            // StNum_Tbox
            // 
            this.StNum_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StNum_Tbox.Location = new System.Drawing.Point(167, 303);
            this.StNum_Tbox.Name = "StNum_Tbox";
            this.StNum_Tbox.Size = new System.Drawing.Size(115, 24);
            this.StNum_Tbox.TabIndex = 19;
            // 
            // AptNum_Tbox
            // 
            this.AptNum_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AptNum_Tbox.Location = new System.Drawing.Point(288, 303);
            this.AptNum_Tbox.Name = "AptNum_Tbox";
            this.AptNum_Tbox.Size = new System.Drawing.Size(115, 24);
            this.AptNum_Tbox.TabIndex = 20;
            // 
            // CustomerID_Label
            // 
            this.CustomerID_Label.AutoSize = true;
            this.CustomerID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID_Label.Location = new System.Drawing.Point(451, 384);
            this.CustomerID_Label.Name = "CustomerID_Label";
            this.CustomerID_Label.Size = new System.Drawing.Size(99, 20);
            this.CustomerID_Label.TabIndex = 22;
            this.CustomerID_Label.Text = "Customer ID";
            this.CustomerID_Label.Click += new System.EventHandler(this.label11_Click);
            // 
            // CustID_Tbox
            // 
            this.CustID_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustID_Tbox.Location = new System.Drawing.Point(456, 412);
            this.CustID_Tbox.Name = "CustID_Tbox";
            this.CustID_Tbox.Size = new System.Drawing.Size(246, 24);
            this.CustID_Tbox.TabIndex = 23;
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(318, 520);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(208, 33);
            this.Save_Button.TabIndex = 25;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 412);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 25);
            this.comboBox1.TabIndex = 26;
            // 
            // Customer
            // 
            this.ClientSize = new System.Drawing.Size(916, 642);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.CustID_Tbox);
            this.Controls.Add(this.CustomerID_Label);
            this.Controls.Add(this.AptNum_Tbox);
            this.Controls.Add(this.StNum_Tbox);
            this.Controls.Add(this.StName_Tbox);
            this.Controls.Add(this.Zip_Tbox);
            this.Controls.Add(this.City_Tbox);
            this.Controls.Add(this.Province_Tbox);
            this.Controls.Add(this.PhNum_Tbox);
            this.Controls.Add(this.License_Tbox);
            this.Controls.Add(this.LastName_Tbox);
            this.Controls.Add(this.FirstName_Tbox);
            this.Controls.Add(this.Membership_Label);
            this.Controls.Add(this.Zip_Label);
            this.Controls.Add(this.PhoneNum_Label);
            this.Controls.Add(this.Province_Label);
            this.Controls.Add(this.City_Label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.License_Label);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.NewCust_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewCust_Label;
        private System.Windows.Forms.Label FirstName_Label;
        private System.Windows.Forms.Label LastName_Label;
        private System.Windows.Forms.Label License_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.Label Province_Label;
        private System.Windows.Forms.Label PhoneNum_Label;
        private System.Windows.Forms.Label Zip_Label;
        private System.Windows.Forms.Label Membership_Label;
        private System.Windows.Forms.TextBox FirstName_Tbox;
        private System.Windows.Forms.TextBox LastName_Tbox;
        private System.Windows.Forms.TextBox License_Tbox;
        private System.Windows.Forms.TextBox PhNum_Tbox;
        private System.Windows.Forms.TextBox Province_Tbox;
        private System.Windows.Forms.TextBox City_Tbox;
        private System.Windows.Forms.TextBox Zip_Tbox;
        private System.Windows.Forms.TextBox StName_Tbox;
        private System.Windows.Forms.TextBox StNum_Tbox;
        private System.Windows.Forms.TextBox AptNum_Tbox;
        private System.Windows.Forms.Label CustomerID_Label;
        private System.Windows.Forms.TextBox CustID_Tbox;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
