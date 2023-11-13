
namespace _231113_차트_실습
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new _231113_차트_실습.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPTableAdapter = new _231113_차트_실습.DataSet1TableAdapters.EMPTableAdapter();
            this.dEPTEMPCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPT_EMP_COUNTTableAdapter = new _231113_차트_실습.DataSet1TableAdapters.DEPT_EMP_COUNTTableAdapter();
            this.dataSet11 = new _231113_차트_실습.DataSet1();
            this.dEPTEMPNONECOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPT_EMP_NONE_COUNTTableAdapter = new _231113_차트_실습.DataSet1TableAdapters.DEPT_EMP_NONE_COUNTTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTEMPCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTEMPNONECOUNTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Title = "EMPNO";
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.dEPTEMPNONECOUNTBindingSource;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(251, 69);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "사원수";
            series2.XValueMember = "NEW_DEPT";
            series2.YValueMembers = "EMP_CNT";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "부서 내 사원";
            this.chart1.Titles.Add(title2);
            // 
            // eMPBindingSource
            // 
            this.eMPBindingSource.DataMember = "EMP";
            this.eMPBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // eMPTableAdapter
            // 
            this.eMPTableAdapter.ClearBeforeFill = true;
            // 
            // dEPTEMPCOUNTBindingSource
            // 
            this.dEPTEMPCOUNTBindingSource.DataMember = "DEPT_EMP_COUNT";
            this.dEPTEMPCOUNTBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dEPT_EMP_COUNTTableAdapter
            // 
            this.dEPT_EMP_COUNTTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPTEMPNONECOUNTBindingSource
            // 
            this.dEPTEMPNONECOUNTBindingSource.DataMember = "DEPT_EMP_NONE_COUNT";
            this.dEPTEMPNONECOUNTBindingSource.DataSource = this.dataSet11;
            // 
            // dEPT_EMP_NONE_COUNTTableAdapter
            // 
            this.dEPT_EMP_NONE_COUNTTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTEMPCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTEMPNONECOUNTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eMPBindingSource;
        private DataSet1TableAdapters.EMPTableAdapter eMPTableAdapter;
        private System.Windows.Forms.BindingSource dEPTEMPCOUNTBindingSource;
        private DataSet1TableAdapters.DEPT_EMP_COUNTTableAdapter dEPT_EMP_COUNTTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource dEPTEMPNONECOUNTBindingSource;
        private DataSet1TableAdapters.DEPT_EMP_NONE_COUNTTableAdapter dEPT_EMP_NONE_COUNTTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

