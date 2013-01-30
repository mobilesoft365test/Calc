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
    class TestNewForms : NUnit.Extensions.Forms.NUnitFormsAssertTest
    {
        private Form1 testForm = null;
        
        public void LaunchForm1()
        {
            testForm = new Form1();
            testForm.Show();
        }

        [Test]
        public void FormCreate()
        {
            LaunchForm1();
            Assert.AreEqual("Calc", testForm.Text);
        }

        [Test]
        public void ButtonMessageBoxClick()
        {
            LaunchForm1();
            var msgBtnTester = new ButtonTester("MessageBtn", testForm);
            ExpectModal("Test", "OnCloseMessageBox");
            msgBtnTester.Click();
        }

        private void OnCloseMessageBox()
        {
            var mbt = new MessageBoxTester("Test");
            mbt.ClickOk();
        }

        [Test]
        public void ButtonForm1Click()
        {
            LaunchForm1();
            var Form1BtnTester = new ButtonTester("Form1Btn", testForm);
            ExpectModal("testForm1", "OnCloseTestForm1");
            Form1BtnTester.Click();
        }

        private void OnCloseTestForm1()
        {
            var frm = new FormTester("testForm1");
            frm.Close();
        }

        [Test]
        public void ButtonForm2Click()
        {
            LaunchForm1();
            var Form1BtnTester = new ButtonTester("Form2Btn", testForm);
            ExpectModal("testForm2", "OnCloseTestForm2");
            Form1BtnTester.Click();
        }

        private void OnCloseTestForm2()
        {
            var frm = new FormTester("testForm2");
            frm.Close();
        }
  
       
    }
}