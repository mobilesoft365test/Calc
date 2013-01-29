using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calc;
using NUnit.Framework;
using NUnit.Extensions.Forms;

namespace CalcTest
{
    [TestFixture]
    class TestForm : NUnitFormTest
    {
        Calc.Form1 _form1;
        public override void Setup()
        {
            base.Setup();
            var f = new Form1();
            f.Show();
        }
    }
}
