using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Coca_Cola;
using NUnit.Framework;

namespace TDD_Coca_Cola.Tester
{
    public class CocaColaTest
    {
        [Test]
        public void Input1Get1()
        {
            var manager = new NumberManager();
            string actual = manager.CocaColaGenerator(1);
            var expected = "1";
            Assert.AreEqual(actual, expected);


        }
    }
}
