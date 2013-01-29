using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calc;
using NUnit.Framework;
using NUnit.Extensions.Forms;

namespace CalcTest
{
    [TestFixture]
    public class TestMethods
    {
        [Test]
        public static void AddTest()
        {
            Assert.AreEqual(Operations.Add(3,5),8);
        }
    }
}
