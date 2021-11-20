using InterviewTask.BLL.DB;
using InterviewTask.BLL.Enums;
using InterviewTask.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.BLL.Manager
{
    public class ReportOperation
    {
        public ReportOperation()
        {

        }
        public bool ShowingDiscount(int InvoiceID)
        {
            using (DBModel db = new DBModel())
            {
                var setupMethod = db.Invoices.Where(i => i.InvoiceId == InvoiceID).SingleOrDefault();
                if ((setupMethod.Region.InvoiceSetupID != null) && (setupMethod.Region.InvoiceSetupID == (int)SetupMethodEnum.FunctionGenerated_Discount ||
                       setupMethod.Region.InvoiceSetupID == (int)SetupMethodEnum.AutoIncrement_Discount))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
        public List<InvoiceModel> GetInvoiceData(int InvoiceID)
        {
            using (DBModel db = new DBModel())
            {
                var setupMethod = db.Invoices.Where(i => i.InvoiceId == InvoiceID).SingleOrDefault();
                var InvoiceResult = new List<InvoiceModel>();
                //if (setupMethod.Region.InvoiceSetupID != null)
                {
                    var res = db.VW_InvoiceDetails.Where(i => i.InvoiceId == InvoiceID).ToList();

                    InvoiceResult = res.Select(i => new InvoiceModel
                    {
                        InvoiceNo = (setupMethod.Region.InvoiceSetupID != null) && (setupMethod.Region.InvoiceSetupID == (int)SetupMethodEnum.AutoIncrement_Discount ||
                         setupMethod.Region.InvoiceSetupID == (int)SetupMethodEnum.AutoIncrement_NoDiscount)
                         ? i.InvoiceId.ToString() : i.InvoiceNo,
                        ProductName = i.ProductName,
                        Quantity = i.Quantity,
                        UnitPrice = i.UnitPrice,
                        Discount = i.Discount
                    }).ToList();

                    return InvoiceResult;
                }


            }
        }
    }
}
