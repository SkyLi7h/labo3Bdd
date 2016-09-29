using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using labo3Bdd;
using System.Linq;

namespace UnitTestProjectLabo3
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void CanGetCustomers()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Customer.ToList().Count);
            }

        }

        public CompanyContext GetContext()
        {
            return new CompanyContext();
        }
    }
}
