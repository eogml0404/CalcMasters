using System;
using System.Collections.Generic;
using System.Linq;
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

        //부호 클릭시 실행 -> 입력 숫자와 연산자가 리스트에 담긴다.
        private void AddNumberAndOperator(string op)
        {

            double number;
            if (double.TryParse(inputBox.Text, out number))
            {

                // 새로운 연산자를 추가한다
                numbers.Add(number);
                operators.Add(op);
                formulaBox.Text += " " + op + " ";
                inputBox.Text = "";

            }

            //연산자 두번 들어가지 않게 설정
            if (operators.Count > 0 && (numbers.Count == operators.Count))
            {

                // 마지막 연산자를 바꾼다
                operators[operators.Count - 1] = op;
                // 수식 상자에서 마지막 연산자를 바꾼다
                formulaBox.Text = formulaBox.Text.Substring(0, formulaBox.Text.Length - 2) + op + " ";
            }
        }

        // = 버튼 클릭시 실행 -> history가 5개 이상일시 가장 오래된것을 지운다.
        private void execute_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
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
            
        }

        // 계산하는 함수 operators 리스트 돌면서 계산 
        private void CalculateResult()
        {
            // Step 1: 곱셈, 나눗셈, 나머지 찾아서 먼저 계산
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
                            inputBox.Text = "Error: Division by zero!";
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

            // Step 2:  덧셈과 뺄셈 진행
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
                        
            formulaBox.Text += " = " + finalResult.ToString("N2");
      
            //내역에 저장
            history[j] = formulaBox.Text;

            inputBox.Text = "";
            numbers.Clear();
            operators.Clear();
        }

        //숫자 입력 함수
        private void AppendToInputBox(string value)
        {
            //계산이 완료된후 숫자를 누르면 초기화 되게함
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
            formulaBox.Text += value;
        }
        private void ACBtn_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            resultBox.Text = "";
            formulaBox.Text = "";
            numbers.Clear();
            operators.Clear();
        }

        private void erase_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);

                formulaBox.Text = formulaBox.Text.Substring(0, formulaBox.Text.Length - 1);

            }
        }

        private void his_Click(object sender, EventArgs e)
        {
            string message = "";

            if (formulaBox.Text.Contains("="))
            {
                message = string.Join(Environment.NewLine, history);
            }

            MessageBox.Show(message + "\r\n" , "계산 내역 (최대 5개)");

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



        //양수, 음수 전환
        private void reverse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputBox.Text))
            {
                AppendToInputBox("-");
            }
            else
            {
                //StringSplitOptions.RemoveEmptyEntries => 빈 항목을 제거
                string[] inputParts = inputBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] formulaParts = formulaBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

               
                //마지막 부분이 숫자면 실행
                if (double.TryParse(inputParts.Last(), out double lastNumber) && double.TryParse(formulaParts.Last(), out double lastFormulaNumber))
                {
                   
                    lastNumber = -lastNumber;
                    lastFormulaNumber = -lastFormulaNumber;

                    inputParts[inputParts.Length - 1] = lastNumber.ToString("N0");
                    formulaParts[formulaParts.Length - 1] = lastFormulaNumber.ToString("N0");

                    // 박스에 숫자 추가
                    inputBox.Text = string.Join(" ", inputParts);
                    formulaBox.Text = string.Join(" ", formulaParts);
                }
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {

            if (inputBox.Text.Contains("."))
            {
                return;
            }
            else if(inputBox.Text == "")
            {
                inputBox.Text += 0.ToString() + ".";
                formulaBox.Text +=0.ToString() + ".";
            }
            else 
            {
                inputBox.Text += ".";
                formulaBox.Text += ".";
            } 
        }

    }

}