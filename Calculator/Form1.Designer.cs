﻿using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("굴림", 14F);
            this.inputBox.Location = new System.Drawing.Point(63, 98);
            this.inputBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(560, 88);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(63, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(179, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(299, 340);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 74);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(63, 452);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 74);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(179, 452);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 74);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(299, 452);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 74);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(63, 572);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 74);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(179, 572);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 74);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(299, 572);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 74);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plus.Location = new System.Drawing.Point(431, 572);
            this.plus.Margin = new System.Windows.Forms.Padding(2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 74);
            this.plus.TabIndex = 10;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minus.Location = new System.Drawing.Point(431, 452);
            this.minus.Margin = new System.Windows.Forms.Padding(2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 74);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.execute.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.execute.ForeColor = System.Drawing.Color.White;
            this.execute.Location = new System.Drawing.Point(432, 650);
            this.execute.Margin = new System.Windows.Forms.Padding(2);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(191, 74);
            this.execute.TabIndex = 12;
            this.execute.Text = "=";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.White;
            this.resultBox.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.resultBox.ForeColor = System.Drawing.Color.Red;
            this.resultBox.Location = new System.Drawing.Point(431, 247);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(192, 24);
            this.resultBox.TabIndex = 13;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ACBtn
            // 
            this.ACBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACBtn.Location = new System.Drawing.Point(63, 229);
            this.ACBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ACBtn.Name = "ACBtn";
            this.ACBtn.Size = new System.Drawing.Size(124, 53);
            this.ACBtn.TabIndex = 14;
            this.ACBtn.Text = "AC";
            this.ACBtn.UseVisualStyleBackColor = true;
            this.ACBtn.Click += new System.EventHandler(this.ACBtn_Click);
            // 
            // erase
            // 
            this.erase.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.erase.Location = new System.Drawing.Point(431, 340);
            this.erase.Margin = new System.Windows.Forms.Padding(2);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(75, 74);
            this.erase.TabIndex = 15;
            this.erase.Text = "<<";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(547, 340);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 74);
            this.button10.TabIndex = 16;
            this.button10.Text = "x";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.multiply_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.div.Location = new System.Drawing.Point(547, 452);
            this.div.Margin = new System.Windows.Forms.Padding(2);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 74);
            this.div.TabIndex = 17;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.divide_Click);
            // 
            // reverse
            // 
            this.reverse.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reverse.Location = new System.Drawing.Point(63, 650);
            this.reverse.Margin = new System.Windows.Forms.Padding(2);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(75, 74);
            this.reverse.TabIndex = 18;
            this.reverse.Text = "+/-";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.Location = new System.Drawing.Point(179, 650);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 74);
            this.button0.TabIndex = 19;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // remainder
            // 
            this.remainder.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.remainder.Location = new System.Drawing.Point(547, 572);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(75, 74);
            this.remainder.TabIndex = 20;
            this.remainder.Text = "%";
            this.remainder.UseVisualStyleBackColor = true;
            this.remainder.Click += new System.EventHandler(this.remainder_Click);
            // 
            // his
            // 
            this.his.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.his.Location = new System.Drawing.Point(209, 229);
            this.his.Margin = new System.Windows.Forms.Padding(2);
            this.his.Name = "his";
            this.his.Size = new System.Drawing.Size(166, 53);
            this.his.TabIndex = 19;
            this.his.Text = "history";
            this.his.UseVisualStyleBackColor = true;
            this.his.Click += new System.EventHandler(this.his_Click);
            // 
            // formulaBox
            // 
            this.formulaBox.Font = new System.Drawing.Font("굴림", 16F);
            this.formulaBox.Location = new System.Drawing.Point(63, 29);
            this.formulaBox.Name = "formulaBox";
            this.formulaBox.ReadOnly = true;
            this.formulaBox.Size = new System.Drawing.Size(560, 38);
            this.formulaBox.TabIndex = 20;
            this.formulaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.dot.Location = new System.Drawing.Point(300, 650);
            this.dot.Margin = new System.Windows.Forms.Padding(2);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 74);
            this.dot.TabIndex = 21;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // binaryRadioButton
            // 
            this.binaryRadioButton.AutoSize = true;
            this.binaryRadioButton.Location = new System.Drawing.Point(13, 23);
            this.binaryRadioButton.Name = "binaryRadioButton";
            this.binaryRadioButton.Size = new System.Drawing.Size(66, 19);
            this.binaryRadioButton.TabIndex = 22;
            this.binaryRadioButton.TabStop = true;
            this.binaryRadioButton.Text = "2진수";
            this.binaryRadioButton.UseVisualStyleBackColor = true;
            this.binaryRadioButton.CheckedChanged += new System.EventHandler(this.binaryRadioButton_CheckedChanged);
            // 
            // decimalRadioButton
            // 
            this.decimalRadioButton.AutoSize = true;
            this.decimalRadioButton.Location = new System.Drawing.Point(85, 23);
            this.decimalRadioButton.Name = "decimalRadioButton";
            this.decimalRadioButton.Size = new System.Drawing.Size(74, 19);
            this.decimalRadioButton.TabIndex = 23;
            this.decimalRadioButton.TabStop = true;
            this.decimalRadioButton.Text = "10진수";
            this.decimalRadioButton.UseVisualStyleBackColor = true;
            this.decimalRadioButton.CheckedChanged += new System.EventHandler(this.decimalRadioButton_CheckedChanged);
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.AutoSize = true;
            this.hexRadioButton.Location = new System.Drawing.Point(159, 23);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(74, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(403, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 48);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "진수변환";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 745);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 25);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateDifferenceBox
            // 
            this.dateDifferenceBox.Location = new System.Drawing.Point(300, 745);
            this.dateDifferenceBox.Name = "dateDifferenceBox";
            this.dateDifferenceBox.Size = new System.Drawing.Size(305, 25);
            this.dateDifferenceBox.TabIndex = 27;
            // 
            // Calcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 797);
            this.Controls.Add(this.dateDifferenceBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calcul";
            this.Text = "계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox dateDifferenceBox;
    }
}

