namespace InterviewTask.Desktop.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBox_InvoiceNoMethod = new System.Windows.Forms.ComboBox();
            this.invoiceSetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Region = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSetupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Generation Method";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBox_InvoiceNoMethod
            // 
            this.comboBox_InvoiceNoMethod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceSetupBindingSource, "InvoiceSetupID", true));
            this.comboBox_InvoiceNoMethod.FormattingEnabled = true;
            this.comboBox_InvoiceNoMethod.Location = new System.Drawing.Point(251, 186);
            this.comboBox_InvoiceNoMethod.Name = "comboBox_InvoiceNoMethod";
            this.comboBox_InvoiceNoMethod.Size = new System.Drawing.Size(284, 24);
            this.comboBox_InvoiceNoMethod.TabIndex = 2;
            // 
            // invoiceSetupBindingSource
            // 
            this.invoiceSetupBindingSource.DataSource = typeof(InterviewTask.BLL.DB.InvoiceSetup);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Region";
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.Location = new System.Drawing.Point(251, 129);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(284, 24);
            this.comboBox_Region.TabIndex = 5;
            this.comboBox_Region.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Region);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_InvoiceNoMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "InvoiceSetup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSetupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox_InvoiceNoMethod;
        private System.Windows.Forms.BindingSource invoiceSetupBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Region;
    }
}

