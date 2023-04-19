using System;

namespace CalculatorLib
{
    public class Calculator
    {
        private float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        private float Sub(float num1, float num2)
        {
            return num1 - num2;
        }

        private float Mult(float num1, float num2)
        {
            return num1 * num2;
        }

        private float Div(float num1, float num2)
        {
            return num1 / num2;
        }


        // Võtab vastu nupuvajutusi
        public void KeyPress(char key)
        {

        }

        // Tagastab tulemuse
        public decimal? Result
        {
            get
            {
                return null;
            }
        }
    }
}
