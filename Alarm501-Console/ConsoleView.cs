using Alarm501_MC;

namespace Alarm501_Console
{
    public class ConsoleView
    {
        public CheckTriggerDel CheckTrigger;
        public GetAlarmDel GetAlarms;
        public UpdateAlarmDel UpdateAlarm;
        public AddAlarmDel AddAlarm;

        public ConsoleView() { }

        public void HandleTimerTick(DateTime now, List<Alarm> alarms)
        {
            foreach (Alarm alarm in alarms)
            {
                int alarmIdx = alarms.IndexOf(alarm) + 1;

                if (CheckTrigger(alarm, now))
                {
                    Console.WriteLine($"Alarm {alarmIdx} Went Off! Sound: {alarm.Sound} Repeat: {alarm.Repeat}");
                    Console.WriteLine("(3) Snooze (4) Stop: ");

                    alarm.WentOff = true;
                }
            }
        }

        public void MainDisplay()
        {
            List<Alarm> alarms = GetAlarms();

            Console.Clear();
            Console.WriteLine("*** Console Alarm Menu ***");
            Console.WriteLine("(1) Add (2) Edit (5) Exit\n");
            Console.WriteLine($"Alarms");

            for (int i = 1; i <= alarms.Count; i++)
            {
                Console.WriteLine($"{i}. {alarms[i-1].ToString()}");
            }

            Console.WriteLine();
        }

        public void NewAlarm()
        {
            string input;
            Console.Clear();
            Console.WriteLine("*** Alarm Add ***");

            DateTime time;
            Console.WriteLine("Enter Time (hh:mm:ss tt): ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (DateTime.TryParseExact(input, "hh:mm:ss tt", null, 0, out time)) { break; }
                else { Console.WriteLine("Invalid Date Time"); }
            }

            bool enabled;
            Console.WriteLine("Enable Alarm? (y/n): ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (input.ToLower() == "y")
                {
                    enabled = true;
                    break;
                }
                else if (input.ToLower() == "n")
                {
                    enabled = false;
                    break;
                }
                else { Console.WriteLine("Invalid Bool Input"); }
            }

            Sound sound;
            Console.WriteLine("Enter Sound (Radar, Beacon, Chimes, Circuit, Reflection): ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (Enum.TryParse(input, out sound)) { break; }
                else { Console.WriteLine("Invalid Sound Input"); }
            }

            Schedule repeat;
            Console.WriteLine("Enter Repeat (Once, Daily, Weekdays, Weekends, Custom): ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (Enum.TryParse(input, out repeat)) { break; }
                else { Console.WriteLine("Invalid Schedule Input"); }
            }

            List<DayOfWeek> customDays = new List<DayOfWeek>();
            if (repeat == Schedule.Custom)
            {
                Console.WriteLine("Enter Custom Days (e.g., Monday, Wednesday) separated by commas: ");
                while (true)
                {
                    input = Console.ReadLine() ?? "";
                    string[] days = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string day in days)
                    {
                        if (Enum.TryParse(day.Trim(), out DayOfWeek dayOfWeek)) { customDays.Add(dayOfWeek); }
                        else { break; }
                    }

                    if (days.Length == customDays.Distinct().Count()) { break; }
                    else { Console.WriteLine("Invalid Days Input"); }
                }
            }

            int snoozeMinutes;
            Console.WriteLine("Enter Snooze Minutes (0-10): ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out snoozeMinutes) && (snoozeMinutes >= 0 && snoozeMinutes <= 10)) { break; }
                else { Console.WriteLine("Invalid Snooze Input"); }
            }

            AddAlarm(new Alarm(time, enabled, snoozeMinutes, sound, repeat, customDays));

            Console.Clear();
            Console.WriteLine("Status: Added Alarm");
            Console.ReadLine();
        }

        public void EditAlarm()
        {
            string input;
            int count = GetAlarms().Count;
            int idx = -1;
            Alarm? alarm = null;

            Console.Clear();
            Console.WriteLine("*** Alarm Edit ***");

            Console.WriteLine($"Enter Alarm Number to Edit (1-{count}): ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out idx) && (idx >= 1 && idx <= count))
                {
                    idx--;
                    alarm = GetAlarms()[idx];
                    break;
                }
                else { Console.WriteLine("Invalid Number Input"); }
            }


            Console.WriteLine($"Current Time: {alarm.Time:hh:mm:ss tt}");
            Console.WriteLine("Enter New Time (hh:mm:ss tt) or press Enter to keep current: ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (input == "") { break; }
                if (DateTime.TryParseExact(input, "hh:mm:ss tt", null, 0, out DateTime time))
                {
                    alarm.Time = time;
                    break;
                }
                else { Console.WriteLine("Invalid Date Time"); }
            }


            Console.WriteLine($"Current Enabled: {(alarm.Enabled ? "y" : "n")}");
            Console.WriteLine("Enable Alarm? (y/n) or press Enter to keep current: ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (input == "") { break; }
                if (input.ToLower() == "y")
                {
                    alarm.Enabled = true;
                    break;
                }
                else if (input.ToLower() == "n")
                {
                    alarm.Enabled = false;
                    break;
                }
                else { Console.WriteLine("Invalid Bool Input"); }
            }

            Console.WriteLine($"Current Sound: {alarm.Sound}");
            Console.WriteLine("Enter New Sound (Radar, Beacon, Chimes, Circuit, Reflection) or press Enter to keep current: ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (input == "") { break; }
                if (Enum.TryParse(input, out Sound sound))
                {
                    alarm.Sound = sound;
                    break;
                }
                else { Console.WriteLine("Invalid Sound Input"); }
            }

            Console.WriteLine($"Current Repeat: {alarm.Repeat}");
            Console.WriteLine("Enter New Repeat (Once, Daily, Weekdays, Weekends, Custom) or press Enter to keep current: ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (input == "") { break; }
                if (Enum.TryParse(input, out Schedule schedule))
                {
                    alarm.Repeat = schedule;
                    break;
                }
                else { Console.WriteLine("Invalid Schedule Input"); }
            }

            if (alarm.Repeat == Schedule.Custom)
            {
                alarm.CustomDays.Clear();
                Console.WriteLine("Enter Custom Days (e.g., Monday, Wednesday) separated by commas: ");
                while (true)
                {
                    input = Console.ReadLine() ?? "";
                    string[] days = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string day in days)
                    {
                        if (Enum.TryParse(day.Trim(), out DayOfWeek dayOfWeek)) { alarm.CustomDays.Add(dayOfWeek); }
                        else { break; }
                    }

                    if (days.Length == alarm.CustomDays.Distinct().Count()) { break; }
                    else { Console.WriteLine("Invalid Days Input"); }
                }
            }

            Console.WriteLine($"Current Snooze Minutes: {alarm.SnoozeMinutes}");
            Console.WriteLine("Enter New Snooze Minutes (0-10) or press Enter to keep current: ");
            while (true)
            {
                input = Console.ReadLine() ?? "";
                if (input == "") { break; }
                if (int.TryParse(input, out int snoozeMinutes) && (snoozeMinutes >= 0 && snoozeMinutes <= 10))
                {
                    alarm.SnoozeMinutes = snoozeMinutes;
                    break;
                }
                else { Console.WriteLine("Invalid Snooze Input"); }
            }

            UpdateAlarm(idx, alarm);

            Console.Clear();
            Console.WriteLine($"Status: Updated Alarm {idx + 1}");
            Console.ReadLine();
        }

        //Not working?
        public void SnoozeAlarm() 
        {
            List<Alarm> alarms = GetAlarms();
            for (int i = 0; i < alarms.Count; i++)
            {
                if (alarms[i].WentOff)
                {
                    alarms[i].Time = DateTime.Now.AddMinutes(alarms[i].SnoozeMinutes);
                    alarms[i].WentOff = false;
                    UpdateAlarm(i, alarms[i]);
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine($"Status: Snoozed Alarm");
            Console.ReadLine();
        }

        public void StopAlarm() 
        {
            Console.Clear();
            Console.WriteLine("Status: Stopped Alarm");
            Console.ReadLine();
        }
    }
}
