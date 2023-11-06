using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 개인_메모장
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = "USER ID=C##5584980;PASSWORD=1234;Data source=localhost:1521/xepdb1";
            oracleConnection1.ConnectionString = conString;
            oracleConnection1.Open();
            MessageBox.Show(oracleConnection1.State.ToString());
            oracleCommand1.Connection = oracleConnection1; // 메모 저장
            oracleCommand2.Connection = oracleConnection1; // 다음 메모 : 실제로는 안 씀
            oracleCommand3.Connection = oracleConnection1; // 리스트 보기
            oracleCommand4.Connection = oracleConnection1; // 내용 보기
            oracleCommand5.Connection = oracleConnection1; // 시간 가져오기 ?
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // 메모 저장
        {
            DateTime current_time;
            current_time = Convert.ToDateTime(oracleCommand5.ExecuteScalar());

            oracleCommand1.CommandText = "INSERT INTO MEMO_TABLE (M_ID, M_KEYWORD, M_DATE, M_CONTENTS) VALUES(memo_seq.nextval, :aa, :bb, :cc)";
            //INSERT INTO MEMO_TABLE(M_ID,M_KEYWORD,M_DATE,M_CONTENTS) VALUES(memo_seq.nextval, :aa, :bb, :cc)

            oracleCommand1.Parameters["aa"].Value = textBox1.Text;
            oracleCommand1.Parameters["bb"].Value = current_time;
            oracleCommand1.Parameters["cc"].Value = richTextBox1.Text;

            oracleCommand1.ExecuteNonQuery(); //  입력 구문이므로 Commit
            MessageBox.Show("Memo successfully added");


            /*
             * (case 1)
             * oracleCommand1.Parameters["aa"].Value = textBox1.Text;
             * oracleCommand1.Parameters["bb"].Value = current_time.ToString();
             * oracleCommand1.Parameters["cc"].Value = richTextBox1.Text;
             * 
             * (case 2)
             * oracleCommand1.Parameters.Add("bb", OracleDbType.Date, current_time, ParameterDirection.Input); // 현재 시간
             * 
             * (case 3)
             * oracleCommand1.Parameters.Add(new OracleParameter("aa", textBox1.Text));
             * oracleCommand1.Parameters.Add(new OracleParameter("bb", current_time));
             * oracleCommand1.Parameters.Add(new OracleParameter("cc", richTextBox1.Text));
             */
        }

        private void button2_Click(object sender, EventArgs e) // 다음 메모
        {
            // 메모지 초기화
            textBox1.Text = null; // ""
            richTextBox1.Text = null; // ""
        }

        private void button3_Click(object sender, EventArgs e) // 메모 리스트 보기
        {
            oracleCommand3.CommandText = "SELECT M_ID FROM MEMO_TABLE";
            OracleDataReader rdr = oracleCommand3.ExecuteReader();
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["M_ID"]);
            }
            rdr.Close();
        }

        private void button4_Click(object sender, EventArgs e) // 내용 보기
        {
            try
            {
                string sql = "SELECT M_DATE, M_CONTENTS FROM MEMO_TABLE WHERE M_id=";
                string num = listBox1.SelectedItem.ToString(); // ?
                oracleCommand4.CommandText = sql + num;
                OracleDataReader rdr = oracleCommand4.ExecuteReader();

                listBox2.Items.Clear();
                int count = rdr.FieldCount;

                while (rdr.Read())
                {
                    listBox2.Items.Add(rdr["M_DATE"]);
                    listBox2.Items.Add(rdr["M_CONTENTS"]);
                }
            }
            catch
            {
                MessageBox.Show("Select Memo Plz");
            }
            

        }

        private void oracleConnection1_InfoMessage(object sender, OracleInfoMessageEventArgs eventArgs)
        {
            string conString = "USER ID=C##5584980;PASSWORD=1234;Data source=localhost:1521/xepdb1";
            oracleConnection1.ConnectionString = conString;
            oracleConnection1.Open();
            MessageBox.Show(oracleConnection1.State.ToString());
            oracleCommand1.Connection = oracleConnection1; // 오류 원인
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // 메모리스트
        {

        }

        

        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) // 메모의
        {

        }

        
    }
}
