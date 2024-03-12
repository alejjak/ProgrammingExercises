using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComAlgLibTester
{
    public class StringTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase("The quick\nbrown fox jumps over \nthe lazy dog", ExpectedResult = "quick over dog")]
        public string TestSplitString(string s)
        {
            //StringMaster sm = new StringMaster(s);
            return StringMaster.StringExample1(s);
        }

    }
}
