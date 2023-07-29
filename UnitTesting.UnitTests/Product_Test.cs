using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Project;

namespace UnitTesting.UnitTests
{
    [TestFixture]
    public class Product_Test
    {
        [Test]
        public void Test_Find_Name_Property()
        {
            Product product = new Product();
            Assert.That(product , Has.Property("Name").And.Not.Property("Age"));
        }
    }
}
