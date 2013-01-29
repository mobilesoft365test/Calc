using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BoxResult.Text = Operations.Add(Convert.ToInt32(BoxA.Text), Convert.ToInt32(BoxB.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check input data: must be integer values only!", "Input data error!");
                BoxResult.Text = "";
            }

        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BoxResult.Text = Operations.Mult(Convert.ToInt32(BoxA.Text), Convert.ToInt32(BoxB.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check input data: must be integer values only!", "Input data error!");
                BoxResult.Text = "";
            }

        }

        private void BoxAFocus(object sender, EventArgs e)
        {
            BoxA.Text = "";
        }

        private void BoxBFocus(object sender, EventArgs e)
        {
            BoxB.Text = "";
        }


    }
}
