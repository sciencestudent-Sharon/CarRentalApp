
namespace Car_Rental
{
    partial class SearchEmployee
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BranchID_Label = new System.Windows.Forms.Label();
            this.BranchID_Tbox = new System.Windows.Forms.TextBox();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.LastName_Tbox = new System.Windows.Forms.TextBox();
            this.EmpID_Label = new System.Windows.Forms.Label();
            this.EmpID_Tbox = new System.Windows.Forms.TextBox();
            this.FName_Label = new System.Windows.Forms.Label();
            this.FName_Tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pos_Tbox = new System.Windows.Forms.TextBox();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(103, 474);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(102, 22);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.Location = new System.Drawing.Point(220, 522);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(102, 22);
            this.Search_Button.TabIndex = 13;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Summary";
            // 
            // Update_Button
            // 
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(220, 474);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(102, 22);
            this.Update_Button.TabIndex = 11;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(103, 522);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(102, 22);
            this.Delete_Button.TabIndex = 12;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID,
            this.First_Name,
            this.Last_Name,
            this.Position,
            this.Branch_ID});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(355, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 408);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BranchID_Label
            // 
            this.BranchID_Label.AutoSize = true;
            this.BranchID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID_Label.Location = new System.Drawing.Point(90, 369);
            this.BranchID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BranchID_Label.Name = "BranchID_Label";
            this.BranchID_Label.Size = new System.Drawing.Size(70, 17);
            this.BranchID_Label.TabIndex = 43;
            this.BranchID_Label.Text = "Branch ID";
            // 
            // BranchID_Tbox
            // 
            this.BranchID_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID_Tbox.Location = new System.Drawing.Point(188, 369);
            this.BranchID_Tbox.Margin = new System.Windows.Forms.Padding(2);
            this.BranchID_Tbox.Name = "BranchID_Tbox";
            this.BranchID_Tbox.Size = new System.Drawing.Size(121, 23);
            this.BranchID_Tbox.TabIndex = 42;
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_Label.Location = new System.Drawing.Point(84, 268);
            this.LastName_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(76, 17);
            this.LastName_Label.TabIndex = 39;
            this.LastName_Label.Text = "Last Name";
            // 
            // LastName_Tbox
            // 
            this.LastName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_Tbox.Location = new System.Drawing.Point(173, 266);
            this.LastName_Tbox.Margin = new System.Windows.Forms.Padding(2);
            this.LastName_Tbox.Name = "LastName_Tbox";
            this.LastName_Tbox.Size = new System.Drawing.Size(156, 23);
            this.LastName_Tbox.TabIndex = 38;
            // 
            // EmpID_Label
            // 
            this.EmpID_Label.AutoSize = true;
            this.EmpID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpID_Label.Location = new System.Drawing.Point(80, 342);
            this.EmpID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmpID_Label.Name = "EmpID_Label";
            this.EmpID_Label.Size = new System.Drawing.Size(87, 17);
            this.EmpID_Label.TabIndex = 28;
            this.EmpID_Label.Text = "Employee ID";
            // 
            // EmpID_Tbox
            // 
            this.EmpID_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpID_Tbox.Location = new System.Drawing.Point(188, 342);
            this.EmpID_Tbox.Margin = new System.Windows.Forms.Padding(2);
            this.EmpID_Tbox.Name = "EmpID_Tbox";
            this.EmpID_Tbox.Size = new System.Drawing.Size(121, 23);
            this.EmpID_Tbox.TabIndex = 27;
            // 
            // FName_Label
            // 
            this.FName_Label.AutoSize = true;
            this.FName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName_Label.Location = new System.Drawing.Point(84, 242);
            this.FName_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FName_Label.Name = "FName_Label";
            this.FName_Label.Size = new System.Drawing.Size(76, 17);
            this.FName_Label.TabIndex = 24;
            this.FName_Label.Text = "First Name";
            // 
            // FName_Tbox
            // 
            this.FName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName_Tbox.Location = new System.Drawing.Point(173, 239);
            this.FName_Tbox.Margin = new System.Windows.Forms.Padding(2);
            this.FName_Tbox.Name = "FName_Tbox";
            this.FName_Tbox.Size = new System.Drawing.Size(156, 23);
            this.FName_Tbox.TabIndex = 23;
            this.FName_Tbox.TextChanged += new System.EventHandler(this.FName_Tbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Employee Posistion";
            // 
            // Pos_Tbox
            // 
            this.Pos_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos_Tbox.Location = new System.Drawing.Point(188, 315);
            this.Pos_Tbox.Margin = new System.Windows.Forms.Padding(2);
            this.Pos_Tbox.Name = "Pos_Tbox";
            this.Pos_Tbox.Size = new System.Drawing.Size(121, 23);
            this.Pos_Tbox.TabIndex = 44;
            // 
            // EID
            // 
            this.EID.HeaderText = "ID";
            this.EID.Name = "EID";
            this.EID.ReadOnly = true;
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Branch_ID
            // 
            this.Branch_ID.HeaderText = "Branch ID";
            this.Branch_ID.Name = "Branch_ID";
            this.Branch_ID.ReadOnly = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(803, 570);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(102, 22);
            this.clear.TabIndex = 46;
            this.clear.Text = "Clear Search";
            this.clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 642);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pos_Tbox);
            this.Controls.Add(this.BranchID_Label);
            this.Controls.Add(this.BranchID_Tbox);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.LastName_Tbox);
            this.Controls.Add(this.EmpID_Label);
            this.Controls.Add(this.EmpID_Tbox);
            this.Controls.Add(this.FName_Label);
            this.Controls.Add(this.FName_Tbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.SearchEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label BranchID_Label;
        private System.Windows.Forms.TextBox BranchID_Tbox;
        private System.Windows.Forms.Label LastName_Label;
        private System.Windows.Forms.TextBox LastName_Tbox;
        private System.Windows.Forms.Label EmpID_Label;
        private System.Windows.Forms.TextBox EmpID_Tbox;
        private System.Windows.Forms.Label FName_Label;
        private System.Windows.Forms.TextBox FName_Tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pos_Tbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_ID;
        private System.Windows.Forms.Button clear;
    }
}