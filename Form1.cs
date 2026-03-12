namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 새로운 위치 값 세팅.
            int x_position = 100;
            int y_position = 150;
            //새로운 X, Y 좌표값
            // 버튼을 새로운 위치로 옮김 (새로운 Point 객체 생성)
            RunButton.Location = new Point(x_position, y_position);

            // 1. 난수 생성기 준비
            Random rd = new Random();

            // 2. 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            // Clientsize는 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            // 3. 랜덤 좌표 추출
            int nextX = rd.Next(0, 143);
            int nextY = rd.Next(0, 75);

            // 4. 위치 할당 (새로운 point 객체 생성)
            RunButton.Location = new Point(nextX, nextY);

            // 5. 시각적 피드백 (폼 제목 표시줄에 좌표 출력)
            this.Text = $"버튼 위치: ({nextX}, {nextY})";

        }

        private void RunButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
