using HesapMakinesiDbProject.DAL;
using HesapMakinesiDbProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HesapMakinesiDbProject.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home
        public ActionResult Index()
        {


            return View(new Operation());
        }


        [HttpPost]
        public ActionResult Index(Operation o, string Hesapla)
        {
            if (Hesapla == "btntopla")
            {
                o.Result = o.Number1 + o.Number2;
                o.Operator = "+";
            }
            else if (Hesapla == "btnCikar")
            {
                o.Result = o.Number1 - o.Number2;
                o.Operator = "-";
            }
            else if (Hesapla == "btnCarp")
            {
                o.Result = o.Number1 * o.Number2;
                o.Operator = "*";
            }
            else
            {
                o.Result = o.Number1 / o.Number2;
                o.Operator = "/";
            }

            using (HesapContext ctx = new HesapContext())
            {
                o.Tarih = DateTime.Now;
                o.Saat = DateTime.Now;
                ctx.Islemler.Add(o);
                ctx.SaveChanges();

            }


            return View(o);
        }


        public ActionResult GecmisListesi()
        {
            using (HesapContext ctx = new HesapContext())
            {
                return View(ctx.Islemler.ToList());
            }



        }

        public ActionResult GecmisGoster(DateTime? Tarih, Operation op)
        {
            using (HesapContext ctx = new HesapContext())
            {
                Operation o = ctx.Islemler.Find(Tarih);
            }

            return View(op);
        }

        [HttpPost]
        public ActionResult GecmisGoster(Operation op)
        {
            using (HesapContext ctx = new HesapContext())
            {
                ctx.Entry(op).State = EntityState.Added;
               ctx.SaveChanges();

                return View();

            }
          
        }

    }
}