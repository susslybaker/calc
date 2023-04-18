
using Calculator;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection.Metadata;

namespace TestCalc
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        


        [Test]
        public void TestAddition()
        {

            //Arrange

            string left = "2";

            string right = "2";

            string oper = "+";

            string expected = "4";

            //Act
            string actual = MyCalc.CountUp(oper, left, right);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestSubtraction()
        {

            //Arrange

            string left = "5";

            string right = "2";

            string oper = "-";

            string expected = "3";

            //Act
            string actual = MyCalc.CountUp(oper, left, right);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestMultiply()
        {

            //Arrange

            string left = "10";

            string right = "5";

            string oper = "*";

            string expected = "50";

            //Act
            string actual = MyCalc.CountUp(oper, left, right);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestDivision()
        {

            //Arrange

            string left = "10";

            string right = "5";

            string oper = "/";

            string expected = "2";

            //Act
            string actual = MyCalc.CountUp(oper, left, right);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}


