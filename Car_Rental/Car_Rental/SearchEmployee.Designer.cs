﻿
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.EmpID_Label = new System.Windows.Forms.Label();
            this.EmpID_Tbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpName_Tbox = new System.Windows.Forms.TextBox();
            this.EmpName_Label = new System.Windows.Forms.Label();
            this.BranchID_Tbox = new System.Windows.Forms.TextBox();
            this.BranchID_Label = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(68, 324);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(136, 27);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // EmpID_Label
            // 
            this.EmpID_Label.AutoSize = true;
            this.EmpID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpID_Label.Location = new System.Drawing.Point(43, 121);
            this.EmpID_Label.Name = "EmpID_Label";
            this.EmpID_Label.Size = new System.Drawing.Size(104, 20);
            this.EmpID_Label.TabIndex = 1;
            this.EmpID_Label.Text = "Employee ID";
            // 
            // EmpID_Tbox
            // 
            this.EmpID_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpID_Tbox.Location = new System.Drawing.Point(176, 121);
            this.EmpID_Tbox.Name = "EmpID_Tbox";
            this.EmpID_Tbox.Size = new System.Drawing.Size(203, 27);
            this.EmpID_Tbox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(473, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 484);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Summary";
            // 
            // EmpName_Tbox
            // 
            this.EmpName_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName_Tbox.Location = new System.Drawing.Point(176, 164);
            this.EmpName_Tbox.Name = "EmpName_Tbox";
            this.EmpName_Tbox.Size = new System.Drawing.Size(203, 27);
            this.EmpName_Tbox.TabIndex = 6;
            // 
            // EmpName_Label
            // 
            this.EmpName_Label.AutoSize = true;
            this.EmpName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName_Label.Location = new System.Drawing.Point(43, 164);
            this.EmpName_Label.Name = "EmpName_Label";
            this.EmpName_Label.Size = new System.Drawing.Size(131, 20);
            this.EmpName_Label.TabIndex = 5;
            this.EmpName_Label.Text = "Employee Name";
            // 
            // BranchID_Tbox
            // 
            this.BranchID_Tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID_Tbox.Location = new System.Drawing.Point(176, 211);
            this.BranchID_Tbox.Name = "BranchID_Tbox";
            this.BranchID_Tbox.Size = new System.Drawing.Size(203, 27);
            this.BranchID_Tbox.TabIndex = 8;
            // 
            // BranchID_Label
            // 
            this.BranchID_Label.AutoSize = true;
            this.BranchID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID_Label.Location = new System.Drawing.Point(43, 211);
            this.BranchID_Label.Name = "BranchID_Label";
            this.BranchID_Label.Size = new System.Drawing.Size(85, 20);
            this.BranchID_Label.TabIndex = 7;
            this.BranchID_Label.Text = "Branch ID";
            // 
            // Update_Button
            // 
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(224, 324);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(136, 27);
            this.Update_Button.TabIndex = 11;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(68, 383);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(136, 27);
            this.Delete_Button.TabIndex = 12;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.Location = new System.Drawing.Point(224, 383);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(136, 27);
            this.Search_Button.TabIndex = 13;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 545);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.BranchID_Tbox);
            this.Controls.Add(this.BranchID_Label);
            this.Controls.Add(this.EmpName_Tbox);
            this.Controls.Add(this.EmpName_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EmpID_Tbox);
            this.Controls.Add(this.EmpID_Label);
            this.Controls.Add(this.Add_Button);
            this.Name = "SearchEmployee";
            this.Text = "Employee Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label EmpID_Label;
        private System.Windows.Forms.TextBox EmpID_Tbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpName_Tbox;
        private System.Windows.Forms.Label EmpName_Label;
        private System.Windows.Forms.TextBox BranchID_Tbox;
        private System.Windows.Forms.Label BranchID_Label;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Search_Button;
    }
}