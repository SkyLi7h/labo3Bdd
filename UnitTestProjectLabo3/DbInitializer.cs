using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labo3Bdd;

namespace UnitTestProjectLabo3
{
    class DbInitializer:DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer customer = new labo3Bdd.Customer()
            {
                Name = "Ferrer Lucas",
                AdresseLine1 = "Rue du trichon 7",
                City = "Nil-Saint-Vincent",
                Country = "Belgique",
                EMail = "skyli7h@gmail.com",
                Id = 3,
                Remark = "Client régulier",
                PostCode = "5377"
            };
            context.Customer.Add(customer);
            context.SaveChanges();
        }
    }
}
