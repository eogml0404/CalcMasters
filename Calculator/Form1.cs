using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Calcul : Form
    {
        public Calcul()
        {
            InitializeComponent();
        }

        List<double> numbers = new List<double>();
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

        private void remainder_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("%");
        }

        private void AddNumberAndOperator(string op)
        {
            history[j] += op;

            if (inputBox.Text != "")
            {
                double number;
                if (double.TryParse(inputBox.Text, out number))
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
                double number;
                //변환되면 number이고 아니면 false
            
                if (double.TryParse(inputBox.Text, out number))
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
            // Step 1: 곱셈, 나눗셈 찾아서 먼저 계산
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == "*" || operators[i] == "/" || operators[i] == "%")
                {
                    double rhs = numbers[i + 1];
                    double lhs = numbers[i];
                    double result;

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
                        else
                        {
                            if (operators[i] == "/")
                            {
                                result = lhs / rhs;
                            }
                            else
                            {
                                result = lhs % rhs;
                            }
                        }
                    }

                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                   
                    i--;
                }
            }

            // Step 2: 나머지 덧셈과 뺄셈 진행
            double finalResult = numbers[0];
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
            if (finalResult % 1 == 0)
            {
                resultBox.Text = finalResult.ToString("N0");
            }
            else
            {
                resultBox.Text += finalResult.ToString("N2");
            }
            history[j] += finalResult.ToString("N2");
            
            formulaBox.Text += " = " + finalResult.ToString("N2");
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

        private void button0_Click(object sender, EventArgs e)
        {
            AppendToInputBox("0");
        }

        private void ACBtn_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            resultBox.Text = "";
            numbers.Clear();
            operators.Clear();
        }

        private void erase_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
            }
        }

        //양수, 음수 전환
        private void reverse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputBox.Text))
            {
                AppendToInputBox("-");
            }
            else
            {
                double a = double.Parse(inputBox.Text);
                inputBox.Clear();
                a = -a;
                inputBox.Text += a.ToString("N2");
            }
        }

        
    }
}