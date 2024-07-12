using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    partial class Calcul
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.execute = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.ACBtn = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.remainder = new System.Windows.Forms.Button();
            this.his = new System.Windows.Forms.Button();
            this.formulaBox = new System.Windows.Forms.TextBox();
            this.dot = new System.Windows.Forms.Button();
            this.binaryRadioButton = new System.Windows.Forms.RadioButton();
            this.decimalRadioButton = new System.Windows.Forms.RadioButton();
            this.hexRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateDifferenceBox = new System.Windows.Forms.TextBox();
            this.HCBtn = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.ListBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.everyBtn = new System.Windows.Forms.Button();
            this.stick_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.callBtn = new System.Windows.Forms.Button();
            this.printGraph = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stick_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.White;
            this.inputBox.Font = new System.Drawing.Font("굴림", 14F);
            this.inputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(132)))), ((int)(((byte)(138)))));
            this.inputBox.Location = new System.Drawing.Point(99, 142);
            this.inputBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(850, 125);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button1.Location = new System.Drawing.Point(99, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button2.Location = new System.Drawing.Point(280, 490);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 89);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button3.Location = new System.Drawing.Point(468, 490);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 89);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button4.Location = new System.Drawing.Point(99, 616);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 89);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button5.Location = new System.Drawing.Point(280, 616);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 89);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button6.Location = new System.Drawing.Point(468, 616);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 89);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button7.Location = new System.Drawing.Point(99, 747);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 89);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button8.Location = new System.Drawing.Point(280, 747);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 89);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button9.FlatAppearance.BorderSize = 3;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button9.Location = new System.Drawing.Point(468, 747);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 89);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // plus
            // 
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.plus.FlatAppearance.BorderSize = 3;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.plus.Location = new System.Drawing.Point(674, 747);
            this.plus.Margin = new System.Windows.Forms.Padding(2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(94, 89);
            this.plus.TabIndex = 10;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.minus.FlatAppearance.BorderSize = 3;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.minus.Location = new System.Drawing.Point(674, 616);
            this.minus.Margin = new System.Windows.Forms.Padding(2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(94, 89);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.execute.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.execute.ForeColor = System.Drawing.Color.White;
            this.execute.Location = new System.Drawing.Point(674, 875);
            this.execute.Margin = new System.Windows.Forms.Padding(2);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(275, 89);
            this.execute.TabIndex = 12;
            this.execute.Text = "=";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.White;
            this.resultBox.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.resultBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.resultBox.Location = new System.Drawing.Point(674, 366);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(239, 28);
            this.resultBox.TabIndex = 13;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ACBtn
            // 
            this.ACBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.ACBtn.FlatAppearance.BorderSize = 3;
            this.ACBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(132)))), ((int)(((byte)(138)))));
            this.ACBtn.Location = new System.Drawing.Point(99, 299);
            this.ACBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ACBtn.Name = "ACBtn";
            this.ACBtn.Size = new System.Drawing.Size(155, 64);
            this.ACBtn.TabIndex = 14;
            this.ACBtn.Text = "AC";
            this.ACBtn.UseVisualStyleBackColor = true;
            this.ACBtn.Click += new System.EventHandler(this.ACBtn_Click);
            // 
            // erase
            // 
            this.erase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.erase.FlatAppearance.BorderSize = 3;
            this.erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erase.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.erase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.erase.Location = new System.Drawing.Point(674, 490);
            this.erase.Margin = new System.Windows.Forms.Padding(2);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(94, 89);
            this.erase.TabIndex = 15;
            this.erase.Text = "<<";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button10.FlatAppearance.BorderSize = 3;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button10.Location = new System.Drawing.Point(855, 490);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 89);
            this.button10.TabIndex = 16;
            this.button10.Text = "x";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.multiply_Click);
            // 
            // div
            // 
            this.div.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.div.FlatAppearance.BorderSize = 3;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.div.Location = new System.Drawing.Point(855, 616);
            this.div.Margin = new System.Windows.Forms.Padding(2);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(94, 89);
            this.div.TabIndex = 17;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.divide_Click);
            // 
            // reverse
            // 
            this.reverse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.reverse.FlatAppearance.BorderSize = 3;
            this.reverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reverse.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.reverse.Location = new System.Drawing.Point(99, 875);
            this.reverse.Margin = new System.Windows.Forms.Padding(2);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(94, 89);
            this.reverse.TabIndex = 18;
            this.reverse.Text = "+/-";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // button0
            // 
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button0.FlatAppearance.BorderSize = 3;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.button0.Location = new System.Drawing.Point(280, 875);
            this.button0.Margin = new System.Windows.Forms.Padding(5);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(94, 89);
            this.button0.TabIndex = 19;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // remainder
            // 
            this.remainder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.remainder.FlatAppearance.BorderSize = 3;
            this.remainder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remainder.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.remainder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.remainder.Location = new System.Drawing.Point(855, 747);
            this.remainder.Margin = new System.Windows.Forms.Padding(5);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(94, 89);
            this.remainder.TabIndex = 20;
            this.remainder.Text = "%";
            this.remainder.UseVisualStyleBackColor = true;
            this.remainder.Click += new System.EventHandler(this.remainder_Click);
            // 
            // his
            // 
            this.his.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.his.FlatAppearance.BorderSize = 3;
            this.his.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.his.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.his.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(132)))), ((int)(((byte)(138)))));
            this.his.Location = new System.Drawing.Point(326, 299);
            this.his.Margin = new System.Windows.Forms.Padding(2);
            this.his.Name = "his";
            this.his.Size = new System.Drawing.Size(208, 64);
            this.his.TabIndex = 19;
            this.his.Text = "history";
            this.his.UseVisualStyleBackColor = true;
            this.his.Click += new System.EventHandler(this.his_Click);
            // 
            // formulaBox
            // 
            this.formulaBox.BackColor = System.Drawing.Color.White;
            this.formulaBox.Font = new System.Drawing.Font("굴림", 16F);
            this.formulaBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(132)))), ((int)(((byte)(138)))));
            this.formulaBox.Location = new System.Drawing.Point(99, 42);
            this.formulaBox.Margin = new System.Windows.Forms.Padding(5);
            this.formulaBox.Name = "formulaBox";
            this.formulaBox.ReadOnly = true;
            this.formulaBox.Size = new System.Drawing.Size(850, 44);
            this.formulaBox.TabIndex = 20;
            this.formulaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dot
            // 
            this.dot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.dot.FlatAppearance.BorderSize = 3;
            this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.dot.Location = new System.Drawing.Point(468, 875);
            this.dot.Margin = new System.Windows.Forms.Padding(4);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(94, 89);
            this.dot.TabIndex = 21;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // binaryRadioButton
            // 
            this.binaryRadioButton.AutoSize = true;
            this.binaryRadioButton.Location = new System.Drawing.Point(16, 28);
            this.binaryRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.binaryRadioButton.Name = "binaryRadioButton";
            this.binaryRadioButton.Size = new System.Drawing.Size(83, 29);
            this.binaryRadioButton.TabIndex = 22;
            this.binaryRadioButton.TabStop = true;
            this.binaryRadioButton.Text = "2진수";
            this.binaryRadioButton.UseVisualStyleBackColor = true;
            this.binaryRadioButton.CheckedChanged += new System.EventHandler(this.binaryRadioButton_CheckedChanged);
            // 
            // decimalRadioButton
            // 
            this.decimalRadioButton.AutoSize = true;
            this.decimalRadioButton.Location = new System.Drawing.Point(106, 28);
            this.decimalRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.decimalRadioButton.Name = "decimalRadioButton";
            this.decimalRadioButton.Size = new System.Drawing.Size(93, 29);
            this.decimalRadioButton.TabIndex = 23;
            this.decimalRadioButton.TabStop = true;
            this.decimalRadioButton.Text = "10진수";
            this.decimalRadioButton.UseVisualStyleBackColor = true;
            this.decimalRadioButton.CheckedChanged += new System.EventHandler(this.decimalRadioButton_CheckedChanged);
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.AutoSize = true;
            this.hexRadioButton.Location = new System.Drawing.Point(199, 28);
            this.hexRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(93, 29);
            this.hexRadioButton.TabIndex = 24;
            this.hexRadioButton.TabStop = true;
            this.hexRadioButton.Text = "16진수";
            this.hexRadioButton.UseVisualStyleBackColor = true;
            this.hexRadioButton.CheckedChanged += new System.EventHandler(this.hexRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.binaryRadioButton);
            this.groupBox1.Controls.Add(this.hexRadioButton);
            this.groupBox1.Controls.Add(this.decimalRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(132)))), ((int)(((byte)(138)))));
            this.groupBox1.Location = new System.Drawing.Point(1007, 366);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(309, 58);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "진수변환";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(132)))), ((int)(((byte)(138)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1023, 674);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(380, 31);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateDifferenceBox
            // 
            this.dateDifferenceBox.Location = new System.Drawing.Point(1023, 743);
            this.dateDifferenceBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateDifferenceBox.Name = "dateDifferenceBox";
            this.dateDifferenceBox.Size = new System.Drawing.Size(380, 28);
            this.dateDifferenceBox.TabIndex = 27;
            // 
            // HCBtn
            // 
            this.HCBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.HCBtn.FlatAppearance.BorderSize = 3;
            this.HCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HCBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HCBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(132)))), ((int)(((byte)(138)))));
            this.HCBtn.Location = new System.Drawing.Point(99, 394);
            this.HCBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HCBtn.Name = "HCBtn";
            this.HCBtn.Size = new System.Drawing.Size(194, 76);
            this.HCBtn.TabIndex = 22;
            this.HCBtn.Text = "HC";
            this.HCBtn.UseVisualStyleBackColor = true;
            this.HCBtn.Click += new System.EventHandler(this.HCBtn_Click);
            // 
            // historyBox
            // 
            this.historyBox.BackColor = System.Drawing.SystemColors.Info;
            this.historyBox.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.historyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.historyBox.FormattingEnabled = true;
            this.historyBox.HorizontalScrollbar = true;
            this.historyBox.ItemHeight = 38;
            this.historyBox.Items.AddRange(new object[] {
            "-계산 내역-"});
            this.historyBox.Location = new System.Drawing.Point(185, 218);
            this.historyBox.Margin = new System.Windows.Forms.Padding(4);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(728, 802);
            this.historyBox.TabIndex = 23;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.closeBtn.Location = new System.Drawing.Point(842, 240);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(55, 53);
            this.closeBtn.TabIndex = 24;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // everyBtn
            // 
            this.everyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(152)))));
            this.everyBtn.FlatAppearance.BorderSize = 3;
            this.everyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.everyBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.everyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(132)))), ((int)(((byte)(138)))));
            this.everyBtn.Location = new System.Drawing.Point(326, 394);
            this.everyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.everyBtn.Name = "everyBtn";
            this.everyBtn.Size = new System.Drawing.Size(259, 76);
            this.everyBtn.TabIndex = 25;
            this.everyBtn.Text = "every history";
            this.everyBtn.UseVisualStyleBackColor = true;
            this.everyBtn.Click += new System.EventHandler(this.everyBtn_Click);
            // 
            // stick_chart
            // 
            this.stick_chart.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.stick_chart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin3;
            chartArea4.Name = "ChartArea1";
            this.stick_chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.stick_chart.Legends.Add(legend4);
            this.stick_chart.Location = new System.Drawing.Point(217, 366);
            this.stick_chart.Margin = new System.Windows.Forms.Padding(4);
            this.stick_chart.Name = "stick_chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "계산 결과";
            dataPoint4.IsEmpty = true;
            series4.Points.Add(dataPoint4);
            this.stick_chart.Series.Add(series4);
            this.stick_chart.Size = new System.Drawing.Size(798, 530);
            this.stick_chart.TabIndex = 26;
            this.stick_chart.Text = "chart1";
            title4.Name = "계산 내역";
            this.stick_chart.Titles.Add(title4);
            this.stick_chart.Visible = false;
            // 
            // linkBox
            // 
            this.linkBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.linkBox.Location = new System.Drawing.Point(308, 962);
            this.linkBox.Margin = new System.Windows.Forms.Padding(4);
            this.linkBox.Name = "linkBox";
            this.linkBox.ReadOnly = true;
            this.linkBox.Size = new System.Drawing.Size(373, 28);
            this.linkBox.TabIndex = 28;
            // 
            // callBtn
            // 
            this.callBtn.BackColor = System.Drawing.Color.White;
            this.callBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.callBtn.Location = new System.Drawing.Point(708, 962);
            this.callBtn.Margin = new System.Windows.Forms.Padding(4);
            this.callBtn.Name = "callBtn";
            this.callBtn.Size = new System.Drawing.Size(136, 35);
            this.callBtn.TabIndex = 29;
            this.callBtn.Text = "불러오기";
            this.callBtn.UseVisualStyleBackColor = false;
            this.callBtn.Click += new System.EventHandler(this.callBtn_Click);
            // 
            // printGraph
            // 
            this.printGraph.Image = global::Calculator.Properties.Resources.스크린샷_2024_07_12_103019;
            this.printGraph.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.printGraph.Location = new System.Drawing.Point(1072, 801);
            this.printGraph.Margin = new System.Windows.Forms.Padding(4);
            this.printGraph.Name = "printGraph";
            this.printGraph.Size = new System.Drawing.Size(272, 207);
            this.printGraph.TabIndex = 27;
            this.printGraph.UseVisualStyleBackColor = true;
            this.printGraph.Click += new System.EventHandler(this.graph_Click);
            // 
            // Calcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1438, 1213);
            this.Controls.Add(this.stick_chart);
            this.Controls.Add(this.dateDifferenceBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.callBtn);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.printGraph);
            this.Controls.Add(this.HCBtn);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.formulaBox);
            this.Controls.Add(this.his);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.div);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.ACBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.everyBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calcul";
            this.Text = "계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stick_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button ACBtn;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button his;
        private System.Windows.Forms.TextBox formulaBox;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button remainder;
        private System.Windows.Forms.Button dot;

        private System.Windows.Forms.RadioButton binaryRadioButton;
        private System.Windows.Forms.RadioButton decimalRadioButton;
        private System.Windows.Forms.RadioButton hexRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dateDifferenceBox;

        private System.Windows.Forms.Button HCBtn;
        private System.Windows.Forms.ListBox historyBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button everyBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart stick_chart;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Button callBtn;
        private System.Windows.Forms.Button printGraph;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

