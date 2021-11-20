using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTask.BLL.DB;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTaks.Web.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateInvoice(Invoice model)
        {
            using (DBModel dB = new DBModel()) {
                dB.Invoices.Add(model);
                    }
                return View();
        }
    }
}