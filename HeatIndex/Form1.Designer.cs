namespace HeatIndex
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_stations = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_HeatIndexText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ClassificationText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_PossibleSymptomText = new System.Windows.Forms.Label();
            this.label_SolutionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "測站名稱：";
            // 
            // comboBox_stations
            // 
            this.comboBox_stations.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_stations.FormattingEnabled = true;
            this.comboBox_stations.Items.AddRange(new object[] {
            "斗南",
            "中央大學",
            "臺灣大學",
            "中壢",
            "大安森林"});
            this.comboBox_stations.Location = new System.Drawing.Point(12, 61);
            this.comboBox_stations.Name = "comboBox_stations";
            this.comboBox_stations.Size = new System.Drawing.Size(196, 42);
            this.comboBox_stations.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 121);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算酷熱指數";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(301, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "酷熱指數：";
            // 
            // label_HeatIndexText
            // 
            this.label_HeatIndexText.AutoSize = true;
            this.label_HeatIndexText.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_HeatIndexText.Location = new System.Drawing.Point(442, 16);
            this.label_HeatIndexText.Name = "label_HeatIndexText";
            this.label_HeatIndexText.Size = new System.Drawing.Size(21, 34);
            this.label_HeatIndexText.TabIndex = 4;
            this.label_HeatIndexText.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(301, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "影響程度：";
            // 
            // label_ClassificationText
            // 
            this.label_ClassificationText.AutoSize = true;
            this.label_ClassificationText.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ClassificationText.Location = new System.Drawing.Point(442, 108);
            this.label_ClassificationText.Name = "label_ClassificationText";
            this.label_ClassificationText.Size = new System.Drawing.Size(21, 34);
            this.label_ClassificationText.TabIndex = 6;
            this.label_ClassificationText.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(301, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "可能症狀：";
            // 
            // label_PossibleSymptomText
            // 
            this.label_PossibleSymptomText.AutoSize = true;
            this.label_PossibleSymptomText.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_PossibleSymptomText.Location = new System.Drawing.Point(442, 198);
            this.label_PossibleSymptomText.Name = "label_PossibleSymptomText";
            this.label_PossibleSymptomText.Size = new System.Drawing.Size(21, 34);
            this.label_PossibleSymptomText.TabIndex = 8;
            this.label_PossibleSymptomText.Text = " ";
            // 
            // label_SolutionText
            // 
            this.label_SolutionText.AutoSize = true;
            this.label_SolutionText.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_SolutionText.Location = new System.Drawing.Point(442, 240);
            this.label_SolutionText.Name = "label_SolutionText";
            this.label_SolutionText.Size = new System.Drawing.Size(21, 34);
            this.label_SolutionText.TabIndex = 9;
            this.label_SolutionText.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 383);
            this.Controls.Add(this.label_SolutionText);
            this.Controls.Add(this.label_PossibleSymptomText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ClassificationText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_HeatIndexText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_stations);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "酷熱指數計算機";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_stations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_HeatIndexText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ClassificationText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_PossibleSymptomText;
        private System.Windows.Forms.Label label_SolutionText;
    }
}

