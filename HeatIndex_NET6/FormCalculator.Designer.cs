namespace HeatIndex_NET6
{
    partial class FormCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        HeatIndexCalculator calculator = new HeatIndexCalculator();
        Thread OpenWebDriver;
        Form SettingForm;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox_stations = new ComboBox();
            button_calculate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label_HeatIndexText = new Label();
            label_ClassificationText = new Label();
            label_PossibleSymptomText = new Label();
            label_SolutionText = new Label();
            label5 = new Label();
            label_HumidityText = new Label();
            button_setting = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(128, 29);
            label1.TabIndex = 0;
            label1.Text = "測站名稱：";
            // 
            // comboBox_stations
            // 
            comboBox_stations.FormattingEnabled = true;
            comboBox_stations.Items.AddRange(new object[] { "斗南", "中央大學", "中央大學（備用）", "臺灣大學", "中壢", "大安森林" });
            comboBox_stations.Location = new Point(12, 61);
            comboBox_stations.Name = "comboBox_stations";
            comboBox_stations.Size = new Size(196, 37);
            comboBox_stations.TabIndex = 1;
            // 
            // button_calculate
            // 
            button_calculate.Location = new Point(12, 133);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(196, 121);
            button_calculate.TabIndex = 2;
            button_calculate.Text = "計算酷熱指數";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 16);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 3;
            label2.Text = "酷熱指數：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 108);
            label3.Name = "label3";
            label3.Size = new Size(128, 29);
            label3.TabIndex = 4;
            label3.Text = "影響程度：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 198);
            label4.Name = "label4";
            label4.Size = new Size(128, 29);
            label4.TabIndex = 5;
            label4.Text = "可能症狀：";
            // 
            // label_HeatIndexText
            // 
            label_HeatIndexText.AutoSize = true;
            label_HeatIndexText.Location = new Point(442, 16);
            label_HeatIndexText.Name = "label_HeatIndexText";
            label_HeatIndexText.Size = new Size(19, 29);
            label_HeatIndexText.TabIndex = 6;
            label_HeatIndexText.Text = " ";
            // 
            // label_ClassificationText
            // 
            label_ClassificationText.AutoSize = true;
            label_ClassificationText.Location = new Point(442, 108);
            label_ClassificationText.Name = "label_ClassificationText";
            label_ClassificationText.Size = new Size(19, 29);
            label_ClassificationText.TabIndex = 7;
            label_ClassificationText.Text = " ";
            // 
            // label_PossibleSymptomText
            // 
            label_PossibleSymptomText.AutoSize = true;
            label_PossibleSymptomText.Location = new Point(442, 198);
            label_PossibleSymptomText.Name = "label_PossibleSymptomText";
            label_PossibleSymptomText.Size = new Size(19, 29);
            label_PossibleSymptomText.TabIndex = 8;
            label_PossibleSymptomText.Text = " ";
            // 
            // label_SolutionText
            // 
            label_SolutionText.AutoSize = true;
            label_SolutionText.Location = new Point(442, 240);
            label_SolutionText.Name = "label_SolutionText";
            label_SolutionText.Size = new Size(19, 29);
            label_SolutionText.TabIndex = 9;
            label_SolutionText.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(721, 16);
            label5.Name = "label5";
            label5.Size = new Size(82, 29);
            label5.TabIndex = 10;
            label5.Text = "濕度：";
            // 
            // label_HumidityText
            // 
            label_HumidityText.AutoSize = true;
            label_HumidityText.Location = new Point(809, 16);
            label_HumidityText.Name = "label_HumidityText";
            label_HumidityText.Size = new Size(19, 29);
            label_HumidityText.TabIndex = 11;
            label_HumidityText.Text = " ";
            // 
            // button_setting
            // 
            button_setting.BackgroundImage = Properties.Resources.gear;
            button_setting.BackgroundImageLayout = ImageLayout.Zoom;
            button_setting.Location = new Point(1310, 323);
            button_setting.Name = "button_setting";
            button_setting.Size = new Size(48, 48);
            button_setting.TabIndex = 12;
            button_setting.UseVisualStyleBackColor = true;
            button_setting.Click += button_setting_Click;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 383);
            Controls.Add(button_setting);
            Controls.Add(label_HumidityText);
            Controls.Add(label5);
            Controls.Add(label_SolutionText);
            Controls.Add(label_PossibleSymptomText);
            Controls.Add(label_ClassificationText);
            Controls.Add(label_HeatIndexText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_calculate);
            Controls.Add(comboBox_stations);
            Controls.Add(label1);
            Font = new Font("微軟正黑體", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FormCalculator";
            Text = "酷熱指數計算機";
            FormClosed += FormCalculator_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox_stations;
        private Button button_calculate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label_HeatIndexText;
        private Label label_ClassificationText;
        private Label label_PossibleSymptomText;
        private Label label_SolutionText;
        private Label label5;
        private Label label_HumidityText;
        private Button button_setting;
    }
}