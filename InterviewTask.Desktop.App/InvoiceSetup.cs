using InterviewTask.BLL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Desktop.App
{
    public class InvoiceSetup
    {
        int InvoiceNoMethod { set; get; }
        //bool DiscountVisibility { set; get; }
        public InvoiceSetup()
        {

        }
        public bool SetInvoiceMothod(int InvoiceNoMethod)
        {
            DBModel db = new DBModel();
            return false;
        }
        public int GetInvoiceMethod(int? regionId)
        {
            using (DBModel db = new DBModel())
            {
                if (regionId.HasValue)
                {
                    var result = db.Regions.Where(r => r.RegionID == regionId).SingleOrDefault();
                    if (result.InvoiceSetupID.HasValue)
                        return result.InvoiceSetupID.Value;
                    else
                        return -1;
                }
                else
                {
                    return -1;
                }


            }
        }
        public List<BLL.DB.InvoiceSetup> GetInvoiceSetup()
        {
            using (DBModel db = new DBModel())
            {


                var result = db.InvoiceSetups.ToList();
                return result;

            }
        }
        public List<BLL.DB.Region> GetRegion()
        {
            DBModel db = new DBModel();
            var result = db.Regions.ToList();
            return result;
        }
    }
}
