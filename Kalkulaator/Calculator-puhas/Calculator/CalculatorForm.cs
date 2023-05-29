using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLib;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorFunc calculatorFunc = new CalculatorFunc();

        private string onlyNumReg = "^[0-9]+$";
        
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculatorFunc.CurrentValue = double.Parse(txtResult.Text);
            calculatorFunc.LastOperator = '+';
            txtResult.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calculatorFunc.CurrentValue = double.Parse(txtResult.Text);
            calculatorFunc.LastOperator = '-';
            txtResult.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculatorFunc.CurrentValue = double.Parse(txtResult.Text);
            calculatorFunc.LastOperator = '*';
            txtResult.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculatorFunc.CurrentValue = double.Parse(txtResult.Text);
            calculatorFunc.LastOperator = '/';
            txtResult.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(calculatorFunc.LastOperator == '+')
            {
                calculatorFunc.Calculate(double.Parse(txtResult.Text), '+');
                txtResult.Text = calculatorFunc.CurrentValue.ToString();
            }
            if (calculatorFunc.LastOperator == '-')
            {
                calculatorFunc.Calculate(double.Parse(txtResult.Text), '-');
                txtResult.Text = calculatorFunc.CurrentValue.ToString();
            }
            if (calculatorFunc.LastOperator == '*')
            {
                calculatorFunc.Calculate(double.Parse(txtResult.Text), '*');
                txtResult.Text = calculatorFunc.CurrentValue.ToString();
            }
            if (calculatorFunc.LastOperator == '/')
            {
                calculatorFunc.Calculate(double.Parse(txtResult.Text), '/');
                txtResult.Text = calculatorFunc.CurrentValue.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculatorFunc.CurrentValue = 0;
            txtResult.Clear();
        }
    }
}