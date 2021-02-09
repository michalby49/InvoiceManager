using InvoiceManager.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Invoices = new List<Invoice>
            {
                new Invoice
                {
                    Id = 1,
                    Title = "Fv/01/2021",
                    CreatedDate = DateTime.Now,
                    PaymantDate = DateTime.Now,
                    Value = 999,
                    Client = new Client{ Name = "Klient 1"}
                },
                new Invoice
                {
                    Id = 2,
                    Title = "Fv/02/2021",
                    CreatedDate = DateTime.Now,
                    PaymantDate = DateTime.Now,
                    Value = 2000,
                    Client = new Client{ Name = "Klient 2"}
                },
                new Invoice
                {
                    Id = 3,
                    Title = "Fv/01/2021",
                    CreatedDate = DateTime.Now,
                    PaymantDate = DateTime.Now,
                    Value = 400,
                    Client = new Client{ Name = "Klient 3"}
                }

            };
            return View(Invoices);
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Invoice(int id = 0)
        {
            return View();
        }
    }
}