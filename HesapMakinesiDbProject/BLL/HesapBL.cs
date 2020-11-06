using HesapMakinesiDbProject.DAL;
using HesapMakinesiDbProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HesapMakinesiDbProject.BLL
{
    public class HesapBL
    {
        HesapContext ctx = new HesapContext();


        public bool Ekle(Operation op)
        {
            ctx.Islemler.Add(op);
            return ctx.SaveChanges() > 0;
        }

        public Operation Getir(int id) => ctx.Islemler.Find(id); 
    }
}