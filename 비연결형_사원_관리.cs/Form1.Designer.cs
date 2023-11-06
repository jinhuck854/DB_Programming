
namespace 수업_실습
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
            this.components = new System.ComponentModel.Container();
            this.dataSet11 = new 수업_실습.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPTableAdapter = new 수업_실습.DataSet1TableAdapters.EMPTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dEPTNODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPTTableAdapter = new 수업_실습.DataSet1TableAdapters.DEPTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPNODataGridViewTextBoxColumn,
            this.eNAMEDataGridViewTextBoxColumn,
            this.dEPTNODataGridViewTextBoxColumn,
            this.dNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(590, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // eMPNODataGridViewTextBoxColumn
            // 
            this.eMPNODataGridViewTextBoxColumn.DataPropertyName = "EMPNO";
            this.eMPNODataGridViewTextBoxColumn.HeaderText = "EMPNO";
            this.eMPNODataGridViewTextBoxColumn.Name = "eMPNODataGridViewTextBoxColumn";
            // 
            // eNAMEDataGridViewTextBoxColumn
            // 
            this.eNAMEDataGridViewTextBoxColumn.DataPropertyName = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.HeaderText = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.Name = "eNAMEDataGridViewTextBoxColumn";
            // 
            // dEPTNODataGridViewTextBoxColumn
            // 
            this.dEPTNODataGridViewTextBoxColumn.DataPropertyName = "DEPTNO";
            this.dEPTNODataGridViewTextBoxColumn.HeaderText = "DEPTNO";
            this.dEPTNODataGridViewTextBoxColumn.Name = "dEPTNODataGridViewTextBoxColumn";
            // 
            // dNAMEDataGridViewTextBoxColumn
            // 
            this.dNAMEDataGridViewTextBoxColumn.DataPropertyName = "DNAME";
            this.dNAMEDataGridViewTextBoxColumn.HeaderText = "DNAME";
            this.dNAMEDataGridViewTextBoxColumn.Name = "dNAMEDataGridViewTextBoxColumn";
            // 
            // eMPBindingSource
            // 
            this.eMPBindingSource.DataMember = "EMP";
            this.eMPBindingSource.DataSource = this.dataSet11;
            // 
            // eMPTableAdapter
            // 
            this.eMPTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "정보 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "사원 번호 검색";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(391, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 20);
            this.button3.TabIndex = 4;
            this.button3.Text = "부서 번호 필터링";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 426);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "사원";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(15, 91);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 20);
            this.button9.TabIndex = 7;
            this.button9.Text = "사원 변경";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 20);
            this.button8.TabIndex = 6;
            this.button8.Text = "사원 삭제";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 39);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 20);
            this.button7.TabIndex = 5;
            this.button7.Text = "사원 추가";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "부서";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(15, 91);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 20);
            this.button12.TabIndex = 7;
            this.button12.Text = "부서 변경";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(15, 65);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 20);
            this.button11.TabIndex = 6;
            this.button11.Text = "부서 삭제";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(15, 39);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 20);
            this.button10.TabIndex = 5;
            this.button10.Text = "부서 추가";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(391, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(214, 20);
            this.button6.TabIndex = 4;
            this.button6.Text = "부서 위치 필터링";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(391, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 20);
            this.button5.TabIndex = 3;
            this.button5.Text = "부서 번호 검색";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 21);
            this.textBox2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 20);
            this.button4.TabIndex = 1;
            this.button4.Text = "정보 저장";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dEPTNODataGridViewTextBoxColumn1,
            this.dNAMEDataGridViewTextBoxColumn1,
            this.lOCDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dEPTBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(15, 131);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(590, 240);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dEPTNODataGridViewTextBoxColumn1
            // 
            this.dEPTNODataGridViewTextBoxColumn1.DataPropertyName = "DEPTNO";
            this.dEPTNODataGridViewTextBoxColumn1.HeaderText = "DEPTNO";
            this.dEPTNODataGridViewTextBoxColumn1.Name = "dEPTNODataGridViewTextBoxColumn1";
            // 
            // dNAMEDataGridViewTextBoxColumn1
            // 
            this.dNAMEDataGridViewTextBoxColumn1.DataPropertyName = "DNAME";
            this.dNAMEDataGridViewTextBoxColumn1.HeaderText = "DNAME";
            this.dNAMEDataGridViewTextBoxColumn1.Name = "dNAMEDataGridViewTextBoxColumn1";
            // 
            // lOCDataGridViewTextBoxColumn
            // 
            this.lOCDataGridViewTextBoxColumn.DataPropertyName = "LOC";
            this.lOCDataGridViewTextBoxColumn.HeaderText = "LOC";
            this.lOCDataGridViewTextBoxColumn.Name = "lOCDataGridViewTextBoxColumn";
            // 
            // dEPTBindingSource
            // 
            this.dEPTBindingSource.DataMember = "DEPT";
            this.dEPTBindingSource.DataSource = this.dataSet11;
            // 
            // dEPTTableAdapter
            // 
            this.dEPTTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eMPBindingSource;
        private DataSet1TableAdapters.EMPTableAdapter eMPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dEPTBindingSource;
        private DataSet1TableAdapters.DEPTTableAdapter dEPTTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTNODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
    }
}

