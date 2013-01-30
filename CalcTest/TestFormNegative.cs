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
    class TestFormNegative : NUnit.Extensions.Forms.NUnitFormsAssertTest
    {
        TextBoxTester aBoxTester = new TextBoxTester("BoxA");
        TextBoxTester bBoxTester = new TextBoxTester("BoxB");
        TextBoxTester resBoxTester = new TextBoxTester("BoxResult");
        ButtonTester AddBtnTester = new ButtonTester("AddBtn");
        ButtonTester MultBtnTester = new ButtonTester("MultBtn");
        string ErrorDialogCaption = "Input data error!";
        private testForm1 testForm = null;
        public bool err = false;

        public void LaunchForm1()
        {
            var testForm = new Form1();
            testForm.Show();
        }

        //Negative tests
        
        [Test]
        public void NoDataTestAdd()
        {
            {
                LaunchForm1();
                ExpectModal(ErrorDialogCaption, "OnModal_DismissMessageBox");
                aBoxTester["Text"] = string.Empty;
                bBoxTester["Text"] = string.Empty;
                AddBtnTester.Click();
             }
        }
        
        [Test]
        public void NoDataTestMult()
        {
            {
                LaunchForm1();
                ExpectModal(ErrorDialogCaption, "OnModal_DismissMessageBox");
                aBoxTester["Text"] = string.Empty;
                bBoxTester["Text"] = string.Empty;
                MultBtnTester.Click();
            }
        }

        [Test]
        public void IncorrectDataTestAdd()
        {
            {
                LaunchForm1();
                ExpectModal(ErrorDialogCaption, "OnModal_DismissMessageBox");
                aBoxTester["Text"] = "sdf";
                bBoxTester["Text"] = "6";
                AddBtnTester.Click();
            }
        }

        [Test]
        public void IncorrectDataTestMult()
        {
            LaunchForm1();
            ExpectModal(ErrorDialogCaption, "OnModal_DismissMessageBox");
            aBoxTester["Text"] = ((char) 5).ToString();
            bBoxTester["Text"] = ((char) 12).ToString();
            MultBtnTester.Click();

        }
        
        
        private void OnModal_DismissMessageBox()
        {
           var mbt = new MessageBoxTester(ErrorDialogCaption);
           mbt.ClickOk();
        }
    }
}
