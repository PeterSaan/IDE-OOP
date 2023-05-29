using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLib;

namespace Interface
{
    public partial class Form1 : Form
    {
        public double? result;
        public string operand;
        public double? number1;
        public double? number2;
        public Form1()
        {
            InitializeComponent();
        }
        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            number1 = null;
            number2 = null;
            result = null;
        }

        private void period_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if(textBox2 != null)
            {
                textBox2.Text = string.Empty;
            }
            number1 = double.Parse(textBox1.Text);
            operand = "-";
            textBox2.Text += $"{number1} - ";
            textBox1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (textBox2 != null)
            {
                textBox2.Text = string.Empty;
            }
            number1 = double.Parse(textBox1.Text);
            operand = "/";
            textBox2.Text += $"{number1} / ";
            textBox1.Clear();
        }

        private void equals_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty && number1 != null)
            {
                number2 = double.Parse(textBox1.Text);
            }

            switch (operand)
            {
                case "+":
                    result = number1 + number2;
                    textBox2.Text += number2.ToString() + " =";
                    break;
                case "-":
                    result = number1 - number2;
                    textBox2.Text += number2.ToString() + " =";
                    break;
                case "/":
                    result = number1 / number2;
                    textBox2.Text += number2.ToString() + " =";
                    break;
                case "*":
                    result = number1 * number2;
                    textBox2.Text += number2.ToString() + " =";
                    break;
            }

            textBox1.Text = result.ToString();
        }


        private void multiply_Click(object sender, EventArgs e)
        {
            if (textBox2 != null)
            {
                textBox2.Text = string.Empty;
            }
            number1 = double.Parse(textBox1.Text);
            operand = "*";
            textBox2.Text += $"{number1} * ";
            textBox1.Clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2 != null)
            {
                textBox2.Text = string.Empty;
            }
            number1 = double.Parse(textBox1.Text);
            operand = "+";
            textBox2.Text += $"{number1} + ";
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-1 * double.Parse(textBox1.Text)).ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
