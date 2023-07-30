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
    public class Employee_Test
    {
        Employee emp;

        [SetUp]
        public void setup()
        {
            emp = new Employee();
        }

        //[Test]
        //[Category("Senior Citizen")]
        //public void TestEmployeeIsSeniorCitizen()
        //{
        //    var res = emp.IsSeniorCitizen(60);

        //    Assert.IsTrue(res);
        //}

        //[Test]
        //[Category("Not Senior Citizen")]
        //public void TestEmployeeIsNotSeniorCitizen()
        //{
        //    var res = emp.IsSeniorCitizen(50);

        //    Assert.IsFalse(res);
        //}

        [Test]
        [TestCase(60 , true)]
        [TestCase(70 , true)]
        [TestCase(50 , false)]
        public void TestEmployeeIsSeniorCitizen(int age , bool expectedValue)
        {
            var result = emp.IsSeniorCitizen(age);
            Assert.AreEqual(expectedValue, result);
        }
        
    }
}
