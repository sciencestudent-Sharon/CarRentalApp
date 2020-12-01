namespace Car_Rental
{
    partial class Cars
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
            System.Windows.Forms.Label labelCarType;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tBoxVIN = new System.Windows.Forms.TextBox();
            this.labelCarVIN = new System.Windows.Forms.Label();
            this.labelCarColor = new System.Windows.Forms.Label();
            this.tBoxColor = new System.Windows.Forms.TextBox();
            this.labelCarModel = new System.Windows.Forms.Label();
            this.tBoxModel = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.labelBranchID = new System.Windows.Forms.Label();
            this.tBoxBranchID = new System.Windows.Forms.TextBox();
            this.carsTable = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            labelCarType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCarType
            // 
            labelCarType.AutoSize = true;
            labelCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCarType.Location = new System.Drawing.Point(439, 129);
            labelCarType.Name = "labelCarType";
            labelCarType.Size = new System.Drawing.Size(43, 20);
            labelCarType.TabIndex = 7;
            labelCarType.Text = "Type";
            // 
            // tBoxVIN
            // 
            this.tBoxVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxVIN.Location = new System.Drawing.Point(223, 127);
            this.tBoxVIN.Name = "tBoxVIN";
            this.tBoxVIN.Size = new System.Drawing.Size(176, 23);
            this.tBoxVIN.TabIndex = 0;
            // 
            // labelCarVIN
            // 
            this.labelCarVIN.AutoSize = true;
            this.labelCarVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarVIN.Location = new System.Drawing.Point(136, 130);
            this.labelCarVIN.Name = "labelCarVIN";
            this.labelCarVIN.Size = new System.Drawing.Size(36, 20);
            this.labelCarVIN.TabIndex = 1;
            this.labelCarVIN.Text = "VIN";
            // 
            // labelCarColor
            // 
            this.labelCarColor.AutoSize = true;
            this.labelCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarColor.Location = new System.Drawing.Point(129, 188);
            this.labelCarColor.Name = "labelCarColor";
            this.labelCarColor.Size = new System.Drawing.Size(46, 20);
            this.labelCarColor.TabIndex = 3;
            this.labelCarColor.Text = "Color";
            // 
            // tBoxColor
            // 
            this.tBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxColor.Location = new System.Drawing.Point(223, 188);
            this.tBoxColor.Name = "tBoxColor";
            this.tBoxColor.Size = new System.Drawing.Size(176, 23);
            this.tBoxColor.TabIndex = 2;
            // 
            // labelCarModel
            // 
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarModel.Location = new System.Drawing.Point(129, 244);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(52, 20);
            this.labelCarModel.TabIndex = 5;
            this.labelCarModel.Text = "Model";
            // 
            // tBoxModel
            // 
            this.tBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxModel.Location = new System.Drawing.Point(223, 244);
            this.tBoxModel.Name = "tBoxModel";
            this.tBoxModel.Size = new System.Drawing.Size(176, 23);
            this.tBoxModel.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(224, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 27);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 27);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(387, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 27);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(549, 294);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 27);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Location = new System.Drawing.Point(533, 131);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(176, 21);
            this.cBoxType.TabIndex = 29;
            // 
            // labelBranchID
            // 
            this.labelBranchID.AutoSize = true;
            this.labelBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranchID.Location = new System.Drawing.Point(432, 247);
            this.labelBranchID.Name = "labelBranchID";
            this.labelBranchID.Size = new System.Drawing.Size(86, 20);
            this.labelBranchID.TabIndex = 31;
            this.labelBranchID.Text = "Branch_ID";
            // 
            // tBoxBranchID
            // 
            this.tBoxBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxBranchID.Location = new System.Drawing.Point(533, 247);
            this.tBoxBranchID.Name = "tBoxBranchID";
            this.tBoxBranchID.Size = new System.Drawing.Size(176, 23);
            this.tBoxBranchID.TabIndex = 30;
            // 
            // carsTable
            // 
            this.carsTable.AllowUserToAddRows = false;
            this.carsTable.AllowUserToDeleteRows = false;
            this.carsTable.AllowUserToResizeColumns = false;
            this.carsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.carsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.carsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIN,
            this.Color,
            this.Model,
            this.CarType,
            this.Branch_ID});
            this.carsTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.carsTable.Location = new System.Drawing.Point(58, 346);
            this.carsTable.Margin = new System.Windows.Forms.Padding(2);
            this.carsTable.Name = "carsTable";
            this.carsTable.ReadOnly = true;
            this.carsTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            this.carsTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.carsTable.RowTemplate.Height = 24;
            this.carsTable.Size = new System.Drawing.Size(792, 220);
            this.carsTable.TabIndex = 32;
            this.carsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsTable_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(718, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 27);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 642);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.carsTable);
            this.Controls.Add(this.labelBranchID);
            this.Controls.Add(this.tBoxBranchID);
            this.Controls.Add(this.cBoxType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(labelCarType);
            this.Controls.Add(this.labelCarModel);
            this.Controls.Add(this.tBoxModel);
            this.Controls.Add(this.labelCarColor);
            this.Controls.Add(this.tBoxColor);
            this.Controls.Add(this.labelCarVIN);
            this.Controls.Add(this.tBoxVIN);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxVIN;
        private System.Windows.Forms.Label labelCarVIN;
        private System.Windows.Forms.Label labelCarColor;
        private System.Windows.Forms.TextBox tBoxColor;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.TextBox tBoxModel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.Label labelBranchID;
        private System.Windows.Forms.TextBox tBoxBranchID;
        private System.Windows.Forms.DataGridView carsTable;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_ID;
    }
}