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
            //처음에 담기지 않아야함
            if (inputBox.Text != "")
            {
                int number;
                if (int.TryParse(inputBox.Text, out number))
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
                int number;
                //변환되면 number이고 아니면 false
            
                if (int.TryParse(inputBox.Text, out number))
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

                    //연산한 숫자와 연산자 제거
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--; // index 이전으로 옮김
                }
            }

            // Step 2: 나머지 덧셈과 뺄셈 진행
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

            // ,000
            resultBox.Text = finalResult.ToString("N0");
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

        private void reverse_Click(object sender, EventArgs e)
        {
            double a = double.Parse(inputBox.Text);
            inputBox.Clear();
            a = -a;
            inputBox.Text += a.ToString();
        }
    }
}