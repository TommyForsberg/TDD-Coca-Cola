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
        NumberManager manager = new NumberManager();

        [Test]
        public void Input1Get1() //Written by Tommy
        {
            //var manager = new NumberManager();
            string actual = manager.CocaColaGenerator(1);
            var expected = "1";
            Assert.AreEqual(actual, expected);
        }

        [Test]

        //  Tests values between 1 and 15 thats divisible by 3. Written by Jimmy
        public void Input3GetCoca( 
            [Values(3, 6, 9, 12)] int input)
        {
            string actual = manager.CocaColaGenerator(input);
            Assert.AreEqual("Coca", actual);
        }

        [Test]

        //  Tests values between 1 and 15 thats divisible by 5. Written by Jimmy
        public void Input3GetCola(                    
            [Values(5, 10)] int input)
        {
            string actual = manager.CocaColaGenerator(input);
            Assert.AreEqual("Cola", actual);
        }

        [Test]

        //  Tests values thats divisible by 3 and 5. Written by Tommy
        public void Input15GetCocaCola(
           [Values(15,30)] int input)
        {
            string actual = manager.CocaColaGenerator(input);
            Assert.AreEqual("Coca Cola", actual);
        }
    }
}
