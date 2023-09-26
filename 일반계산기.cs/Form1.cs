using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 실습과제_일반용_계산기
{
    public partial class Form1 : Form
    {
        // 변수
        string operand1; // 피연산자 1
        string operand2; // 피연산자 2 

        bool operand_check = false; // 연산자 나오기 전까지 피연산자 1 계산

        double result = 0; // 결과값 : 소숫점 생각해서 double 자료형
        double memory = 0; // 메모리
        double pre_operand2 = 0;

        // int my_operator;

        enum Operator
        {
            ADD = 1, // 더하기 +
            SUB = 2, // 빼기 -
            MUL = 3, // 곱하기 x
            DIV = 4, // 나누기 ÷
            MOD = 5 // 나머지 %
        }

        Operator my_operator;

        // 초기화
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // 백그라운드 : ?? 뭔 클래스야
        {

        }

        private void button27_Click(object sender, EventArgs e) // 숫자 0
        {
            if (operand_check == false)
            {
                operand1 += "0";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "0";
                textBox1.Text = operand2;
            }
        }

        private void button22_Click(object sender, EventArgs e) // 숫자 1
        {
            if (operand_check == false)
            {
                operand1 += "1";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "1";
                textBox1.Text = operand2;
            }
                
        }

        private void button23_Click(object sender, EventArgs e) // 숫자 2
        {
            if (operand_check == false)
            {
                operand1 += "2";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "2";
                textBox1.Text = operand2;
            }
        }

        private void button24_Click(object sender, EventArgs e) // 숫자 3
        {
            if (operand_check == false)
            {
                operand1 += "3";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "3";
                textBox1.Text = operand2;
            }
        }

        private void button18_Click(object sender, EventArgs e) // 숫자 4
        {
            if (operand_check == false)
            {
                operand1 += "4";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "4";
                textBox1.Text = operand2;
            }
        }

        private void button19_Click(object sender, EventArgs e) // 숫자 5
        {
            if (operand_check == false)
            {
                operand1 += "5";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "5";
                textBox1.Text = operand2;
            }
        }

        private void button20_Click(object sender, EventArgs e) // 숫자 6
        {
            if (operand_check == false)
            {
                operand1 += "6";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "6";
                textBox1.Text = operand2;
            }
        }

        private void button14_Click(object sender, EventArgs e) // 숫자 7
        {
            if (operand_check == false)
            {
                operand1 += "7";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "7";
                textBox1.Text = operand2;
            }
        }

        private void button15_Click(object sender, EventArgs e) // 숫자 8
        {
            if (operand_check == false)
            {
                operand1 += "8";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "8";
                textBox1.Text = operand2;
            }
        }

        private void button16_Click(object sender, EventArgs e) // 숫자 9
        {
            if (operand_check == false)
            {
                operand1 += "9";
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += "9";
                textBox1.Text = operand2;
            }
        }



        private void button26_Click(object sender, EventArgs e) // +/- : 토글
        {
            double temp; // 임시 변수

            if (operand_check == false) // 피연산자1 토글
            {
                temp = Convert.ToDouble(operand1) * -1;
                operand1 = Convert.ToString(temp);
                textBox1.Text = operand1;
            }
            else // 피연산자2 토글
            {
                temp = Convert.ToDouble(operand2) * -1;
                operand2 = Convert.ToString(temp);
                textBox1.Text = operand2;
            }

        }

        private void button28_Click(object sender, EventArgs e) // . : 소숫점
        {
            if (textBox1.Text.Contains(".")) // 중복 방지
                return;
            else
            {
                if (operand_check == false)
                    operand1 += ".";
                else
                    operand2 += ".";
            }

            
        }

        private void button25_Click(object sender, EventArgs e) // + : 더하기
        {
            if(operand_check == false)
            {
                my_operator = Operator.ADD; // ADD = 1
                textBox1.Text = "";
                textBox2.Text = operand1 + "+";
                operand_check = true;
            }
            else // + 연속 눌렀을 때 : return 하기
            {
                return;
                /*
                result = Convert.ToDouble(operand1) + Convert.ToDouble(operand2); ;
                textBox1.Text = textBox2.Text = Convert.ToString(result);
                // textBox2.Text = operand1 + "+" + operand2;
                operand1 = Convert.ToString(result);
                operand2 = "";
                // operand_check = false;
                */
            }

        }
        private void button21_Click(object sender, EventArgs e) // - : 빼기
        {
            if(operand_check == false)
            {
                my_operator = Operator.SUB; // SUB = 2
                textBox1.Text = "";
                textBox2.Text = operand1 + "-";
                operand_check = true;
            }
            else
            {
                return;
            }
            
        }

        private void button17_Click(object sender, EventArgs e) // x : 곱하기
        {
            if(operand_check == false)
            {
                my_operator = Operator.MUL; // MUL = 3
                textBox1.Text = "";
                textBox2.Text = operand1 + "x";
                operand_check = true;
            }
            else
            {
                return;
            }
            
        }

        private void button13_Click(object sender, EventArgs e) // ÷ : 나누기
        {
            if(operand_check == false)
            {
                my_operator = Operator.DIV; // DIV = 4
                textBox1.Text = "";
                textBox2.Text = operand1 + "÷";
                operand_check = true;
            }
            else
            {
                return;
            }
            
        }

        private void button6_Click(object sender, EventArgs e) // % : 나머지
        {
            if(operand_check == false)
            {
                my_operator = Operator.MOD; // MOD = 5
                textBox1.Text = "";
                textBox2.Text = operand1 + "%";
                operand_check = true;
            }
            else
            {
                return;
            }
            
        }

        private void button29_Click(object sender, EventArgs e) // = : 결과
        {
            if (operand_check == false && operand2 == "") // = 연속으로 누를 때
            {
                switch (my_operator)
                {
                    case Operator.ADD:
                        result += pre_operand2;
                        textBox1.Text = Convert.ToString(result);
                        textBox2.Text = operand1 + "+" + pre_operand2;
                        operand1 = Convert.ToString(result);
                        return;

                    case Operator.SUB:
                        result -= pre_operand2;
                        textBox1.Text = Convert.ToString(result);
                        textBox2.Text = operand1 + "-" + pre_operand2;
                        operand1 = Convert.ToString(result);
                        return;

                    case Operator.MUL:
                        result *= pre_operand2;
                        textBox1.Text = Convert.ToString(result);
                        textBox2.Text = operand1 + "*" + pre_operand2;
                        operand1 = Convert.ToString(result);
                        return;

                    case Operator.DIV:
                        result /= pre_operand2;
                        textBox1.Text = Convert.ToString(result);
                        textBox2.Text = operand1 + "÷" + pre_operand2;
                        operand1 = Convert.ToString(result);
                        return;

                    case Operator.MOD:
                        result %= pre_operand2;
                        textBox1.Text = Convert.ToString(result);
                        textBox2.Text = operand1 + "%" + pre_operand2;
                        operand1 = Convert.ToString(result);
                        return;
                }
            }

            double num_operand1 = Convert.ToDouble(operand1);
            double num_operand2 = Convert.ToDouble(operand2);

            switch (my_operator)
            {
                case Operator.ADD: // 덧셈 결과
                    result = num_operand1 + num_operand2;
                    textBox1.Text = Convert.ToString(result);
                    textBox2.Text = operand1 + "+" + operand2;
                    operand1 = Convert.ToString(result);
                    operand2 = "";
                    operand_check = false;
                    pre_operand2 = num_operand2;
                    break;

                case Operator.SUB: // 뺄셈 결과
                    result = num_operand1 - num_operand2;
                    textBox1.Text = Convert.ToString(result);
                    textBox2.Text = operand1 + "-" + operand2;
                    operand1 = Convert.ToString(result);
                    operand2 = "";
                    operand_check = false;
                    pre_operand2 = num_operand2;
                    break;

                case Operator.MUL: // 곱셈 결과
                    result = num_operand1 * num_operand2;
                    textBox1.Text = Convert.ToString(result);
                    textBox2.Text = operand1 + "*" + operand2;
                    operand1 = Convert.ToString(result);
                    operand2 = "";
                    operand_check = false;
                    pre_operand2 = num_operand2;
                    break;

                case Operator.DIV: // 나눗셈 결과
                    if(operand2 == "0")
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다!", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        operand1 = "";
                        operand2 = "";
                        operand_check = false;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        break;
                    }

                    result = num_operand1 / num_operand2;
                    textBox1.Text = Convert.ToString(result);
                    textBox2.Text = operand1 + "/" + operand2;
                    operand1 = Convert.ToString(result);
                    operand2 = "";
                    operand_check = false;
                    pre_operand2 = num_operand2;
                    break;

                case Operator.MOD: // 나머지 결과
                    result = num_operand1 % num_operand2;
                    textBox1.Text = Convert.ToString(result);
                    textBox2.Text = operand1 + "%" + operand2;
                    operand1 = Convert.ToString(result);
                    operand2 = "";
                    operand_check = false;
                    pre_operand2 = num_operand2;
                    break;

                default:
                    MessageBox.Show("프로그램을 종료합니다", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e) // <- : 현재 1칸 삭제 !! 문제 : 삭제가 안됨.
        {
            
            if (textBox1.Text.Length <= 0)
                textBox1.Text = "";

            if(operand_check == false)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                operand1 = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                operand2 = textBox1.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e) // C : 전체 삭제 == 전체 초기화
        {
            operand1 = "";
            operand2 = "";
            operand_check = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e) // CE : 진행중인 숫자 삭제
        {
            if (operand_check == false) // 피연산자1 계산중 == 전체 초기화
            { 
                operand1 = "";
                operand2 = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (operand_check == true) // 피연산자2 계산중 == 피연산자2만 초기화
            {
                operand2 = "";
                textBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e) // 2√x : 2 루트 x (1.73?)
        {
            if(operand_check == false)
            { // operand = 4
                double temp = Math.Sqrt(Convert.ToDouble(operand1)); // 루트 결과값
                textBox1.Text = Convert.ToString(temp);
                textBox2.Text = "√(" + operand1 + ")";
                operand1 = textBox1.Text;
            }
            else
            {
                double temp = Math.Sqrt(Convert.ToDouble(operand2));
                textBox1.Text = Convert.ToString(temp);
                textBox2.Text = "√(" + operand2 + ")";
                operand2 = textBox1.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e) // x^ : 제곱
        {
            if (operand_check == false)
            {
                operand1 = Convert.ToString(Convert.ToDouble(operand1) * Convert.ToDouble(operand1));
                textBox1.Text = operand1;
                textBox2.Text = operand1;
            }
            else
            {
                operand2 = Convert.ToString(Convert.ToDouble(operand2) * Convert.ToDouble(operand2));
                textBox1.Text = operand2;
            }
        }

        private void button10_Click(object sender, EventArgs e) // 1/x : x분의 1
        {
            if(operand_check == false)
            {
                operand1 = Convert.ToString(1 / Convert.ToDouble(operand1));
                textBox1.Text = operand1;
            }
            else
            {
                operand2 = Convert.ToString(1 / Convert.ToDouble(operand2));
                textBox1.Text = operand2;
            }
        }

        private void button5_Click(object sender, EventArgs e) // MS(Memory Save)
        {
            if(operand_check == false) // 피연산자 1 : 메모리 저장
            {
                memory = Convert.ToDouble(operand1);
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else // 피연산자 2 : 메모리 저장
            {
                memory = Convert.ToDouble(operand2);
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e) // M-(Memory Minus)
        {
            memory -= Convert.ToDouble(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e) // M+(Memory Plus)
        {
            memory += Convert.ToDouble(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e) // MR(Memory Read) : 처음 비활성화
        {
            if(operand_check == false)
            {
                textBox1.Text = Convert.ToString(memory);
                operand1 = Convert.ToString(memory);
            }
            else
            {
                textBox1.Text = Convert.ToString(memory);
                operand2 = Convert.ToString(memory);
            }
        }

        private void button1_Click(object sender, EventArgs e) // MC(Memory Clear) : 처음 비활성화
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
