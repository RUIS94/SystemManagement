using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private string userinput = "";
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Text == "=")
                {
                    CalculateResult();
                }
                else if (button.Text == "C")
                {
                    resultBox.Text = "";
                    userinput = "";
                }
                else
                {
                    userinput += button.Text;
                    resultBox.Text = userinput;
                }
            }
        }

        private void CalculateResult()
        {
            try
            {
                string expression = resultBox.Text;
                double result = EvaluateInput(expression);
                result = Math.Round(result, 2);

                resultBox.Text = result.ToString();
                historyBox.AppendText($"{expression} = {result}" + Environment.NewLine);
                expression = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
                resultBox.Text = "";
                userinput = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                resultBox.Text = "";
                userinput = "";
            }
        }

        private double EvaluateInput(string expression)
        {
            List<double> numbers = new List<double>();
            List<char> operators = new List<char>();
            ParseExpression(expression, numbers, operators);
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '*' || operators[i] == '/')
                {
                    double result = 0;

                    if (operators[i] == '*')
                    {
                        result = numbers[i] * numbers[i + 1];
                    }
                    else if (operators[i] == '/')
                    {
                        if (numbers[i + 1] == 0)
                        {
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        result = numbers[i] / numbers[i + 1];
                    }
                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }
            }
            double finalResult = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (operators[i - 1] == '+')
                    finalResult += numbers[i];
                else if (operators[i - 1] == '-')
                    finalResult -= numbers[i];
            }
            return finalResult;
        }

        private void ParseExpression(string expression, List<double> numbers, List<char> operators)
        {
            string currentNumber = "";
            foreach (char c in expression)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    currentNumber += c;
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    if (string.IsNullOrEmpty(currentNumber)) throw new Exception("Error");
                    numbers.Add(double.Parse(currentNumber));
                    operators.Add(c);
                    currentNumber = "";
                }
                else
                {
                    throw new Exception("Error");
                }
            }
            if (!string.IsNullOrEmpty(currentNumber))
            {
                numbers.Add(double.Parse(currentNumber));
            }
            else
            { throw new Exception("Error"); }
        }
    }
}
