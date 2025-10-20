using Alarm501_MC;

namespace Alarm501_Console
{
    public delegate bool CheckTriggerDel(Alarm alarm, DateTime now);
    public delegate List<Alarm> GetAlarmDel();
    public delegate void UpdateAlarmDel(int index, Alarm alarm);
    public delegate void AddAlarmDel(Alarm alarm);

    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmController controller = new AlarmController();
            ConsoleView view = new ConsoleView();

            view.CheckTrigger = controller.CheckTrigger;
            view.GetAlarms = controller.GetAlarms;
            view.UpdateAlarm = controller.UpdateAlarm;
            view.AddAlarm = controller.AddAlarm;
            controller.TimerTick += view.HandleTimerTick;
            

            bool loop = true;
            while (loop)
            {
                view.MainDisplay();
                string input = Console.ReadLine() ?? "";
                switch (input)
                {
                    case "1":
                        view.NewAlarm();
                        break;

                    case "2":
                        view.EditAlarm();
                        break;

                    case "3":
                        view.SnoozeAlarm();
                        break;

                    case "4":
                        view.StopAlarm();
                        break;

                    case "5":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

