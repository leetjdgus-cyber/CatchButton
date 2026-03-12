namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 점수와 난수생성기 필드
        private int _score = 0;
        private readonly Random _rd = new Random();
        private int _missCount = 0;
        private bool _isGameOver = false;
        private const int MaxMisses = 20;

        public Form1()
        {
            InitializeComponent();
            // 초기 점수 및 미스 표시
            this.Text = $"Score: {_score} | Misses: {_missCount}/{MaxMisses}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 게임 오버 상태이면 아무 작업도 하지 않음
            if (_isGameOver)
                return;

            // 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            // 랜덤 좌표 추출 (버튼 크기를 고려)
            int nextX = _rd.Next(0, Math.Max(1, maxX - RunButton.Width));
            int nextY = _rd.Next(0, Math.Max(1, maxY - RunButton.Height));

            // 위치 할당
            RunButton.Location = new Point(nextX, nextY);

            // 도망간 경우 점수 감점 및 미스 카운트 증가
            _score -= 10;
            _missCount++;

            // 게임 오버 체크
            if (_missCount >= MaxMisses)
            {
                _isGameOver = true;
                // 모든 버튼 비활성화
                foreach (Control c in this.Controls)
                {
                    if (c is Button b)
                        b.Enabled = false;
                }

                // 알림 및 타이틀 업데이트
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Text = $"Game Over - Score: {_score}";
                return;
            }

            // 시각적 피드백 (폼 제목 표시줄에 점수, 미스, 좌표 출력)
            this.Text = $"Score: {_score} | Misses: {_missCount}/{MaxMisses}  |  버튼 위치: ({nextX}, {nextY})";

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭하면 점수 추가 및 축하 메시지 표시
            _score += 100;
            this.Text = $"Score: {_score}";
            MessageBox.Show("축하합니다~", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
