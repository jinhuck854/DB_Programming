﻿namespace 실습과제_일반용_계산기
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 25F);
            this.textBox1.Location = new System.Drawing.Point(12, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(324, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(32, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(94, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "MR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(156, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "M+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(218, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "M-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(280, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "MS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(7, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "%";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(92, 241);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 35);
            this.button7.TabIndex = 9;
            this.button7.Text = "CE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(177, 241);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 35);
            this.button8.TabIndex = 8;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(267, 241);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 35);
            this.button9.TabIndex = 7;
            this.button9.Text = "<-";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(7, 277);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 35);
            this.button10.TabIndex = 14;
            this.button10.Text = "1/x";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(92, 277);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 35);
            this.button11.TabIndex = 13;
            this.button11.Text = "x^";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(177, 277);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 35);
            this.button12.TabIndex = 12;
            this.button12.Text = "2√x";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Location = new System.Drawing.Point(267, 277);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 35);
            this.button13.TabIndex = 11;
            this.button13.Text = "÷";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(7, 313);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 35);
            this.button14.TabIndex = 18;
            this.button14.Text = "7";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(92, 313);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 35);
            this.button15.TabIndex = 17;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Location = new System.Drawing.Point(177, 313);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 35);
            this.button16.TabIndex = 16;
            this.button16.Text = "9";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Location = new System.Drawing.Point(267, 313);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(84, 35);
            this.button17.TabIndex = 15;
            this.button17.Text = "x";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Location = new System.Drawing.Point(7, 349);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(84, 35);
            this.button18.TabIndex = 22;
            this.button18.Text = "4";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Location = new System.Drawing.Point(92, 349);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(84, 35);
            this.button19.TabIndex = 21;
            this.button19.Text = "5";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Location = new System.Drawing.Point(177, 349);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 35);
            this.button20.TabIndex = 20;
            this.button20.Text = "6";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Location = new System.Drawing.Point(267, 349);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(84, 35);
            this.button21.TabIndex = 19;
            this.button21.Text = "-";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Location = new System.Drawing.Point(7, 385);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(84, 35);
            this.button22.TabIndex = 26;
            this.button22.Text = "1";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Location = new System.Drawing.Point(92, 385);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(84, 35);
            this.button23.TabIndex = 25;
            this.button23.Text = "2";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Location = new System.Drawing.Point(177, 385);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(84, 35);
            this.button24.TabIndex = 24;
            this.button24.Text = "3";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Location = new System.Drawing.Point(267, 385);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(84, 35);
            this.button25.TabIndex = 23;
            this.button25.Text = "+";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Location = new System.Drawing.Point(7, 421);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(84, 35);
            this.button26.TabIndex = 30;
            this.button26.Text = "+/-";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button27.Location = new System.Drawing.Point(92, 421);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(84, 35);
            this.button27.TabIndex = 29;
            this.button27.Text = "0";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button28.Location = new System.Drawing.Point(177, 421);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(84, 35);
            this.button28.TabIndex = 28;
            this.button28.Text = ".";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button29.Location = new System.Drawing.Point(267, 421);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(84, 35);
            this.button29.TabIndex = 27;
            this.button29.Text = "=";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 10F);
            this.textBox2.Location = new System.Drawing.Point(32, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(304, 16);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "표준";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 462);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

