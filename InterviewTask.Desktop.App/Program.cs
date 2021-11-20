using InterviewTask.BLL.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewTask.Desktop.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //InvoicesDetailsToFile t = new InvoicesDetailsToFile();
            //t.ExportInvoicesToJson();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReportPrinting());
        }
    }
}
