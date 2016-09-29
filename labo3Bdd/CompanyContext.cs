using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo3Bdd
{
    class CompanyContext : DbContext
    {

        public DbSet<Customer> Customer { get; set; }
        public CompanyContext():base(@"Data Source=(localdb)\MSSQLLocalDb; Initial Catalog=labo3Db")
        {

        }
    }
}
