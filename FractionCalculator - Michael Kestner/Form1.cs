using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FractionCalculator___Michael_Kestner
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void firstNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            string errorMsg = string.Empty;
            string outputString = string.Empty;
            int firstNum = 0;
            int secondNum = 0;
            int firstDenom = 0;
            int secondDenom = 0;
            Fraction thirdFrac = new Fraction();
            int outNum = 0;
            int outDenom = 0;


            if(!int.TryParse(firstNumBox.Text, out firstNum))//validation for first numerator
            {
                errorMsg += "First fraction numerator must be an integer!";


            }
            else if(firstNum ==0)
            {
                errorMsg += "First fraction numerator can not be zero!\n";
            }//end first numerator validation
            if(!int.TryParse(firstDenomBox.Text, out firstDenom))//first denominator validation
            {
                errorMsg += "First fraction denominator must be an integer!\n";
            }
            else if (firstDenom == 0)
            {
                errorMsg += "First fraction denominator can not be zero!\n";
            }//end first denominator validation
            if (!int.TryParse(secondNumBox.Text, out secondNum))//second numerator validation
            {
                errorMsg += "Second fraction numerator must be an integer!\n";
            }
            else if (secondNum == 0)
            {
                errorMsg += "First fraction numerator can not be zero!\n";
            }//end second numerator validation
            if (!int.TryParse(secondDenomBox.Text, out secondDenom))//second denominator validation
            {
                errorMsg += "Second fraction denominator must be an integer!\n";
            }
            else if (secondDenom == 0)
            {
                errorMsg += "First fraction denominator can not be zero!\n";
            }//end second denominator validation

            if(errorMsg!=string.Empty)//display any validation errors that occurred
            {
                MessageBox.Show(errorMsg, "One or More Validation Errors Have Occurred",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNumBox.Focus();
                return;
            }//end error box

            Fraction firstFrac = new Fraction(firstNum, firstDenom);
            Fraction secondFrac = new Fraction(secondNum, secondDenom);
            if(operationComboBox.SelectedIndex == 1)
            {
                thirdFrac = firstFrac.Add(secondFrac);
                 

            }
            else  if(operationComboBox.SelectedIndex == 2)
            {
                thirdFrac = firstFrac.Subtract(secondFrac);
            }
            else if (operationComboBox.SelectedIndex == 3)
            {
                thirdFrac = firstFrac.Multiply(secondFrac);
            }
            else
            {
                thirdFrac = firstFrac.Divide(secondFrac);
            }

            //start output
            //Assign the third fractions numerator and denominator to int variables
            outNum = thirdFrac.Numerator;
            outDenom = thirdFrac.Denominator;

            outNumLabel.Text = outNum.ToString();
            outDenomLabel.Text = outDenom.ToString();
            outFloatStringLabel.Text = thirdFrac.ToFloatString(3);
        }

        private void operationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
