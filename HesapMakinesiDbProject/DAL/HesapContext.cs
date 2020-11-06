using HesapMakinesiDbProject.Migrations;
using HesapMakinesiDbProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HesapMakinesiDbProject.DAL
{
    public class HesapContext : DbContext
    {

        public HesapContext() : base("HesapContext")
        {
            //atabase.SetInitializer<HesapContext>(null);   
        }

        public DbSet<Operation> Islemler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Droplanmadan  guncellenecek db 
            Database.SetInitializer<HesapContext>(new DropCreateDatabaseIfModelChanges<HesapContext>());
            // Database.SetInitializer<HesapContext>(new MigrateDatabaseToLatestVersion<HesapContext, Configuration>());
        }
    }
}