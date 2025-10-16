namespace Alarm501_GUI
{
    partial class AddEditForm
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
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UxSetAlarmBtn = new System.Windows.Forms.Button();
            this.UxCancelAlarmBtn = new System.Windows.Forms.Button();
            this.uxEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.uxSnoozeUpDown = new System.Windows.Forms.NumericUpDown();
            this.UxSnoozeLabel = new System.Windows.Forms.Label();
            this.uxSoundCB = new System.Windows.Forms.ComboBox();
            this.uxRepeatCB = new System.Windows.Forms.ComboBox();
            this.UxSoundLabel = new System.Windows.Forms.Label();
            this.UxRepeatLabel = new System.Windows.Forms.Label();
            this.uxMon = new System.Windows.Forms.CheckBox();
            this.uxTue = new System.Windows.Forms.CheckBox();
            this.uxWed = new System.Windows.Forms.CheckBox();
            this.uxThur = new System.Windows.Forms.CheckBox();
            this.uxFri = new System.Windows.Forms.CheckBox();
            this.uxSat = new System.Windows.Forms.CheckBox();
            this.uxSun = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UxDateTimePicker
            // 
            this.uxDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxDateTimePicker.Location = new System.Drawing.Point(89, 9);
            this.uxDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.uxDateTimePicker.Name = "UxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.uxDateTimePicker.TabIndex = 0;
            this.uxDateTimePicker.Value = new System.DateTime(2021, 1, 29, 22, 30, 0, 0);
            // 
            // UxSetAlarmBtn
            // 
            this.UxSetAlarmBtn.Location = new System.Drawing.Point(248, 128);
            this.UxSetAlarmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UxSetAlarmBtn.Name = "UxSetAlarmBtn";
            this.UxSetAlarmBtn.Size = new System.Drawing.Size(57, 30);
            this.UxSetAlarmBtn.TabIndex = 1;
            this.UxSetAlarmBtn.Text = "Set";
            this.UxSetAlarmBtn.UseVisualStyleBackColor = true;
            this.UxSetAlarmBtn.Click += new System.EventHandler(this.UxSetAlarmBtn_Click);
            // 
            // UxCancelAlarmBtn
            // 
            this.UxCancelAlarmBtn.Location = new System.Drawing.Point(88, 128);
            this.UxCancelAlarmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UxCancelAlarmBtn.Name = "UxCancelAlarmBtn";
            this.UxCancelAlarmBtn.Size = new System.Drawing.Size(57, 30);
            this.UxCancelAlarmBtn.TabIndex = 2;
            this.UxCancelAlarmBtn.Text = "Cancel";
            this.UxCancelAlarmBtn.UseVisualStyleBackColor = true;
            this.UxCancelAlarmBtn.Click += new System.EventHandler(this.UxCancelAlarmBtn_Click);
            // 
            // UxEnabledCheckBox
            // 
            this.uxEnabledCheckBox.AutoSize = true;
            this.uxEnabledCheckBox.Location = new System.Drawing.Point(249, 12);
            this.uxEnabledCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxEnabledCheckBox.Name = "UxEnabledCheckBox";
            this.uxEnabledCheckBox.Size = new System.Drawing.Size(40, 17);
            this.uxEnabledCheckBox.TabIndex = 3;
            this.uxEnabledCheckBox.Text = "On";
            this.uxEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // UxSnoozeUpDown
            // 
            this.uxSnoozeUpDown.Location = new System.Drawing.Point(174, 135);
            this.uxSnoozeUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uxSnoozeUpDown.Name = "UxSnoozeUpDown";
            this.uxSnoozeUpDown.Size = new System.Drawing.Size(40, 20);
            this.uxSnoozeUpDown.TabIndex = 4;
            this.uxSnoozeUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // UxSnoozeLabel
            // 
            this.UxSnoozeLabel.AutoSize = true;
            this.UxSnoozeLabel.Location = new System.Drawing.Point(159, 119);
            this.UxSnoozeLabel.Name = "UxSnoozeLabel";
            this.UxSnoozeLabel.Size = new System.Drawing.Size(72, 13);
            this.UxSnoozeLabel.TabIndex = 5;
            this.UxSnoozeLabel.Text = "Snooze Timer";
            this.UxSnoozeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UxSoundComboBox
            // 
            this.uxSoundCB.FormattingEnabled = true;
            this.uxSoundCB.Location = new System.Drawing.Point(89, 48);
            this.uxSoundCB.Name = "UxSoundComboBox";
            this.uxSoundCB.Size = new System.Drawing.Size(104, 21);
            this.uxSoundCB.TabIndex = 6;
            // 
            // UxRepeatComboBox
            // 
            this.uxRepeatCB.FormattingEnabled = true;
            this.uxRepeatCB.Location = new System.Drawing.Point(202, 48);
            this.uxRepeatCB.Name = "UxRepeatComboBox";
            this.uxRepeatCB.Size = new System.Drawing.Size(104, 21);
            this.uxRepeatCB.TabIndex = 7;
            // 
            // UxSoundLabel
            // 
            this.UxSoundLabel.AutoSize = true;
            this.UxSoundLabel.Location = new System.Drawing.Point(86, 32);
            this.UxSoundLabel.Name = "UxSoundLabel";
            this.UxSoundLabel.Size = new System.Drawing.Size(38, 13);
            this.UxSoundLabel.TabIndex = 8;
            this.UxSoundLabel.Text = "Sound";
            this.UxSoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UxRepeatLabel
            // 
            this.UxRepeatLabel.AutoSize = true;
            this.UxRepeatLabel.Location = new System.Drawing.Point(199, 32);
            this.UxRepeatLabel.Name = "UxRepeatLabel";
            this.UxRepeatLabel.Size = new System.Drawing.Size(42, 13);
            this.UxRepeatLabel.TabIndex = 9;
            this.UxRepeatLabel.Text = "Repeat";
            // 
            // UxMon
            // 
            this.uxMon.AutoSize = true;
            this.uxMon.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uxMon.Location = new System.Drawing.Point(-1, 78);
            this.uxMon.Name = "UxMon";
            this.uxMon.Size = new System.Drawing.Size(49, 31);
            this.uxMon.TabIndex = 10;
            this.uxMon.Text = "Monday";
            this.uxMon.UseVisualStyleBackColor = true;
            // 
            // UxTue
            // 
            this.uxTue.AutoSize = true;
            this.uxTue.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uxTue.Location = new System.Drawing.Point(54, 78);
            this.uxTue.Name = "UxTue";
            this.uxTue.Size = new System.Drawing.Size(52, 31);
            this.uxTue.TabIndex = 11;
            this.uxTue.Text = "Tuesday";
            this.uxTue.UseVisualStyleBackColor = true;
            // 
            // UxWed
            // 
            this.uxWed.AutoSize = true;
            this.uxWed.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uxWed.Location = new System.Drawing.Point(112, 78);
            this.uxWed.Name = "UxWed";
            this.uxWed.Size = new System.Drawing.Size(68, 31);
            this.uxWed.TabIndex = 12;
            this.uxWed.Text = "Wednesday";
            this.uxWed.UseVisualStyleBackColor = true;
            // 
            // UxThur
            // 
            this.uxThur.AutoSize = true;
            this.uxThur.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uxThur.Location = new System.Drawing.Point(186, 78);
            this.uxThur.Name = "UxThur";
            this.uxThur.Size = new System.Drawing.Size(55, 31);
            this.uxThur.TabIndex = 13;
            this.uxThur.Text = "Thursday";
            this.uxThur.UseVisualStyleBackColor = true;
            // 
            // UxFri
            // 
            this.uxFri.AutoSize = true;
            this.uxFri.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uxFri.Location = new System.Drawing.Point(247, 78);
            this.uxFri.Name = "UxFri";
            this.uxFri.Size = new System.Drawing.Size(39, 31);
            this.uxFri.TabIndex = 14;
            this.uxFri.Text = "Friday";
            this.uxFri.UseVisualStyleBackColor = true;
            // 
            // UxSat
            // 
            this.uxSat.AutoSize = true;
            this.uxSat.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uxSat.Location = new System.Drawing.Point(292, 78);
            this.uxSat.Name = "UxSat";
            this.uxSat.Size = new System.Drawing.Size(53, 31);
            this.uxSat.TabIndex = 15;
            this.uxSat.Text = "Saturday";
            this.uxSat.UseVisualStyleBackColor = true;
            // 
            // UxSun
            // 
            this.uxSun.AutoSize = true;
            this.uxSun.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uxSun.Location = new System.Drawing.Point(351, 78);
            this.uxSun.Name = "UxSun";
            this.uxSun.Size = new System.Drawing.Size(47, 31);
            this.uxSun.TabIndex = 16;
            this.uxSun.Text = "Sunday";
            this.uxSun.UseVisualStyleBackColor = true;
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 160);
            this.Controls.Add(this.uxSun);
            this.Controls.Add(this.uxSat);
            this.Controls.Add(this.uxFri);
            this.Controls.Add(this.uxThur);
            this.Controls.Add(this.uxWed);
            this.Controls.Add(this.uxTue);
            this.Controls.Add(this.uxMon);
            this.Controls.Add(this.UxRepeatLabel);
            this.Controls.Add(this.UxSoundLabel);
            this.Controls.Add(this.uxRepeatCB);
            this.Controls.Add(this.uxSoundCB);
            this.Controls.Add(this.UxSnoozeLabel);
            this.Controls.Add(this.uxSnoozeUpDown);
            this.Controls.Add(this.uxEnabledCheckBox);
            this.Controls.Add(this.UxCancelAlarmBtn);
            this.Controls.Add(this.UxSetAlarmBtn);
            this.Controls.Add(this.uxDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditAlarm";
            this.Text = "Add/Edit Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.Button UxSetAlarmBtn;
        private System.Windows.Forms.Button UxCancelAlarmBtn;
        private System.Windows.Forms.CheckBox uxEnabledCheckBox;
        private System.Windows.Forms.NumericUpDown uxSnoozeUpDown;
        private System.Windows.Forms.Label UxSnoozeLabel;
        private System.Windows.Forms.ComboBox uxSoundCB;
        private System.Windows.Forms.ComboBox uxRepeatCB;
        private System.Windows.Forms.Label UxSoundLabel;
        private System.Windows.Forms.Label UxRepeatLabel;
        private System.Windows.Forms.CheckBox uxMon;
        private System.Windows.Forms.CheckBox uxTue;
        private System.Windows.Forms.CheckBox uxWed;
        private System.Windows.Forms.CheckBox uxThur;
        private System.Windows.Forms.CheckBox uxFri;
        private System.Windows.Forms.CheckBox uxSat;
        private System.Windows.Forms.CheckBox uxSun;
    }
}