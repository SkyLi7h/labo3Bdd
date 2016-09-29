using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using labo3Bdd;

namespace UnitTestProjectLabo3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }
    }
}
