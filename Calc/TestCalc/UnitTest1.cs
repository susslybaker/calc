
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
        public void Div_Zero()
        {



            string left = "4";

            string right = "0";

            string oper = "/";

            string expected = "Error";

            
            string actual = MyCalc.CountUp(oper, left, right);
            
            Assert.That(actual, Is.EqualTo(expected));





        }

        [Test]
        public void Dot()
        {
            int str = 15;

            string expected = "0";


            string actual = MyCalc.IndexLast(str);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]

        public void CalcStr()
        {
            string calcstr = "StrWithOutVal";

            string expected = "ErrorValue";

            string actual = MyCalc.Calculate(calcstr);
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]

        public void LastInd()
        {
            int index = 0;

            string expected = "NoNe";

            string actual = MyCalc.IndexLast(index);
            Assert.That(actual, Is.EqualTo(expected));


        }

        [Test]

        public void NotThisOp()
        {
            string left = "4";

            string right = "0";

            string oper = "ThisIsNotAnOp";

            string expected = "Error";

            
            string actual = MyCalc.CountUp(oper, left, right);
            
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

}
    

    