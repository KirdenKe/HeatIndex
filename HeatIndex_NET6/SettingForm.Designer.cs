namespace HeatIndex_NET6
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBox_SelectedStation = new ListBox();
            button_remove = new Button();
            label_station = new Label();
            listBox_station = new ListBox();
            button_cancel = new Button();
            button_refresh = new Button();
            button_confirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 0;
            label1.Text = "所選測站";
            // 
            // listBox_SelectedStation
            // 
            listBox_SelectedStation.AllowDrop = true;
            listBox_SelectedStation.FormattingEnabled = true;
            listBox_SelectedStation.ItemHeight = 29;
            listBox_SelectedStation.Location = new Point(12, 41);
            listBox_SelectedStation.Name = "listBox_SelectedStation";
            listBox_SelectedStation.Size = new Size(196, 207);
            listBox_SelectedStation.TabIndex = 1;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(12, 254);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(92, 57);
            button_remove.TabIndex = 2;
            button_remove.Text = "移除";
            button_remove.UseVisualStyleBackColor = true;
            // 
            // label_station
            // 
            label_station.AutoSize = true;
            label_station.Location = new Point(326, 9);
            label_station.Name = "label_station";
            label_station.Size = new Size(105, 29);
            label_station.TabIndex = 3;
            label_station.Text = "所有測站";
            // 
            // listBox_station
            // 
            listBox_station.AllowDrop = true;
            listBox_station.FormattingEnabled = true;
            listBox_station.ItemHeight = 29;
            listBox_station.Location = new Point(326, 41);
            listBox_station.Name = "listBox_station";
            listBox_station.Size = new Size(196, 207);
            listBox_station.TabIndex = 4;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(521, 314);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(92, 57);
            button_cancel.TabIndex = 5;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            button_refresh.Location = new Point(576, 99);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(150, 93);
            button_refresh.TabIndex = 6;
            button_refresh.Text = "重新整理";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // button_confirm
            // 
            button_confirm.Location = new Point(634, 314);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(92, 57);
            button_confirm.TabIndex = 7;
            button_confirm.Text = "確定";
            button_confirm.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(738, 383);
            Controls.Add(button_confirm);
            Controls.Add(button_refresh);
            Controls.Add(button_cancel);
            Controls.Add(listBox_station);
            Controls.Add(label_station);
            Controls.Add(button_remove);
            Controls.Add(listBox_SelectedStation);
            Controls.Add(label1);
            Font = new Font("微軟正黑體", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "SettingForm";
            Text = "設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox_SelectedStation;
        private Button button_remove;
        private Label label_station;
        private ListBox listBox_station;
        private Button button_cancel;
        private Button button_refresh;
        private Button button_confirm;
    }
}