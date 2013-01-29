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
        ButtonTester MultBtnTester = new ButtonTester("MultBtn");
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

            aBoxTester.Enter("0");
            bBoxTester.Enter("1984");
            expected = "1984";
            AddBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);

            aBoxTester.Enter("-115");
            bBoxTester.Enter("-9564");
            expected = "-9679";
            AddBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);

            aBoxTester.Enter("-75");
            bBoxTester.Enter("257");
            expected = "182";
            AddBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);
            
            aBoxTester.Enter("451");
            bBoxTester.Enter("-3779");
            expected = "-3328";
            AddBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);

            aBoxTester.Enter("0");
            bBoxTester.Enter("0");
            expected = "0";
            AddBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);
        }

        public void CorrectMultTest()
        {
            aBoxTester.Enter("3");
            bBoxTester.Enter("8");
            string expected = "24";
            MultBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);

            aBoxTester.Enter("77");
            bBoxTester.Enter("0");
            expected = "0";
            MultBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);

            aBoxTester.Enter("-3");
            bBoxTester.Enter("-20");
            expected = "60";
            MultBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);

            aBoxTester.Enter("-7");
            bBoxTester.Enter("10");
            expected = "-70";
            MultBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);

            aBoxTester.Enter("0");
            bBoxTester.Enter("0");
            expected = "0";
            MultBtnTester.Click();
            Assert.AreEqual(resBoxTester.Text, expected);
        }
        
        //Negative tests


    }
}
