using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231113_차트_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.DEPT_EMP_NONE_COUNT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dEPT_EMP_NONE_COUNTTableAdapter.Fill(this.dataSet11.DEPT_EMP_NONE_COUNT);
            // TODO: 이 코드는 데이터를 'dataSet1.DEPT_EMP_COUNT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dEPT_EMP_COUNTTableAdapter.Fill(this.dataSet1.DEPT_EMP_COUNT);
            // TODO: 이 코드는 데이터를 'dataSet1.EMP' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.eMPTableAdapter.Fill(this.dataSet1.EMP);

        }

        private void button1_Click(object sender, EventArgs e) // Refresh
        {
            this.dEPT_EMP_NONE_COUNTTableAdapter.Fill(this.dataSet11.DEPT_EMP_NONE_COUNT);
            chart1.DataBind();
        }
    }
}
