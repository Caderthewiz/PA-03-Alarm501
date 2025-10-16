using Alarm501_MC;

namespace Alarm501_GUI
{
    public partial class MainForm : Form
    {
        public CheckTriggerDel CheckTrigger;
        public GetAlarmDel GetAlarms;
        public UpdateAlarmDel UpdateAlarm;
        public AddAlarmDel AddAlarm;

        public MainForm()
        {
            InitializeComponent();
        }

        public void HandleTimerTick(DateTime now, IEnumerable<Alarm> alarms)
        {
            //Marshal UI updates to UI thread?
            if (uxTimeLabel.InvokeRequired)
            {
                uxTimeLabel.Invoke(() => HandleTimerTick(now, alarms));
                return;
            }

            uxTimeLabel.Text = $"Time: {now:hh:mm:ss tt}";

            foreach (Alarm alarm in alarms)
            {
                if (CheckTrigger(alarm, now))
                {
                    uxSnoozeBtn.Enabled = true;
                    uxStopBtn.Enabled = true;
                    alarm.WentOff = true;

                    MessageBox.Show($"Alarm went off!\nSound: {alarm.Sound}\nSnooze: {alarm.SnoozeMinutes} min",
                                    "Alarm Notification",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                    );
                }
            }
        }

        #region UI Methods

        public void LoadAlarmsToListBox()
        {
            uxAlarmLB.Items.Clear();
            foreach (Alarm alarm in GetAlarms())
            {
                uxAlarmLB.Items.Add(alarm);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (uxAlarmLB.SelectedIndex >= 0) //Selected Item != null
            {
                Alarm selectedAlarm = (Alarm)uxAlarmLB.SelectedItem!;
                AddEditForm addeditAlarm = new AddEditForm { Alarm = selectedAlarm };
                addeditAlarm.ShowDialog();

                UpdateAlarm(uxAlarmLB.SelectedIndex, addeditAlarm.Alarm);
                LoadAlarmsToListBox();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditForm addEditAlarm = new AddEditForm();
            addEditAlarm.ShowDialog();

            if (addEditAlarm.Alarm != null)
            {
                AddAlarm(addEditAlarm.Alarm);
                LoadAlarmsToListBox();

                if (uxAlarmLB.Items.Count == 5)
                    uxAddBtn.Enabled = false;
            }
        }

        private void SnoozeBtn_Click(object sender, EventArgs e)
        {
            uxSnoozeBtn.Enabled = false;
            uxStopBtn.Enabled = false;
            uxStatusLabel.Text = "Alarm Snoozed";

            for (int i = 0; i < uxAlarmLB.Items.Count; i++)
            {
                if (uxAlarmLB.Items[i] is Alarm alarm && alarm.WentOff)
                {
                    alarm.Time = DateTime.Now.AddMinutes(alarm.SnoozeMinutes);
                    alarm.WentOff = false;

                    UpdateAlarm(i, alarm);
                    LoadAlarmsToListBox();
                    break;
                }
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            uxStopBtn.Enabled = false;
            uxSnoozeBtn.Enabled = false;
            uxStatusLabel.Text = "Alarm Stopped";
        }

        #endregion
    }
}
