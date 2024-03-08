namespace HeatIndex_NET6
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
            comboBox_stations.SelectedIndex = 0;
            calculator.ErrorHandler += ShowErrorMessage;
            calculator.CalculatorHandler += ShowHeatIndex;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            button_calculate.Enabled = false;
            calculator.index = comboBox_stations.SelectedIndex;
            OpenWebDriver = new Thread(calculator.Calculate);
            OpenWebDriver.Start();
        }

        private void ShowHeatIndex(object sender, HeatIndexArgs e)
        {
            button_calculate.InvokeIfRequired(() => { button_calculate.Enabled = true; });
            label_HeatIndexText.InvokeIfRequired(() => { label_HeatIndexText.Text = e.HeatIndex; });
            label_HumidityText.InvokeIfRequired(() => { label_HumidityText.Text = e.humidity; });
            int HeatIndex = int.Parse(e.HeatIndex);

            if (HeatIndex < 27)
            {
                label_HeatIndexText.InvokeIfRequired(() => { label_HeatIndexText.ForeColor = Color.Green; });
                label_ClassificationText.InvokeIfRequired(() =>
                {
                    label_ClassificationText.Text = "�L";
                    label_ClassificationText.ForeColor = Color.Green;
                });
                label_PossibleSymptomText.InvokeIfRequired(() => { label_PossibleSymptomText.Text = "�L"; });
                label_SolutionText.InvokeIfRequired(() => { label_SolutionText.Text = "�H�ɯd�N����A������I"; });
            }

            else if (HeatIndex <= 31 && HeatIndex >= 27)
            {
                label_HeatIndexText.InvokeIfRequired(() => { label_HeatIndexText.ForeColor = Color.Yellow; });
                label_ClassificationText.InvokeIfRequired(() =>
                {
                    label_ClassificationText.Text = "ĵ��";
                    label_ClassificationText.ForeColor = Color.Yellow;
                });
                label_PossibleSymptomText.InvokeIfRequired(() => { label_PossibleSymptomText.Text = "�������S�άO�E�P�B�ʥi��ϤH�h��"; });
                label_SolutionText.InvokeIfRequired(() => { label_SolutionText.Text = "�H�ɯd�N����A������I"; });
            }

            else if (HeatIndex <= 40 && HeatIndex >= 32)
            {
                label_HeatIndexText.InvokeIfRequired(() => { label_HeatIndexText.ForeColor = Color.FromArgb(255, 215, 0); });
                label_ClassificationText.InvokeIfRequired(() =>
                {
                    label_ClassificationText.Text = "����ĵ��";
                    label_ClassificationText.ForeColor = Color.FromArgb(255, 215, 0);
                });
                label_PossibleSymptomText.InvokeIfRequired(() => { label_PossibleSymptomText.Text = "�������S�άO�E�P�B�ʥi��ɭP�٦׵j�˩μ��I��"; });
                label_SolutionText.InvokeIfRequired(() => { label_SolutionText.Text = "�Ǥ��Y���ίv�ݨD�ɫ�ĳ�}�N��\r\n����ĳ�~�X�A�~�X�ɽЬ�ۥi�O���D�n���窫���H�ɪ`�N����A������I"; });
            }

            else if (HeatIndex <= 53 && HeatIndex >= 41)
            {
                label_HeatIndexText.InvokeIfRequired(() => { label_HeatIndexText.ForeColor = Color.Orange; });
                label_ClassificationText.InvokeIfRequired(() =>
                {
                    label_ClassificationText.Text = "�M�I";
                    label_ClassificationText.ForeColor = Color.Orange;
                });
                label_PossibleSymptomText.InvokeIfRequired(() => { label_PossibleSymptomText.Text = "�i��ް_�٦׵j�ˡB���I�ܡA�������S�άO�E�P���ʥi��ɭP����"; });
                label_SolutionText.InvokeIfRequired(() => { label_SolutionText.Text = "�Ǥ����ɫ�ĳ�}�N��\r\n��ĳ���~�X�A�~�X�ɰ���ۥi�O���D�n���窫�A�ȥ��T�O�����ӷ��H�ɥR���I"; });
            }

            else if (HeatIndex >= 54)
            {
                label_HeatIndexText.InvokeIfRequired(() => { label_HeatIndexText.ForeColor = Color.Red; });
                label_ClassificationText.InvokeIfRequired(() =>
                {
                    label_ClassificationText.Text = "���צM�I";
                    label_ClassificationText.ForeColor = Color.Red;
                });
                label_PossibleSymptomText.InvokeIfRequired(() => { label_PossibleSymptomText.Text = "�u���Y�������i��"; });
                label_SolutionText.InvokeIfRequired(() => { label_SolutionText.Text = "�Ǥ��ȥ��T�O�N���H�ɦb�B��\r\n�j�P��ĳ���~�X�A���n�ɥ~�X�ȥ��H�ɽT�O�����ӷ��R���øɥR�����I"; });
            }

            if (HeatIndex == -2)
            {
                label_HeatIndexText.InvokeIfRequired(() => { label_HeatIndexText.ForeColor = Color.Black; });
                label_ClassificationText.InvokeIfRequired(() =>
                {
                    label_ClassificationText.Text = "�L�k�T�w";
                    label_ClassificationText.ForeColor = Color.Black;
                });
                label_PossibleSymptomText.InvokeIfRequired(() => { label_PossibleSymptomText.Text = "�L�k�T�w"; });
                label_SolutionText.InvokeIfRequired(() => { label_SolutionText.Text = "�H�ɯd�N����A������I"; });
            }
        }

        private void ShowErrorMessage(object sender, ErrorArgs e)
        {
            switch ((int)e.ErrorType)
            {
                case 0:
                    MessageBox.Show(String.Format("�����ծդ�\r\n\r\n{0}", e.ErrorMessage), "ĵ�i", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 1:
                    MessageBox.Show(String.Format("�o�͹w���~�����p\r\n\r\n{0}", e.ErrorMessage), "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show(e.ErrorMessage, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void FormCalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            calculator.Dispose();
        }

        private void button_setting_Click(object sender, EventArgs e)
        {
            SettingForm = new SettingForm();
            SettingForm.ShowDialog();
        }
    }
}