using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections;
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

        //[Test]
        //[TestCase(60 , true)]
        //[TestCase(70 , true)]
        //[TestCase(50 , false)]
        //public void TestEmployeeIsSeniorCitizen(int age , bool expectedValue)
        //{
        //    var result = emp.IsSeniorCitizen(age);
        //    Assert.AreEqual(expectedValue, result);
        //}

        //[Test]
        //[TestCase(60 , ExpectedResult = true)]
        //[TestCase(70 , ExpectedResult = true)]
        //[TestCase(50 , ExpectedResult = false)]
        //public bool TestEmployeeIsSeniorCitizen(int age)
        //{
        //    return emp.IsSeniorCitizen(age);
        //}


        [Test]
        [TestCaseSource(typeof(TestData))]
        public bool TestEmployeeIsSeniorCitizen(int age)
        {
            return emp.IsSeniorCitizen(age);
        }

    }
    public class TestData :IEnumerable
    {
        //public IEnumerator GetEnumerator()
        //{
        //    yield return new TestCaseData(50).Returns(false);
        //    yield return new TestCaseData(40).Returns(false);
        //    yield return new TestCaseData(60).Returns(true);
        //    yield return new TestCaseData(70).Returns(true);
        //}

        public IEnumerator GetEnumerator()
        {
            StreamReader r = new StreamReader("E:\\c#\\C#ITI\\UnitTesting\\UnitTesting.UnitTests\\EmployeesData.json");
            string json = r.ReadToEnd();

            List<EmployeeTestCaseData> items =
                JsonConvert.DeserializeObject<List<EmployeeTestCaseData>>(json);

            foreach (var item in items)
            {
                yield return new TestCaseData(item.age).Returns(item.expectedResult);
            }

        }

    }

}
