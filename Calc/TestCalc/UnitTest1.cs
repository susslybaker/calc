
using Calculator;
using Microsoft.VisualStudio.TestPlatform.TestHost;

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



            MyCalc.CountUp(oper, left, right);
            
          
        }
    }
}