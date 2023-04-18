
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
        [Test]
        public void DivisionByZero()
        {
            //Arrange

            string left = "10";

            string right = "0";

            string oper = "/";

            string expected = "Error";

            //Act
            string actual = MyCalc.CountUp(oper, left, right);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void MenusTest()
        {
            //Arrange

            string oper = "-";

            string cent = "5";
            string expected = "-5";

            //Act
            string actual = MyCalc.CountUp(oper, cent);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DoubleMenusTest()
        {
            //Arrange

            string oper = "-";

            string cent = "-5";
            string expected = "5";

            //Act
            string actual = MyCalc.CountUp(oper, cent);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ZeroMenusTest()
        {
            //Arrange

            string oper = "-";

            string cent = "0";
            string expected = "0";

            //Act
            string actual = MyCalc.CountUp(oper, cent);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CenterTest()
        {
            //Arrange

            string oper = "";

            string cent = "10";
            string expected = "10";

            //Act
            string actual = MyCalc.CountUp(oper, cent);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SinusTest()
        {
            //Arrange

            string oper = "sin";

            string cent = "100";
            string expected = "0,984807753012208";

            //Act
            string actual = MyCalc.CountUp(oper, cent);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void CosinusTest()
        {
            //Arrange

            string oper = "cos";

            string cent = "100";
            string expected = "-0,1736481776669303";

            //Act
            string actual = MyCalc.CountUp(oper, cent);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TangensTest()
        {
            //Arrange

            string oper = "tan";

            string cent = "100";
            string expected = "-5,671281819617711";

            //Act
            string actual = MyCalc.CountUp(oper, cent);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void LogarifmTest()
        {
            //Arrange

            string oper = "log10";

            string cent = "100";
            string expected = "2";

            //Act
            string actual = MyCalc.CountUp(oper, cent);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }





    }
}


