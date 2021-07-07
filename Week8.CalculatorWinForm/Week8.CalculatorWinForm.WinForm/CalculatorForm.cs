using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week8.CalculatorWinForm.Core;

namespace Week8.CalculatorWinForm.WinForm
{
    public partial class CalculatorForm : Form
    {
        private double valueA;
        private double valueB;
        private string operation;
        private Calculator calculator = new Calculator();
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnZero.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtValue.Text += btnNine.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, "sum");
        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            txtValue.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            valueB = (string.IsNullOrEmpty(txtValue.Text)) ? 0 : double.Parse(txtValue.Text);
            switch (operation)
            {
                case "sum":                   
                    txtValue.Text = calculator.Sum(valueA, valueB).ToString();
                    break;
                case "subtract":
                    txtValue.Text = calculator.Subtract(valueA, valueB).ToString();
                    break;
                case "multiply":
                    txtValue.Text = calculator.Multiply(valueA, valueB).ToString();
                    break;
                case "division":
                    var result = calculator.Divide(valueA, valueB);
                    txtValue.Text = (result == null) ? "Error" : result.ToString();
                    break;
                default:
                    txtValue.Text = "Error";
                    break;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, "subtract");
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, "multiply");
        }

        private void btnSlash_Click(object sender, EventArgs e)
        {
            SetOperation(txtValue.Text, "division");
        }
    }
}
