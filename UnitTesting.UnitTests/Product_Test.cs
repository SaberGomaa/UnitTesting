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
        [Ignore("For Dev Changes" , Until ="2023-7-30 12:03PM")]
        public void Test_Find_Name_Property()
        {
            Product product = new Product();
            //Assert.That(product , Has.Property("Name").And.Not.Property("Age"));
            Assert.That(product , Has.No.Property("Price"));
        }

        [Test]
        public void Check_Product_class()
        {
            Product product = new Product();
            var result = product.ReturnProductClassBasedOnPrice(1100);

            //Assert.That(result, Is.EqualTo(ProductClassEnum.SecondClass.ToString()));
            Assert.That(result, Is.EqualTo(ProductClassEnum.FirstClass.ToString()));
        }

    }
}
