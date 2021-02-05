using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNunit
{
    [TestFixture]
    public class StupidTest
    {
        [TestCase(',')]
        public void Verify_re_run(char parameter) 
        {
            Assert.Fail("This test will always fails");
        }
    }
}
