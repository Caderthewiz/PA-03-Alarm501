using Alarm501_MC;

namespace Alarm501_GUI
{
    public delegate bool CheckTriggerDel(Alarm alarm, DateTime now);
    public delegate List<Alarm> GetAlarmDel();
    public delegate void UpdateAlarmDel(int index, Alarm alarm);
    public delegate void AddAlarmDel(Alarm alarm);


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AlarmController controller = new AlarmController();
            MainForm mainForm = new MainForm();

            mainForm.CheckTrigger = controller.CheckTrigger;
            mainForm.GetAlarms = controller.GetAlarms;
            mainForm.UpdateAlarm = controller.UpdateAlarm;
            mainForm.AddAlarm = controller.AddAlarm;
            controller.TimerTick += mainForm.HandleTimerTick;

            mainForm.LoadAlarmsToListBox();

            Application.Run(mainForm);
        }
    }
}