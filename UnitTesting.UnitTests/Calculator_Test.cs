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

        [Test]
        public void Div_Double_Numbers()
        {
            // AAA
            
            // Arange
            Calculator c= new Calculator();
            // Act
            double result =  c.Div_Double(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(.49).Within(.011) , "Not Equal");
        }

        [Test]
        public void Div_By_Zero()
        {
            Calculator c=new Calculator();

            //Assert.Throws<DivideByZeroException>(() =>
            //{
            //    c.Div_Double(1,0);
            //});
            Assert.That(() => c.Div_Double(.25, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Test_Collection_Items()
        {
            var arr = new[] { "saber", "maher", "Kayan" , "Fatema" , "Rahf" , "saber"};

            //Assert.That(arr, Has.Exactly(5).Items);
            //Assert.That(arr, Is.Unique);
            //Assert.That(arr , Is.Not.Empty);
            //Assert.That(arr , Does.Contain("saber"));
            //Assert.That(arr , Has.Exactly(2).EqualTo("saber").And.Exactly(1).EqualTo("maher"));
            Assert.That(arr, Has.Exactly(2).Matches<string>(s => s.Contains("sab")));
        }

        [Test]
        public void Test_String() 
        {
            string s = "Eman";
            Assert.That(s , Does.StartWith("E").And.EndWith("n"));
        }

        [Test]
        public void Test_Boolean()
        {
            bool isFound = default;

            Assert.That(isFound , Is.False);
        }

        [Test]
        public void Test_Rang()
        {
            int i = 11;
            Assert.That(i , Is.GreaterThan(10));
            Assert.That(i , Is.GreaterThanOrEqualTo(10));
            Assert.That(i, Is.InRange(10 , 20));
        }

        [Test]
        public void Test_References()
        {
            Calculator c1 = new Calculator(); 
            Calculator c3 = new Calculator();
            Calculator c2 = c1;

            //Assert.That(c1 , Is.SameAs(c3));
            Assert.That(c1 , Is.SameAs(c2));
        }

    }
}