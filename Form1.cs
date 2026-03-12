namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 점수와 난수생성기 필드
        private int _score = 0;
        private readonly Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
            // 초기 점수 표시
            this.Text = $"Score: {_score}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            // 랜덤 좌표 추출 (버튼 크기를 고려)
            int nextX = _rd.Next(0, Math.Max(1, maxX - RunButton.Width));
            int nextY = _rd.Next(0, Math.Max(1, maxY - RunButton.Height));

            // 위치 할당
            RunButton.Location = new Point(nextX, nextY);

            // 도망간 경우 점수 감점
            _score -= 10;

            // 시각적 피드백 (폼 제목 표시줄에 점수와 좌표 출력)
            this.Text = $"Score: {_score}  |  버튼 위치: ({nextX}, {nextY})";

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭하면 점수 추가
            _score += 100;
            this.Text = $"Score: {_score}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
