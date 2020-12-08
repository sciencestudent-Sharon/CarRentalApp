
namespace Car_Rental
{
    partial class Rental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rentalTable = new System.Windows.Forms.DataGridView();
            this.searchID_Tbox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ReeportText = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Rental_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickup_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickup_Branch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_Branch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(285, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rentalTable
            // 
            this.rentalTable.AllowUserToAddRows = false;
            this.rentalTable.AllowUserToDeleteRows = false;
            this.rentalTable.AllowUserToResizeColumns = false;
            this.rentalTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.rentalTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rentalTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rentalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rental_ID,
            this.pickup_date,
            this.return_date,
            this.price,
            this.Customer_ID,
            this.Employee_ID,
            this.pickup_Branch_ID,
            this.return_Branch_ID,
            this.VIN});
            this.rentalTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.rentalTable.Location = new System.Drawing.Point(25, 279);
            this.rentalTable.Margin = new System.Windows.Forms.Padding(2);
            this.rentalTable.Name = "rentalTable";
            this.rentalTable.ReadOnly = true;
            this.rentalTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            this.rentalTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.rentalTable.RowTemplate.Height = 24;
            this.rentalTable.Size = new System.Drawing.Size(863, 220);
            this.rentalTable.TabIndex = 33;
            // 
            // searchID_Tbox
            // 
            this.searchID_Tbox.Location = new System.Drawing.Point(644, 230);
            this.searchID_Tbox.Name = "searchID_Tbox";
            this.searchID_Tbox.Size = new System.Drawing.Size(100, 20);
            this.searchID_Tbox.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(773, 230);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ReeportText
            // 
            this.ReeportText.AutoSize = true;
            this.ReeportText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReeportText.Location = new System.Drawing.Point(502, 230);
            this.ReeportText.Name = "ReeportText";
            this.ReeportText.Size = new System.Drawing.Size(113, 20);
            this.ReeportText.TabIndex = 36;
            this.ReeportText.Text = "Transaction ID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(773, 514);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Rental_ID
            // 
            this.Rental_ID.HeaderText = "Rental_ID";
            this.Rental_ID.Name = "Rental_ID";
            this.Rental_ID.ReadOnly = true;
            this.Rental_ID.Width = 70;
            // 
            // pickup_date
            // 
            this.pickup_date.HeaderText = "pickup_date";
            this.pickup_date.Name = "pickup_date";
            this.pickup_date.ReadOnly = true;
            // 
            // return_date
            // 
            this.return_date.HeaderText = "return_date";
            this.return_date.Name = "return_date";
            this.return_date.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Customer_ID";
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Width = 80;
            // 
            // Employee_ID
            // 
            this.Employee_ID.HeaderText = "Employee_ID";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            this.Employee_ID.Width = 80;
            // 
            // pickup_Branch_ID
            // 
            this.pickup_Branch_ID.HeaderText = "pickup_Branch_ID";
            this.pickup_Branch_ID.Name = "pickup_Branch_ID";
            this.pickup_Branch_ID.ReadOnly = true;
            // 
            // return_Branch_ID
            // 
            this.return_Branch_ID.HeaderText = "return_Branch_ID";
            this.return_Branch_ID.Name = "return_Branch_ID";
            this.return_Branch_ID.ReadOnly = true;
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            this.VIN.Width = 50;
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 557);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ReeportText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchID_Tbox);
            this.Controls.Add(this.rentalTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Rental";
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView rentalTable;
        private System.Windows.Forms.TextBox searchID_Tbox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label ReeportText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rental_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickup_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickup_Branch_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_Branch_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
    }
}