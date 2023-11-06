using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 수업_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddDeleteButtonColumn()
        {
            var deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "dataGridViewDeleteButton";
            deleteButtonColumn.HeaderText = "삭제";
            deleteButtonColumn.Text = "삭제";
            deleteButtonColumn.UseColumnTextForButtonValue = true; // 이렇게 설정하면 모든 버튼에 '삭제'라는 텍스트가 표시됩니다.
            dataGridView1.Columns.Add(deleteButtonColumn);

            // 버튼 클릭 이벤트를 핸들링하기 위해 이벤트 핸들러를 추가합니다.
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.DEPT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dEPTTableAdapter.Fill(this.dataSet11.DEPT);
            // TODO: 이 코드는 데이터를 'dataSet11.EMP' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.eMPTableAdapter.Fill(this.dataSet11.EMP);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) // 삭제 전 창 띄우기
        {
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);

            if (MessageBox.Show("삭제하시겠습니까?", "행삭제", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) // 사원 정보 저장하기 : Update
        {
            try
            {
                this.eMPBindingSource.EndEdit();
                int ret = this.eMPTableAdapter.Update(this.dataSet11.EMP);
                if (ret > 0)
                    MessageBox.Show("Update Successful");
            }
            catch
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button2_Click(object sender, EventArgs e) // 사원 번호로 검색
        {
            int itemFound = eMPBindingSource.Find("EMPNO", textBox1.Text); // 특정 단어 입력
            eMPBindingSource.Position = itemFound; // 위치 이동
        }

        private void button3_Click(object sender, EventArgs e) // 필터링
        {
            if(eMPBindingSource.Filter != null)
            {
                eMPBindingSource.RemoveFilter();
                button3.Text = "필터";
            }
            else
            {
                eMPBindingSource.Filter = "DEPTNO = '" + textBox1.Text + "'";
                button3.Text = "필터 해제";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // 검색/필터 입력값 textBox
        {

        }

        private void button4_Click(object sender, EventArgs e) // 부서 정보 저장하기
        {
            try
            {
                this.dEPTBindingSource.EndEdit();
                int ret = this.dEPTTableAdapter.Update(this.dataSet11.DEPT);
                if (ret > 0)
                    MessageBox.Show("Update Successful");
            }
            catch
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button5_Click(object sender, EventArgs e) // 부서 번호로 검색
        {
            int itemFound = dEPTBindingSource.Find("DEPTNO", textBox2.Text); // 특정 단어 입력
            dEPTBindingSource.Position = itemFound; // 위치 이동
        }

        private void button6_Click(object sender, EventArgs e) // 부서 위치 필터링
        {
            if (dEPTBindingSource.Filter != null)
            {
                dEPTBindingSource.RemoveFilter();
                button6.Text = "필터";
            }
            else
            {
                dEPTBindingSource.Filter = "LOC = '" + textBox2.Text + "'";
                button6.Text = "필터 해제";
            }
        }

        private void button7_Click(object sender, EventArgs e) // 사원 추가
        {
            eMPBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e) // 사원 삭제
        {
            eMPBindingSource.RemoveCurrent();
        }

        private void button9_Click(object sender, EventArgs e) // 사원 변경
        {
            try
            {
                this.eMPBindingSource.EndEdit();
                int ret = this.eMPTableAdapter.Update(this.dataSet11.EMP);
                if (ret > 0)
                    MessageBox.Show("Update EMP");
            }
            catch
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button10_Click(object sender, EventArgs e) // 부서 추가
        {
            dEPTBindingSource.AddNew();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dEPTBindingSource.RemoveCurrent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                this.dEPTBindingSource.EndEdit();
                int ret = this.dEPTTableAdapter.Update(this.dataSet11.DEPT);
                if (ret > 0)
                    MessageBox.Show("Update DEPT");
            }
            catch
            {
                MessageBox.Show("Update failed");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
