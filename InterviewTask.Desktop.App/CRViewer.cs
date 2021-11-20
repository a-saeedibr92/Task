using InterviewTask.BLL.DB;
using InterviewTask.BLL.Enums;
using InterviewTask.BLL.Manager;
using InterviewTask.Desktop.App.Report;
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
    public partial class CRViewer : Form
    {
        private int InvoiceID;
        public CRViewer()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportOperation operation = new ReportOperation();
            var InvoiceResult=operation.GetInvoiceData(InvoiceID);
                CR_Invoice report = new CR_Invoice();
                report.Database.Tables["Invoice"].SetDataSource(InvoiceResult);
            
                report.SetParameterValue("NotShowDiscount", !operation.ShowingDiscount(InvoiceID));
            //report.Section2.ReportObjects[3].ObjectFormat.EnableSuppress = true;
            //report.Section3.ReportObjects[3].ObjectFormat.EnableSuppress = true;
            crystalReportViewer1.ReportSource = report;
            



        }
        public void setInvoiceId(int? InvoiceID)
        {
            if (InvoiceID.HasValue)
            {
                this.InvoiceID = InvoiceID.Value;
            }
        }

        private void CRViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
