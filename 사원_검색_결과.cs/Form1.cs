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

namespace 사원_검색_결과
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

            // 도구에서 생성도 가능// OracleConnection oracleConnection1 = new OracleConnection();

            oracleConnection1.ConnectionString = conString;
            oracleConnection1.Open();
            MessageBox.Show(oracleConnection1.State.ToString());
            oracleCommand1.Connection = oracleConnection1;
        }

        private void button1_Click(object sender, EventArgs e) // 사원 검색 버튼
        {
            // oracleConnection1.Open();
            // oracleCommand1.CommandText = "SELECT * FROM EMP WHERE EMPNO=:PARAM";

            // oracleCommand1.Connection = oracleConnection1; // 이거 안 해서..? 하..

            try
            {
                oracleCommand1.Parameters["pa"].Value = textBox1.Text; //Parameters[“pa”]로도 사용 가능
                OracleDataReader rdr = oracleCommand1.ExecuteReader();
                while (rdr.Read())
                {
                    textBox2.Text = rdr["ENAME"].ToString();
                    textBox3.Text = rdr["JOB"].ToString();
                }

                rdr.Close();
            }
            catch
            {
                MessageBox.Show("No EMP");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oracleConnection1.Close();
            MessageBox.Show(oracleConnection1.State.ToString());
            this.Close();
        }
    }
}
