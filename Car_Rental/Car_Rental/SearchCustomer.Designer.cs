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
            System.Windows.Forms.Label labelCarType;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCarModel = new System.Windows.Forms.Label();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.labelCarColor = new System.Windows.Forms.Label();
            this.textBoxCarColor = new System.Windows.Forms.TextBox();
            this.labelCarVIN = new System.Windows.Forms.Label();
            this.textBoxVIN = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            labelCarType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCarType
            // 
            labelCarType.AutoSize = true;
            labelCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCarType.Location = new System.Drawing.Point(63, 266);
            labelCarType.Name = "labelCarType";
            labelCarType.Size = new System.Drawing.Size(68, 20);
            labelCarType.TabIndex = 36;
            labelCarType.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(157, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 352);
            this.dataGridView1.TabIndex = 37;
            // 
            // labelCarModel
            // 
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarModel.Location = new System.Drawing.Point(27, 208);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(113, 20);
            this.labelCarModel.TabIndex = 35;
            this.labelCarModel.Text = "Phone number";
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarModel.Location = new System.Drawing.Point(157, 205);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(160, 26);
            this.textBoxCarModel.TabIndex = 34;
            // 
            // labelCarColor
            // 
            this.labelCarColor.AutoSize = true;
            this.labelCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarColor.Location = new System.Drawing.Point(27, 152);
            this.labelCarColor.Name = "labelCarColor";
            this.labelCarColor.Size = new System.Drawing.Size(124, 20);
            this.labelCarColor.TabIndex = 33;
            this.labelCarColor.Text = "Customer Name";
            // 
            // textBoxCarColor
            // 
            this.textBoxCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarColor.Location = new System.Drawing.Point(157, 149);
            this.textBoxCarColor.Name = "textBoxCarColor";
            this.textBoxCarColor.Size = new System.Drawing.Size(160, 26);
            this.textBoxCarColor.TabIndex = 32;
            // 
            // labelCarVIN
            // 
            this.labelCarVIN.AutoSize = true;
            this.labelCarVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarVIN.Location = new System.Drawing.Point(41, 91);
            this.labelCarVIN.Name = "labelCarVIN";
            this.labelCarVIN.Size = new System.Drawing.Size(99, 20);
            this.labelCarVIN.TabIndex = 31;
            this.labelCarVIN.Text = "Customer ID";
            // 
            // textBoxVIN
            // 
            this.textBoxVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVIN.Location = new System.Drawing.Point(157, 88);
            this.textBoxVIN.Name = "textBoxVIN";
            this.textBoxVIN.Size = new System.Drawing.Size(160, 26);
            this.textBoxVIN.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(213, 394);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 33);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(45, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 33);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 33);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(213, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 33);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // SearchCustomer
            // 
            this.AccessibleName = "SearchCustoer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 528);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(labelCarType);
            this.Controls.Add(this.labelCarModel);
            this.Controls.Add(this.textBoxCarModel);
            this.Controls.Add(this.labelCarColor);
            this.Controls.Add(this.textBoxCarColor);
            this.Controls.Add(this.labelCarVIN);
            this.Controls.Add(this.textBoxVIN);
            this.Name = "SearchCustomer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.Label labelCarColor;
        private System.Windows.Forms.TextBox textBoxCarColor;
        private System.Windows.Forms.Label labelCarVIN;
        private System.Windows.Forms.TextBox textBoxVIN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}