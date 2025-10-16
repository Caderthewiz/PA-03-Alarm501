namespace Alarm501_GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            uxEditBtn = new Button();
            uxAddBtn = new Button();
            uxSnoozeBtn = new Button();
            uxStopBtn = new Button();
            uxTimeLabel = new Label();
            uxStatusLabel = new Label();
            uxAlarmLB = new ListBox();
            SuspendLayout();
            // 
            // uxEditBtn
            // 
            uxEditBtn.Location = new Point(12, 12);
            uxEditBtn.Name = "uxEditBtn";
            uxEditBtn.Size = new Size(80, 35);
            uxEditBtn.TabIndex = 0;
            uxEditBtn.Text = "Edit";
            uxEditBtn.UseVisualStyleBackColor = true;
            uxEditBtn.Click += EditBtn_Click;
            // 
            // uxAddBtn
            // 
            uxAddBtn.Location = new Point(147, 12);
            uxAddBtn.Name = "uxAddBtn";
            uxAddBtn.Size = new Size(80, 35);
            uxAddBtn.TabIndex = 1;
            uxAddBtn.Text = "+";
            uxAddBtn.UseVisualStyleBackColor = true;
            uxAddBtn.Click += AddBtn_Click;
            // 
            // uxSnoozeBtn
            // 
            uxSnoozeBtn.Enabled = false;
            uxSnoozeBtn.Location = new Point(12, 299);
            uxSnoozeBtn.Name = "uxSnoozeBtn";
            uxSnoozeBtn.Size = new Size(80, 35);
            uxSnoozeBtn.TabIndex = 2;
            uxSnoozeBtn.Text = "Snooze";
            uxSnoozeBtn.UseVisualStyleBackColor = true;
            uxSnoozeBtn.Click += SnoozeBtn_Click;
            // 
            // uxStopBtn
            // 
            uxStopBtn.Enabled = false;
            uxStopBtn.Location = new Point(147, 299);
            uxStopBtn.Name = "uxStopBtn";
            uxStopBtn.Size = new Size(80, 35);
            uxStopBtn.TabIndex = 3;
            uxStopBtn.Text = "Stop";
            uxStopBtn.UseVisualStyleBackColor = true;
            uxStopBtn.Click += StopBtn_Click;
            // 
            // uxTimeLabel
            // 
            uxTimeLabel.AutoSize = true;
            uxTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uxTimeLabel.Location = new Point(49, 50);
            uxTimeLabel.Name = "uxTimeLabel";
            uxTimeLabel.Size = new Size(136, 21);
            uxTimeLabel.TabIndex = 4;
            uxTimeLabel.Text = "Time 00:00:00 AM";
            uxTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uxStatusLabel
            // 
            uxStatusLabel.AutoSize = true;
            uxStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uxStatusLabel.Location = new Point(94, 276);
            uxStatusLabel.Name = "uxStatusLabel";
            uxStatusLabel.Size = new Size(52, 21);
            uxStatusLabel.TabIndex = 5;
            uxStatusLabel.Text = "Status";
            uxStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uxAlarmLB
            // 
            uxAlarmLB.FormattingEnabled = true;
            uxAlarmLB.ItemHeight = 15;
            uxAlarmLB.Location = new Point(33, 74);
            uxAlarmLB.Name = "uxAlarmLB";
            uxAlarmLB.ScrollAlwaysVisible = true;
            uxAlarmLB.Size = new Size(175, 199);
            uxAlarmLB.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 346);
            Controls.Add(uxAlarmLB);
            Controls.Add(uxStatusLabel);
            Controls.Add(uxTimeLabel);
            Controls.Add(uxStopBtn);
            Controls.Add(uxSnoozeBtn);
            Controls.Add(uxAddBtn);
            Controls.Add(uxEditBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxEditBtn;
        private Button uxAddBtn;
        private Button uxSnoozeBtn;
        private Button uxStopBtn;
        private Label uxTimeLabel;
        private Label uxStatusLabel;
        private ListBox uxAlarmLB;
    }
}
