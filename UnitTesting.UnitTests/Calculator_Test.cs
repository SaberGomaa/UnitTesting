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
    public class Calculator_Test
    {
        [Test]
        public void Add_Int_Positive_Numbers()
        {
            //AAA

            //Arrang
            Calculator calc = new Calculator();

            //Act
            int result = calc.Add_Int(10, 20);
            
            //Assert
            Assert.AreEqual(30 ,result);
            Assert.That(result, Is.EqualTo(30));
            Assert.That(result, Is.Not.EqualTo(31));

        }
    }
}