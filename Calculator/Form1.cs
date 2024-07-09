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

        List<double> numbers = new List<double>();
        List<string> operators = new List<string>();
     

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
            //처음에 담기지 않아야함
            if (inputBox.Text != "")
            {
                double number;
                if (double.TryParse(inputBox.Text, out number))
                {
                    numbers.Add(number);
                    operators.Add(op);
                    inputBox.Text = "";
                }

            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (inputBox.Text != "")
            {
                double number;
                //변환되면 number이고 아니면 false
            
                if (double.TryParse(inputBox.Text, out number))
                {
                    numbers.Add(number);
                    CalculateResult();
                }


            }
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

                    //연산한 숫자와 연산자 제거
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--; // index 이전으로 옮김
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

            // ,000
            resultBox.Text = finalResult.ToString();
            inputBox.Text = "";
            numbers.Clear();
            operators.Clear();

        }

        //숫자 입력
        private void AppendToInputBox(string value)
        {
            inputBox.Text += value;
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
            double a = double.Parse(inputBox.Text);
            inputBox.Clear();
            a = -a;
            inputBox.Text += a.ToString();
        }

        
    }
}