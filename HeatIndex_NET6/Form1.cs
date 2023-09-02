namespace HeatIndex_NET6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_stations.SelectedIndex = 0;
            calculator.ErrorHandler += ShowErrorMessage;
            calculator.CalculatorHandler += ShowHeatIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = calculator.Calculate(comboBox_stations.SelectedIndex);
        }

        private void ShowHeatIndex(object sender, HeatIndexArgs e)
        {
            label_HeatIndexText.Text = e.HeatIndex;
            int HeatIndex = int.Parse(e.HeatIndex);

            if (HeatIndex < 27)
            {
                label_HeatIndexText.ForeColor = Color.Green;
                label_ClassificationText.Text = "無";
                label_ClassificationText.ForeColor = Color.Green;
                label_PossibleSymptomText.Text = "無";
                label_SolutionText.Text = "隨時留意攝取適當水分！";
            }

            else if (HeatIndex <= 31 && HeatIndex >= 27)
            {
                label_HeatIndexText.ForeColor = Color.Yellow;
                label_ClassificationText.Text = "警戒";
                label_ClassificationText.ForeColor = Color.Yellow;
                label_PossibleSymptomText.Text = "長期暴露或是激烈運動可能使人疲倦";
                label_SolutionText.Text = "隨時留意攝取適當水分！";
            }

            else if (HeatIndex <= 40 && HeatIndex >= 32)
            {
                label_HeatIndexText.ForeColor = Color.FromArgb(255, 215, 0);
                label_ClassificationText.Text = "極度警戒";
                label_ClassificationText.ForeColor = Color.FromArgb(255, 215, 0);
                label_PossibleSymptomText.Text = "長期暴露或是激烈運動可能導致肌肉痙攣或熱衰竭";
                label_SolutionText.Text = "室內若有睡眠需求時建議開冷氣\r\n不建議外出，外出時請穿著可保持涼爽的衣物並隨時注意攝取適當水分！";
            }

            else if (HeatIndex <= 53 && HeatIndex >= 41)
            {
                label_HeatIndexText.ForeColor = Color.Orange;
                label_ClassificationText.Text = "危險";
                label_ClassificationText.ForeColor = Color.Orange;
                label_PossibleSymptomText.Text = "可能引起肌肉痙攣、熱衰竭，長期暴露或是激烈活動可能導致中暑";
                label_SolutionText.Text = "室內平時建議開冷氣\r\n建議不外出，外出時除穿著可保持涼爽的衣物，務必確保水分來源隨時充足！";
            }

            else if (HeatIndex >= 54)
            {
                label_HeatIndexText.ForeColor = Color.Red;
                label_ClassificationText.Text = "極度危險";
                label_ClassificationText.ForeColor = Color.Red;
                label_PossibleSymptomText.Text = "短期即有中暑可能";
                label_SolutionText.Text = "室內務必確保冷氣隨時在運轉\r\n強烈建議不外出，必要時外出務必隨時確保水分來源充足並補充水分！";
            }

            if (HeatIndex == -2)
            {
                label_HeatIndexText.ForeColor = Color.Black;
                label_ClassificationText.Text = "無法確定";
                label_ClassificationText.ForeColor = Color.Black;
                label_PossibleSymptomText.Text = "無法確定";
                label_SolutionText.Text = "隨時留意攝取適當水分！";
            }
        }

        private void ShowErrorMessage(object sender, ErrorArgs e)
        {
            switch ((int)e.ErrorType)
            {
                case 0:
                    MessageBox.Show(String.Format("儀器調校中\r\n\r\n{0}", e.ErrorMessage), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 1:
                    MessageBox.Show(String.Format("發生預期外的狀況\r\n\r\n{0}", e.ErrorMessage), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show(e.ErrorMessage, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            calculator.Dispose();
        }
    }
}