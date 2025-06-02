namespace SimpleClock
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timerClcok = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.txtStopWatch = new System.Windows.Forms.TextBox();
            this.listStopWatchLog = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.cmbCountHour = new System.Windows.Forms.ComboBox();
            this.cmbCountMin = new System.Windows.Forms.ComboBox();
            this.cmbCountSecond = new System.Windows.Forms.ComboBox();
            this.btnCountStart = new System.Windows.Forms.Button();
            this.btnCountPause = new System.Windows.Forms.Button();
            this.btnCountStop = new System.Windows.Forms.Button();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbMin);
            this.tabPage1.Controls.Add(this.cmbHour);
            this.tabPage1.Controls.Add(this.btnCancelAlert);
            this.tabPage1.Controls.Add(this.btnSetAlert);
            this.tabPage1.Controls.Add(this.txtWeekDay);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(894, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "時鐘";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(234, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbMin
            // 
            this.cmbMin.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(300, 323);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(150, 38);
            this.cmbMin.TabIndex = 6;
            // 
            // cmbHour
            // 
            this.cmbHour.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "00"});
            this.cmbHour.Location = new System.Drawing.Point(12, 323);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(176, 38);
            this.cmbHour.TabIndex = 5;
            // 
            // btnCancelAlert
            // 
            this.btnCancelAlert.Location = new System.Drawing.Point(690, 284);
            this.btnCancelAlert.Name = "btnCancelAlert";
            this.btnCancelAlert.Size = new System.Drawing.Size(165, 119);
            this.btnCancelAlert.TabIndex = 4;
            this.btnCancelAlert.Text = "關閉鬧鐘";
            this.btnCancelAlert.UseVisualStyleBackColor = true;
            this.btnCancelAlert.Click += new System.EventHandler(this.btnCancelAlert_Click);
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Location = new System.Drawing.Point(504, 284);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(165, 119);
            this.btnSetAlert.TabIndex = 3;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
            this.btnSetAlert.Click += new System.EventHandler(this.btnSetAlert_Click);
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.Enabled = false;
            this.txtWeekDay.Font = new System.Drawing.Font("新細明體", 48F);
            this.txtWeekDay.Location = new System.Drawing.Point(535, 153);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(354, 103);
            this.txtWeekDay.TabIndex = 2;
            this.txtWeekDay.Text = "test";
            this.txtWeekDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("新細明體", 48F);
            this.txtDate.Location = new System.Drawing.Point(-1, 153);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(530, 103);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "test";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("新細明體", 72F);
            this.txtTime.Location = new System.Drawing.Point(-1, 0);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(890, 147);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "test";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.btnLog);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnPause);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.listStopWatchLog);
            this.tabPage2.Controls.Add(this.txtStopWatch);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(894, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "碼表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCountStop);
            this.tabPage3.Controls.Add(this.btnCountPause);
            this.tabPage3.Controls.Add(this.btnCountStart);
            this.tabPage3.Controls.Add(this.cmbCountSecond);
            this.tabPage3.Controls.Add(this.cmbCountMin);
            this.tabPage3.Controls.Add(this.cmbCountHour);
            this.tabPage3.Controls.Add(this.txtCountDown);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(894, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "倒數";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timerClcok
            // 
            this.timerClcok.Tick += new System.EventHandler(this.timerClcok_Tick);
            // 
            // timerAlert
            // 
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // txtStopWatch
            // 
            this.txtStopWatch.Enabled = false;
            this.txtStopWatch.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStopWatch.Location = new System.Drawing.Point(3, 0);
            this.txtStopWatch.Multiline = true;
            this.txtStopWatch.Name = "txtStopWatch";
            this.txtStopWatch.ReadOnly = true;
            this.txtStopWatch.Size = new System.Drawing.Size(886, 140);
            this.txtStopWatch.TabIndex = 0;
            this.txtStopWatch.Text = "00:00:00:00";
            this.txtStopWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listStopWatchLog
            // 
            this.listStopWatchLog.FormattingEnabled = true;
            this.listStopWatchLog.ItemHeight = 23;
            this.listStopWatchLog.Location = new System.Drawing.Point(5, 136);
            this.listStopWatchLog.Name = "listStopWatchLog";
            this.listStopWatchLog.Size = new System.Drawing.Size(245, 234);
            this.listStopWatchLog.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(321, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 57);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(492, 146);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(141, 57);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(321, 209);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 57);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "歸零";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(492, 209);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(141, 57);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "紀錄";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(321, 272);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(312, 39);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止並歸零";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // txtCountDown
            // 
            this.txtCountDown.Enabled = false;
            this.txtCountDown.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCountDown.Location = new System.Drawing.Point(0, 0);
            this.txtCountDown.Multiline = true;
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(886, 140);
            this.txtCountDown.TabIndex = 1;
            this.txtCountDown.Text = "00:00:00";
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCountHour
            // 
            this.cmbCountHour.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCountHour.FormattingEnabled = true;
            this.cmbCountHour.Location = new System.Drawing.Point(40, 167);
            this.cmbCountHour.Name = "cmbCountHour";
            this.cmbCountHour.Size = new System.Drawing.Size(121, 38);
            this.cmbCountHour.TabIndex = 2;
            // 
            // cmbCountMin
            // 
            this.cmbCountMin.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCountMin.FormattingEnabled = true;
            this.cmbCountMin.Location = new System.Drawing.Point(167, 167);
            this.cmbCountMin.Name = "cmbCountMin";
            this.cmbCountMin.Size = new System.Drawing.Size(121, 38);
            this.cmbCountMin.TabIndex = 3;
            // 
            // cmbCountSecond
            // 
            this.cmbCountSecond.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCountSecond.FormattingEnabled = true;
            this.cmbCountSecond.Location = new System.Drawing.Point(294, 167);
            this.cmbCountSecond.Name = "cmbCountSecond";
            this.cmbCountSecond.Size = new System.Drawing.Size(121, 38);
            this.cmbCountSecond.TabIndex = 4;
            // 
            // btnCountStart
            // 
            this.btnCountStart.Location = new System.Drawing.Point(40, 225);
            this.btnCountStart.Name = "btnCountStart";
            this.btnCountStart.Size = new System.Drawing.Size(297, 45);
            this.btnCountStart.TabIndex = 5;
            this.btnCountStart.Text = "開始倒數";
            this.btnCountStart.UseVisualStyleBackColor = true;
            this.btnCountStart.Click += new System.EventHandler(this.btnCountStart_Click);
            // 
            // btnCountPause
            // 
            this.btnCountPause.Location = new System.Drawing.Point(40, 276);
            this.btnCountPause.Name = "btnCountPause";
            this.btnCountPause.Size = new System.Drawing.Size(297, 45);
            this.btnCountPause.TabIndex = 6;
            this.btnCountPause.Text = "暫停";
            this.btnCountPause.UseVisualStyleBackColor = true;
            this.btnCountPause.Click += new System.EventHandler(this.btnCountPause_Click);
            // 
            // btnCountStop
            // 
            this.btnCountStop.Location = new System.Drawing.Point(40, 327);
            this.btnCountStop.Name = "btnCountStop";
            this.btnCountStop.Size = new System.Drawing.Size(297, 45);
            this.btnCountStop.TabIndex = 7;
            this.btnCountStop.Text = "停止";
            this.btnCountStop.UseVisualStyleBackColor = true;
            this.btnCountStop.Click += new System.EventHandler(this.btnCountStop_Click);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 512);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "簡單時間";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnSetAlert;
        private System.Windows.Forms.Button btnCancelAlert;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Timer timerClcok;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.TextBox txtStopWatch;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listStopWatchLog;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.ComboBox cmbCountHour;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Button btnCountStop;
        private System.Windows.Forms.Button btnCountPause;
        private System.Windows.Forms.Button btnCountStart;
        private System.Windows.Forms.ComboBox cmbCountSecond;
        private System.Windows.Forms.ComboBox cmbCountMin;
        private System.Windows.Forms.Timer timerCountDown;
    }
}

