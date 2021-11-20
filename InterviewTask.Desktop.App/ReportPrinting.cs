using InterviewTask.BLL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewTask.Desktop.App
{
    public partial class ReportPrinting : Form
    {
        public ReportPrinting()
        {
            InitializeComponent();
            LoadInvoiceCombobox();
        }

        private void LoadInvoiceCombobox()
        {
            using (DBModel db = new DBModel())
            {
                var InvoiceList=db.VW_InvoiceDetails.Select(e=>new { e.InvoiceId,e.InvoiceNo}).ToList();
                this.comboBox_Invoices.DisplayMember = "InvoiceNo";
                this.comboBox_Invoices.ValueMember = "InvoiceId";
                this.comboBox_Invoices.DataSource = InvoiceList;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            CRViewer popUpForm = new CRViewer();
            var selectedInvoice = comboBox_Invoices.SelectedValue;
            if(selectedInvoice!=null)
            {

                popUpForm.setInvoiceId(selectedInvoice as int?);
                popUpForm.Show();
            }
            
        }
    }
}
