using InterviewTask.BLL.DB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.BLL.Manager
{
    public class InvoicesDetailsToFile
    {
        public InvoicesDetailsToFile()
        {

        }

        public void ExportInvoicesToJson()
        {
            using (DBModel db = new DBModel())
            {
                var data = db.VW_InvoiceDetails.ToList();
                var json = JsonConvert.SerializeObject(data);
                System.IO.File.WriteAllText(string.Format(@"D:\{0}.txt",DateTime.Today.Date.ToShortDateString().Replace('/','-')), json);
            }
        }
    }
}
