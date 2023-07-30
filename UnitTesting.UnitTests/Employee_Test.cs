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
    /// <summary>
    /// this TLD Test Last Development
    /// 
    ///  TDD Test Driven Development (Test Befor Code ) 
    ///  Test => Fail => code to pass this testCase
    /// 
    /// </summary>
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

        //[Test]
        //[TestCaseSource(typeof(TestData))]
        //public bool TestEmployeeIsSeniorCitizen(int age)
        //{
        //    return emp.IsSeniorCitizen(age);
        //}

        //[Test]
        //[Sequential]
        //public void testEmployeeIsSeniorcitizen([Values(50 , 60 , 70)] int age , [Values(false ,true,true)]bool expectedResult)
        //{
        //    var result = emp.IsSeniorCitizen(age);
        //    Assert.That(expectedResult, Is.EqualTo(result));
        //}

        //[Test]
        //public void testEmployeeIsSeniorcitizen([Range(50, 60,2)] int age, [Values(true)] bool expectedResult)
        //{
        //    var result = emp.IsSeniorCitizen(age);
        //    Assert.That(expectedResult, Is.EqualTo(result));
        //}

        [Test]
        public void testEmployeeIsSeniorcitizen([Random(40 ,80 ,5,Distinct =true)] int age, [Values(true)] bool expectedResult)
        {
            var result = emp.IsSeniorCitizen(age);
            Assert.That(expectedResult, Is.EqualTo(result));
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
