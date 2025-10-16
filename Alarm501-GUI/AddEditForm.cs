using Alarm501_MC;

namespace Alarm501_GUI
{
    public partial class AddEditForm : Form
    {
        public Alarm Alarm { get; set; }

        public AddEditForm()
        {
            InitializeComponent();
        }

        #region UI Methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            uxSoundCB.DataSource = Enum.GetValues(typeof(Sound));
            uxRepeatCB.DataSource = Enum.GetValues(typeof(Schedule));

            // If editing an existing alarm, preload values
            if (Alarm != null)
            {
                uxDateTimePicker.Value = Alarm.Time;
                uxEnabledCheckBox.Checked = Alarm.Enabled;
                uxSnoozeUpDown.Value = Alarm.SnoozeMinutes;
                uxSoundCB.SelectedItem = Alarm.Sound;
                uxRepeatCB.SelectedItem = Alarm.Repeat;

                //Simplfy
                foreach (DayOfWeek day in Alarm.CustomDays)
                {
                    if (day == DayOfWeek.Monday) { uxMon.Checked = true; }
                    if (day == DayOfWeek.Tuesday) { uxTue.Checked = true; }
                    if (day == DayOfWeek.Wednesday) { uxWed.Checked = true; }
                    if (day == DayOfWeek.Thursday) { uxThur.Checked = true; }
                    if (day == DayOfWeek.Friday) { uxFri.Checked = true; }
                    if (day == DayOfWeek.Saturday) { uxSat.Checked = true; }
                    if (day == DayOfWeek.Sunday) { uxSun.Checked = true; }
                }
            }
        }

        private void UxCancelAlarmBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //Simplfy
        private void UxSetAlarmBtn_Click(object sender, EventArgs e)
        {
            List<DayOfWeek> customDays = new List<DayOfWeek>();
            if ((Schedule)uxRepeatCB.SelectedItem! == Schedule.Custom) //Not null
            {
                if (uxMon.Checked) { customDays.Add(DayOfWeek.Monday); }
                if (uxTue.Checked) { customDays.Add(DayOfWeek.Tuesday); }
                if (uxWed.Checked) { customDays.Add(DayOfWeek.Wednesday); }
                if (uxThur.Checked) { customDays.Add(DayOfWeek.Thursday); }
                if (uxFri.Checked) { customDays.Add(DayOfWeek.Friday); }
                if (uxSat.Checked) { customDays.Add(DayOfWeek.Saturday); }
                if (uxSun.Checked) { customDays.Add(DayOfWeek.Sunday); }
            }

            Alarm = new Alarm(
                uxDateTimePicker.Value,
                uxEnabledCheckBox.Checked,
                (int)uxSnoozeUpDown.Value,
                (Sound)uxSoundCB.SelectedItem!, //Not null
                (Schedule)uxRepeatCB.SelectedItem,
                customDays
            );
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion
    }
}
