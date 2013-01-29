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
        TextBoxTester aBoxTester = new TextBoxTester("BoxA");
        TextBoxTester bBoxTester = new TextBoxTester("BoxB");
        TextBoxTester resBoxTester = new TextBoxTester("BoxResult");
        ButtonTester AddBtnTester = new ButtonTester("AddBtn");
        Calc.Form1 _form1;
        public override void Setup()
        {
            base.Setup();
            var f = new Form1();
            f.Show();
        }

        //Positive tests
        [Test]
        public void CorrectAddTest()
        {
            aBoxTester.Enter("5");
            bBoxTester.Enter("9");
            string expected = "14";
            AddBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text,expected);
        }

                
        //Negative tests

    }
}
