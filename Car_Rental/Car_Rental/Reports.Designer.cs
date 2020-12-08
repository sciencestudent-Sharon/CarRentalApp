
namespace Car_Rental
{
    partial class Reports
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ReeportText = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Average Rental time",
            "Most popular Model",
            "Highest Grossing Branch"});
            this.comboBox1.Location = new System.Drawing.Point(12, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // ReeportText
            // 
            this.ReeportText.AutoSize = true;
            this.ReeportText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReeportText.Location = new System.Drawing.Point(9, 179);
            this.ReeportText.Name = "ReeportText";
            this.ReeportText.Size = new System.Drawing.Size(165, 20);
            this.ReeportText.TabIndex = 1;
            this.ReeportText.Text = "Please Select a report";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(300, 119);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 579);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ReeportText);
            this.Controls.Add(this.comboBox1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox ReportTypeBox2;
        private System.Windows.Forms.Label ReeportText;
        private System.Windows.Forms.Button Submit;
    }
}