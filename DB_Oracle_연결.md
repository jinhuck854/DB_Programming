# Step 1. `OracleManagedDataAccess` 설치
 1. Visual Studio 새 프로젝트 생성
 2. 새 프로젝트 우클릭 - 'Nuget 패키지 관리' 클릭 후 '찾아보기'
 3. 'oracle' 검색 후 `OracleManagedDataAccess` 설치 후 확인
 4. 설치 끝

# Step 2. Oracle <-> VS 연결
 1. Button1 생성 후 더블클릭(코드창)
 2. 아래 코드 입력
<div>
  
    private void button1_Click(object sender, EventArgs e) // 연결 버튼
    {
      
    string conString = "USER ID=C##5584980;PASSWORD=****;Data source = localhost:1521 / xepdb1;";
    // OracleConnection oracleConnection1 = new OracleConnection();
    oracleConnection1.ConnectionString = conString;
    oracleConnection1.Open();
    MessageBox.Show(oracleConnection1.State.ToString()); // 연결 확인용 메시지 박스
    }

    private void button2_Click(object sender, EventArgs e) // 연결 해제 버튼
    {
    // OracleConnection oracleConnection1 = new OracleConnection();
    oracleConnection1.Close();
    MessageBox.Show(oracleConnection1.State.ToString()); // closed 메시지 박스
    }

    private void button3_Click(object sender, EventArgs e)
    {
    // OracleCommand cmd = new OracleCommand(); // Oracle - 도구 상자로 생성 가능
    oracleCommand1.Connection = oracleConnection1;
    oracleCommand1.CommandText = "SELECT * FROM EMP"; // 테이블
    OracleDataReader rdr = oracleCommand1.ExecuteReader();
    while (rdr.Read())
    {
        listBox1.Items.Add(rdr["ename"]); // 칼람 

    }
    rdr.Close();

    }

</div>
