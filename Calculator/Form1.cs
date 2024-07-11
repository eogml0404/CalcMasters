﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculator
{
    public partial class Calcul : Form
    {
        string filepath = "history.txt"; // 상대경로 설정

        //계산 내역을 List에 불러오는 함수
        private void LoadHistory(string filePath)
        {
            try
            {
                historyBox.Items.Clear();
                historyBox.Items.Add("-계산내역-");
                string[] lines = File.ReadAllLines(filePath);
                historyBox.Items.AddRange(lines); // historyBox에 텍스트 추가

                // historyBox 항목 클릭 이벤트 핸들러 추가
                historyBox.SelectedIndexChanged += HistoryBox_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"계산 내역을 불러오는 중 오류가 발생했습니다: {ex.Message}");
            }
        }

        //List에서 인덱스가 바뀌면 실행되는 함수
        private void HistoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 항목의 인덱스 확인
            int selectedIndex = historyBox.SelectedIndex;

            // 인덱스가 유효한지 확인하고, "-계산내역-"이 아닌 경우에만 linkBox.Text에 설정
            if (selectedIndex >= 1 && selectedIndex < historyBox.Items.Count)
            {
                linkBox.Text = historyBox.Items[selectedIndex].ToString();
                linkBox.Text = linkBox.Text.Substring(2);
            }
        }
        public Calcul()
        {
            InitializeComponent();

            if (File.Exists(filepath))
            {
                // 파일의 모든 라인을 읽고 하나의 문자열로 결합
                // ReadAllLine는 문자열 배열을 반환함
                LoadHistory(filepath);

            }
        }
        
        List<double> numbers = new List<double>();
        List<string> operators = new List<string>();
        bool calculationCompleted = false;
        string[] history = { "", "", "", "", "" };
        List<double> results = new List<double>();
        bool isGraphVisible = true;

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

                        CalculateResult();

                    }
                }
                calculationCompleted = true;
                j++;
            }

            //텍스트 파일에 내역 입력

            string value = formulaBox.Text;
            //경로가 입력되어있으면 
            // 파일이 존재하면 기존 내용 읽어오기
            int index = 1;
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);
                index = lines.Length + 1;
            }

            // 추가할 텍스트를 생성
            string newText = $"{index}. {value}";

            if (filepath.Length > 0)
            {
                // 파일에 내용을 추가
                File.AppendAllText(filepath, newText + Environment.NewLine);
            }


        }

        // 계산하는 함수 operators 리스트 돌면서 계산 
        private void CalculateResult()
        {
            bool isError = false; // 오류 플래그 추가
            // Step 1: 곱셈, 나눗셈, 나머지 찾아서 먼저 계산
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == "*" || operators[i] == "/" || operators[i] == "%")
                {
                    double rhs = numbers[i + 1];
                    double lhs = numbers[i];
                    double result = 0;
                    

                    if (operators[i] == "*")
                    {
                        result = lhs * rhs;
                    }
                    else if (operators[i] == "/")
                    {
                        if (rhs == 0)
                        {
                            MessageBox.Show("Division By Zero!", "Error");
                            isError = true; // 오류 발생 시 플래그 설정
                        }
                        else
                        {
                            result = lhs / rhs;
                        }
                    }
                    else if (operators[i] == "%")
                    {
                        if (rhs == 0)
                        {
                            MessageBox.Show("Division By Zero!", "Error");
                            isError = true; // 오류 발생 시 플래그 설정
                        }
                        else
                        {
                            result = lhs % rhs;
                        }
                    }

                    if (!isError) // 오류가 없을 때만 리스트 수정
                    {
                        numbers[i] = result;
                        numbers.RemoveAt(i + 1);
                        operators.RemoveAt(i);
                        i--; // 리스트의 변경을 반영하기 위해 인덱스를 줄임
                    }

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
            if (!isError)
            {
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
            }
            else
            {
                j--;
            }
           

            inputBox.Text = "";
            numbers.Clear();
            operators.Clear();
            results.Add(finalResult);
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

            message = string.Join(Environment.NewLine, history);
            

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
        //소수점 버튼
        private void dot_Click(object sender, EventArgs e)
        {
                        //계산이 완료된후 숫자를 누르면 초기화 되게함
            if (calculationCompleted)
            {
                formulaBox.Text = "";
                resultBox.Text = "";
                calculationCompleted = false;
            }

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

        //History Clear 버튼
        private void HCBtn_Click(object sender, EventArgs e)
        {
            //경로가 입력되어있으면 
            if (filepath.Length > 0)
            {
                //File에 내용을 입력
                File.WriteAllText(filepath, "");
            }

            historyBox.Items.Clear();
            MessageBox.Show("history가 모두 삭제 되었습니다.");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            historyBox.Visible = false;
            closeBtn.Visible = false;
            linkBox.Visible = false;
            callBtn.Visible = false;
        }

        private void everyBtn_Click(object sender, EventArgs e)
        {
            historyBox.Visible = true;
            closeBtn.Visible = true;
            linkBox.Visible = true;
            callBtn.Visible = true;
            LoadHistory(filepath);
        }

        //그래프 출력 함수
        private void graph_Click(object sender, EventArgs e)
        {
            stick_chart.Titles.Clear();
            stick_chart.Titles.Add("계산 결과 \r\n (계산기를 종료하면 초기화 됩니다.)");
            if (!isGraphVisible)
            {
                // 그래프가 보이지 않는 경우
                ShowGraph();
            }
            else
            {
                // 그래프가 보이는 경우
                HideGraph();
            }
        }

        private void ShowGraph()
        {
            
            stick_chart.Series["계산 결과"].ChartType = SeriesChartType.Line; // 그래프를 라인으로 출력
            // 그래프를 보이게 설정
            stick_chart.Visible = true;
            stick_chart.Series[0].Points.Clear(); // 시리즈 초기화 (새로 그리기 위해)

            // results 리스트의 각 값들을 그래프에 추가
            for (int i = 0; i < results.Count; i++)
            {
                stick_chart.Series[0].Points.Add(results[i]);
            }

            isGraphVisible = true; // 그래프 표시 상태 업데이트

            // 기타 필요한 처리 추가
            if (historyBox.Visible)
            {
                historyBox.Visible = false;
            }
        }

        private void HideGraph()
        {
            // 그래프를 숨기기
            stick_chart.Visible = false;
            isGraphVisible = false; // 그래프 표시 상태 업데이트
        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            formulaBox.Text = linkBox.Text;
        }
    }

}