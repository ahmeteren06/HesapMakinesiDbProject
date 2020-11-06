namespace HesapMakinesiDbProject.Migrations
{
    using DAL;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HesapMakinesiDbProject.DAL.HesapContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HesapMakinesiDbProject.DAL.HesapContext context)
        {

            using (HesapContext ctx=new HesapContext())
            {
                ctx.Islemler.AddOrUpdate(new Operation[] {
                    new Operation {OperationId=1, Number1=2,Number2=10,Operator="+",Result=12,Tarih=DateTime.Now,Saat=DateTime.Now }
                });
                ctx.SaveChanges();
            }


            //  This method will be called after migrating to the latest version. 

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
