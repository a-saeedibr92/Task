namespace InterviewTask.Desktop.App
{
    partial class ReportPrinting
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
            this.comboBox_Invoices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Invoices
            // 
            this.comboBox_Invoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Invoices.FormattingEnabled = true;
            this.comboBox_Invoices.Location = new System.Drawing.Point(240, 141);
            this.comboBox_Invoices.Name = "comboBox_Invoices";
            this.comboBox_Invoices.Size = new System.Drawing.Size(253, 24);
            this.comboBox_Invoices.TabIndex = 0;
            this.comboBox_Invoices.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Inovice";
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(620, 141);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(75, 29);
            this.button_print.TabIndex = 2;
            this.button_print.Text = "print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // ReportPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Invoices);
            this.Name = "ReportPrinting";
            this.Text = "ReportPrinting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Invoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_print;
    }
}