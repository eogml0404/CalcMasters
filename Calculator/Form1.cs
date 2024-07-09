using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calcul : Form
    {
        public Calcul()
        {
            InitializeComponent();
        }

        List<int> numbers = new List<int>();
        List<string> operators = new List<string>();
        bool calculationCompleted = false;

        string[] history = { "", "", "", "", "" };

        int j = 0;

        private void minus_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("-");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("+");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("*");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("/");
        }

        private void AddNumberAndOperator(string op)
        {
            history[j] += op;

            if (inputBox.Text != "")
            {
                int number;
                if (int.TryParse(inputBox.Text, out number))
                {
                    numbers.Add(number);
                    operators.Add(op);
                    formulaBox.Text += " "+ op + " ";
                    inputBox.Text = "";
                }

            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (j >= 5)
            {
                for (int i = 1; i < history.Length; i++)
                {
                    history[i - 1] = history[i];
                }
                history[4] = "";
                j = 4;
            }

            if (inputBox.Text != "")
            {
                int number;
                if (int.TryParse(inputBox.Text, out number))
                {
                    numbers.Add(number);
                    history[j] += "=";
                    CalculateResult();
                }
            }
            calculationCompleted = true;
            j++;
            
        }

        private void CalculateResult()
        {
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == "*" || operators[i] == "/")
                {
                    int lhs = numbers[i];
                    int rhs = numbers[i + 1];
                    int result;

                    if (operators[i] == "*")
                    {
                        result = lhs * rhs;
                    }
                    else
                    {
                        if (rhs == 0)
                        {
                            resultBox.Text = "Error: Division by zero!";
                            return;
                        }
                        result = lhs / rhs;
                    }

                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                   
                    i--;
                }
            }

            int finalResult = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i])
                {
                    case "+":
                        finalResult += numbers[i + 1];
                        break;
                    case "-":
                        finalResult -= numbers[i + 1];
                        break;
                }
            }

            resultBox.Text = finalResult.ToString("N0");
            history[j] += finalResult.ToString("N0");
            
            formulaBox.Text += " = " + finalResult;
            inputBox.Text = "";
            numbers.Clear();
            operators.Clear();
        }

        private void AppendToInputBox(string value)
        {
            if (calculationCompleted)
            {
                formulaBox.Text = "";
                resultBox.Text = "";
                calculationCompleted = false;
            }
            if (j >= 5)
            {
                for (int i = 1; i < history.Length; i++)
                {
                    history[i - 1] = history[i];
                }
                history[4] = "";
                j = 4;
            }
            inputBox.Text += value;
            history[j] += value;
            formulaBox.Text += value;
        }
        private void ACBtn_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            resultBox.Text = "";
            formulaBox.Text = "";
            numbers.Clear();
            operators.Clear();
            Array.Clear(history, 0, history.Length);
            j = 0;
        }

        private void erase_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
            }
        }

        private void his_Click(object sender, EventArgs e)
        {
            string message = string.Join(Environment.NewLine, history);
            MessageBox.Show(message + "\r\n");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AppendToInputBox("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendToInputBox("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendToInputBox("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendToInputBox("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToInputBox("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendToInputBox("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendToInputBox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendToInputBox("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendToInputBox("9");
        }

        


    }
}