using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesForm
{
    public partial class Form1 : Form
    {
        private string _chosenCalculation;
        private double _result;
        private double _firstNum;
        private double _secondNum;
        private Func<double, double, double> PerformCalculation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            _firstNum = double.Parse(firstInput.Text);
            _secondNum = double.Parse(secondInput.Text);
            _chosenCalculation = Calculations.Text;
            CalculationChoise();
            resultLabel.Text = "" + _result;
        }

        private void CalculationChoise()
        {
            switch (_chosenCalculation)
            {
                case "Add":
                    PerformCalculation = Add;
                    break;
                case "Subtract":
                    PerformCalculation= Subtract;
                    break;
                case "Multiply":
                    PerformCalculation = Multiply;
                    break;
                case "Divide":
                    PerformCalculation = Divide;
                    break;
                case "Power":
                    PerformCalculation = Power;
                    break;
                case "Root":
                    PerformCalculation = Root;
                    break;
            }

            if (PerformCalculation != null)
            {
                _result = PerformCalculation.Invoke(_firstNum, _secondNum);
            }
        }

        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        public double Power(double num1, double num2)
        {
            double result = Math.Pow (num1, num2);
            return result;
        }
        public double Root(double num1, double num2)
        {
            double result = Math.Sqrt(num1 * num2);
            return result;
        }
    }
}
