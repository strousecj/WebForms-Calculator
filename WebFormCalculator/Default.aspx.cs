using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebFormCalculator
{
    public partial class _Default : Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    txtDisplay.MaxLength = 25;
        //}

        // Called when a number button (0-9) or decimal button is pressed 
        private void NumberButton_Click(string number)
        {
            if (Calculator.StartNewCalculation == true) // if the user has just pressed the equals button, remove previous calculation information
            {
                Calculator.ClearAll();
                Calculator.StartNewCalculation = false;
            }

            txtDisplay.Text = "";
            Calculator.ClearOperand2();
            Calculator.ResetResult();

            if (Calculator.Input == "0") // prevents numbers from displaying with leading zeros
            {
                Calculator.Input = number;
            }
            else
            {
                Calculator.Input += number;
            }
            txtDisplay.Text += Calculator.Input; // update display
        }

        // Called whenever one of the operation buttons is pressed (+,-,*,/)
        private void OperationButton_Click(char op)
        {
            if (Calculator.IsOperand1Blank() && Calculator.Result == 0) // operand needs to have a value before continuing 
            {
                Calculator.Operand1 = Calculator.Input;
            }
            else
            {
                if (!Calculator.IsInputBlank()) // if input is blank, then operand2 will be blank in the upcoming calculation
                {
                    EvaluateExpression();
                }
            }
            Calculator.Operation = op;
            Calculator.ClearOperand2();
            Calculator.ClearInput();
            Calculator.StartNewCalculation = false;
        }

        // called when the equals button is pressed or to evaluate 
        private void EvaluateExpression()
        {
            txtDisplay.Text = "";
            if (!Calculator.IsInputBlank())
            {
                Calculator.Operand2 = Calculator.Input;
            }

            if (Calculator.Operation == '/' && Calculator.Operand2 == "0") // prevent divide by zero problems
            {
                Calculator.ClearAll();
                txtDisplay.Text = "Cannot divide by zero";
            }
            else
            {
                Calculator.Result = Calculator.Calculate(Calculator.Operation, Calculator.Operand1, Calculator.Operand2);
                txtDisplay.Text += Calculator.Result.ToString();
                Calculator.Operand1 = Calculator.Result.ToString();   // so the result can be used for another calculation
                Calculator.ClearInput();
            }
            Calculator.StartNewCalculation = true;
        }



        // Windows Forms Button Region
        protected void btnOne_Click(object sender, EventArgs e)
        {
            NumberButton_Click("1");
        }

        protected void btnTwo_Click(object sender, EventArgs e)
        {
            NumberButton_Click("2");
        }

        protected void btnThree_Click(object sender, EventArgs e)
        {
            NumberButton_Click("3");
        }

        protected void btnFour_Click(object sender, EventArgs e)
        {
            NumberButton_Click("4");
        }

        protected void btnFive_Click(object sender, EventArgs e)
        {
            NumberButton_Click("5");
        }

        protected void btnSix_Click(object sender, EventArgs e)
        {
            NumberButton_Click("6");
        }

        protected void btnSeven_Click(object sender, EventArgs e)
        {
            NumberButton_Click("7");
        }

        protected void btnEight_Click(object sender, EventArgs e)
        {
            NumberButton_Click("8");
        }

        protected void btnNine_Click(object sender, EventArgs e)
        {
            NumberButton_Click("9");
        }

        protected void btnZero_Click(object sender, EventArgs e)
        {
            NumberButton_Click("0");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            OperationButton_Click('+');
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            OperationButton_Click('-');
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            OperationButton_Click('*');
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            OperationButton_Click('/');
        }

        protected void btnEquals_Click(object sender, EventArgs e)
        {
            if (!Calculator.IsOperand1Blank()) // will cause error if there are not 2 values for the calculation
            {
                EvaluateExpression();
            }
        }

        protected void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!Calculator.Input.Contains("."))
            { // prevent multiple decimal points in a number
                NumberButton_Click(".");
            }
        }

        protected void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            Calculator.ClearEntry();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            Calculator.ClearAll();
        }
        // End Form Button Region

    }
}