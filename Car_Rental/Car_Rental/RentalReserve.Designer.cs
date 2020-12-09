
namespace Car_Rental
{
    partial class RentalReserve
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carType_cBox = new System.Windows.Forms.ComboBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.customerID_Tbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.employeeID_Tbox = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.carsTable = new System.Windows.Forms.DataGridView();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Text = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.pickupID_Tbox = new System.Windows.Forms.TextBox();
            this.returnID_Tbox = new System.Windows.Forms.TextBox();
            this.VIN_Tbox = new System.Windows.Forms.TextBox();
            this.VINLabel = new System.Windows.Forms.Label();
            this.TID_Tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Car Rental Form";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pick up Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Drop off Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Car Type:";
            // 
            // carType_cBox
            // 
            this.carType_cBox.FormattingEnabled = true;
            this.carType_cBox.Location = new System.Drawing.Point(654, 162);
            this.carType_cBox.Name = "carType_cBox";
            this.carType_cBox.Size = new System.Drawing.Size(200, 21);
            this.carType_cBox.TabIndex = 15;
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(685, 286);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(134, 40);
            this.btnReserve.TabIndex = 16;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Customer ID:";
            // 
            // customerID_Tbox
            // 
            this.customerID_Tbox.Location = new System.Drawing.Point(170, 121);
            this.customerID_Tbox.Name = "customerID_Tbox";
            this.customerID_Tbox.Size = new System.Drawing.Size(200, 20);
            this.customerID_Tbox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Drop off Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(170, 230);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Reserved by:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(351, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Employee ID";
            // 
            // employeeID_Tbox
            // 
            this.employeeID_Tbox.Location = new System.Drawing.Point(170, 286);
            this.employeeID_Tbox.Name = "employeeID_Tbox";
            this.employeeID_Tbox.Size = new System.Drawing.Size(175, 20);
            this.employeeID_Tbox.TabIndex = 22;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Pick up Location:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(685, 200);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(134, 23);
            this.btnCheck.TabIndex = 28;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 28);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // carsTable
            // 
            this.carsTable.AllowUserToAddRows = false;
            this.carsTable.AllowUserToDeleteRows = false;
            this.carsTable.AllowUserToResizeColumns = false;
            this.carsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.carsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.carsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIN,
            this.Color,
            this.Model,
            this.CarType,
            this.Branch_ID});
            this.carsTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.carsTable.Location = new System.Drawing.Point(62, 343);
            this.carsTable.Margin = new System.Windows.Forms.Padding(2);
            this.carsTable.Name = "carsTable";
            this.carsTable.ReadOnly = true;
            this.carsTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            this.carsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.carsTable.RowTemplate.Height = 24;
            this.carsTable.Size = new System.Drawing.Size(792, 220);
            this.carsTable.TabIndex = 33;
            this.carsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsTable_CellContentClick);
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 120;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 230;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "CarType";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            this.CarType.Width = 170;
            // 
            // Branch_ID
            // 
            this.Branch_ID.HeaderText = "Branch_ID";
            this.Branch_ID.Name = "Branch_ID";
            this.Branch_ID.ReadOnly = true;
            this.Branch_ID.Width = 90;
            // 
            // name_Text
            // 
            this.name_Text.AutoSize = true;
            this.name_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Text.Location = new System.Drawing.Point(175, 155);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(124, 20);
            this.name_Text.TabIndex = 34;
            this.name_Text.Text = "Customer Name";
            this.name_Text.Visible = false;
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailable.Location = new System.Drawing.Point(62, 325);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(110, 16);
            this.labelAvailable.TabIndex = 29;
            this.labelAvailable.Text = "Available Cars";
            // 
            // pickupID_Tbox
            // 
            this.pickupID_Tbox.Location = new System.Drawing.Point(654, 88);
            this.pickupID_Tbox.Name = "pickupID_Tbox";
            this.pickupID_Tbox.Size = new System.Drawing.Size(175, 20);
            this.pickupID_Tbox.TabIndex = 35;
            // 
            // returnID_Tbox
            // 
            this.returnID_Tbox.Location = new System.Drawing.Point(654, 123);
            this.returnID_Tbox.Name = "returnID_Tbox";
            this.returnID_Tbox.Size = new System.Drawing.Size(175, 20);
            this.returnID_Tbox.TabIndex = 36;
            // 
            // VIN_Tbox
            // 
            this.VIN_Tbox.Location = new System.Drawing.Point(654, 242);
            this.VIN_Tbox.Name = "VIN_Tbox";
            this.VIN_Tbox.Size = new System.Drawing.Size(175, 20);
            this.VIN_Tbox.TabIndex = 38;
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VINLabel.Location = new System.Drawing.Point(599, 240);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(36, 20);
            this.VINLabel.TabIndex = 37;
            this.VINLabel.Text = "VIN";
            // 
            // TID_Tbox
            // 
            this.TID_Tbox.Location = new System.Drawing.Point(170, 84);
            this.TID_Tbox.Name = "TID_Tbox";
            this.TID_Tbox.Size = new System.Drawing.Size(175, 20);
            this.TID_Tbox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Transaction ID";
            // 
            // RentalReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 574);
            this.Controls.Add(this.TID_Tbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VIN_Tbox);
            this.Controls.Add(this.VINLabel);
            this.Controls.Add(this.returnID_Tbox);
            this.Controls.Add(this.pickupID_Tbox);
            this.Controls.Add(this.name_Text);
            this.Controls.Add(this.carsTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.employeeID_Tbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.customerID_Tbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.carType_cBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "RentalReserve";
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.RentalReserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox carType_cBox;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox customerID_Tbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox employeeID_Tbox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView carsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_ID;
        private System.Windows.Forms.Label name_Text;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.TextBox returnID_Tbox;
        private System.Windows.Forms.TextBox pickupID_Tbox;
        private System.Windows.Forms.TextBox VIN_Tbox;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.TextBox TID_Tbox;
        private System.Windows.Forms.Label label3;
    }
}