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
            this.textBoxVIN = new System.Windows.Forms.TextBox();
            this.labelCarVIN = new System.Windows.Forms.Label();
            this.labelCarColor = new System.Windows.Forms.Label();
            this.textBoxCarColor = new System.Windows.Forms.TextBox();
            this.labelCarModel = new System.Windows.Forms.Label();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            labelCarType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCarType
            // 
            labelCarType.AutoSize = true;
            labelCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCarType.Location = new System.Drawing.Point(81, 334);
            labelCarType.Name = "labelCarType";
            labelCarType.Size = new System.Drawing.Size(43, 20);
            labelCarType.TabIndex = 7;
            labelCarType.Text = "Type";
            labelCarType.Click += new System.EventHandler(this.labelCarType_Click);
            // 
            // textBoxVIN
            // 
            this.textBoxVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVIN.Location = new System.Drawing.Point(175, 156);
            this.textBoxVIN.Name = "textBoxVIN";
            this.textBoxVIN.Size = new System.Drawing.Size(160, 26);
            this.textBoxVIN.TabIndex = 0;
            // 
            // labelCarVIN
            // 
            this.labelCarVIN.AutoSize = true;
            this.labelCarVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarVIN.Location = new System.Drawing.Point(59, 159);
            this.labelCarVIN.Name = "labelCarVIN";
            this.labelCarVIN.Size = new System.Drawing.Size(92, 20);
            this.labelCarVIN.TabIndex = 1;
            this.labelCarVIN.Text = "Vehicle VIN";
            this.labelCarVIN.Click += new System.EventHandler(this.labelCarVIN_Click);
            // 
            // labelCarColor
            // 
            this.labelCarColor.AutoSize = true;
            this.labelCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarColor.Location = new System.Drawing.Point(81, 217);
            this.labelCarColor.Name = "labelCarColor";
            this.labelCarColor.Size = new System.Drawing.Size(55, 20);
            this.labelCarColor.TabIndex = 3;
            this.labelCarColor.Text = "Colour";
            // 
            // textBoxCarColor
            // 
            this.textBoxCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarColor.Location = new System.Drawing.Point(175, 217);
            this.textBoxCarColor.Name = "textBoxCarColor";
            this.textBoxCarColor.Size = new System.Drawing.Size(160, 26);
            this.textBoxCarColor.TabIndex = 2;
            // 
            // labelCarModel
            // 
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarModel.Location = new System.Drawing.Point(81, 273);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(52, 20);
            this.labelCarModel.TabIndex = 5;
            this.labelCarModel.Text = "Model";
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarModel.Location = new System.Drawing.Point(175, 273);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(160, 26);
            this.textBoxCarModel.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 352);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(231, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 33);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 33);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(63, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 33);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(231, 475);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 33);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 567);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(labelCarType);
            this.Controls.Add(this.labelCarModel);
            this.Controls.Add(this.textBoxCarModel);
            this.Controls.Add(this.labelCarColor);
            this.Controls.Add(this.textBoxCarColor);
            this.Controls.Add(this.labelCarVIN);
            this.Controls.Add(this.textBoxVIN);
            this.Name = "Cars";
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVIN;
        private System.Windows.Forms.Label labelCarVIN;
        private System.Windows.Forms.Label labelCarColor;
        private System.Windows.Forms.TextBox textBoxCarColor;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}