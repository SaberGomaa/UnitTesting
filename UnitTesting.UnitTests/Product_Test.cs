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

        Product product;

        [SetUp]
        public void Setup()
        {
            product = new Product();
        }

        [TearDown]
        public void TearDown()
        {
            // any code to do after finsh Test
            //  disconnect DB
        }

        [Test]
        [Ignore("For Dev Changes" , Until ="2023-7-30 12:03PM")]
        public void Test_Find_Name_Property()
        {
            //Assert.That(product , Has.Property("Name").And.Not.Property("Age"));
            Assert.That(product , Has.No.Property("Price"));
        }

        [Test]
        [Category("First Class")]
        public void Check_Product_First_Class()
        {
            var result = product.ReturnProductClassBasedOnPrice(1100);

            Assert.That(result, Is.EqualTo(ProductClassEnum.FirstClass.ToString()));
        }

        [Test]
        [Category("Second Class")]
        public void Check_Product_Second_Class()
        {
            var result = product.ReturnProductClassBasedOnPrice(900);

            Assert.That(result, Is.EqualTo(ProductClassEnum.SecondClass.ToString()));
        }

    }
}
