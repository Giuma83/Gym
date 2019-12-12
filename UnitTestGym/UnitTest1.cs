using System;
using Gym.Dal.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGym
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomerRepository cr = new CustomerRepository();

            var result = cr.ReadCustomerFromId(2);
            string c = result.NameCustomer;
            Assert.AreEqual(c, "Mario");
            Assert.IsTrue(c.Equals("Mario"));
        }
    }
}
