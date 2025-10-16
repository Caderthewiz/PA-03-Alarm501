using System.Security.Claims;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Alarm501_MC
{
    public class AlarmController
    {
        private readonly List<Alarm> _alarms;
        private readonly Timer _timer;

        public delegate void TimerTickDel(DateTime now, List<Alarm> alarms);
        public TimerTickDel? TimerTick;

        public AlarmController()
        {
            _alarms = new List<Alarm>();
            LoadAlarms();

            _timer = new Timer(1000);
            _timer.Elapsed += (sender, e) => { TimerTick?.Invoke(DateTime.Now, _alarms); };
            _timer.Start();
        }

        public bool CheckTrigger(Alarm alarm, DateTime now)
        {
            if (!alarm.Enabled) return false;

            bool matchTime = alarm.Time.Hour == now.Hour &&
                             alarm.Time.Minute == now.Minute &&
                             alarm.Time.Second == now.Second;

            if (!matchTime) return false;

            switch (alarm.Repeat)
            {
                case Schedule.Once:
                    return alarm.Time.Date == now.Date;
                case Schedule.Daily:
                    return true;
                case Schedule.Weekdays:
                    return now.DayOfWeek >= DayOfWeek.Monday && now.DayOfWeek <= DayOfWeek.Friday;
                case Schedule.Weekends:
                    return now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday;
                case Schedule.Custom:
                    return alarm.CustomDays.Contains(now.DayOfWeek);
            }
            return false;
        }

        public void AddAlarm(Alarm alarm)
        {
            if (_alarms.Count < 5)
            {
                _alarms.Add(alarm);
                SaveAlarms();
            }
        }

        public void UpdateAlarm(int index, Alarm alarm)
        {
            if (index >= 0 && index < _alarms.Count)
            {
                _alarms[index] = alarm;
                SaveAlarms();
            }
        }

        public List<Alarm> GetAlarms() => _alarms;

        private void LoadAlarms()
        {
            if (!File.Exists("alarms.txt")) return;

            using (StreamReader sr = new StreamReader("alarms.txt"))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] strArr = line.Split('-');

                    string format = "yyyy MM dd hh mm ss tt";
                    DateTime time = DateTime.ParseExact(strArr[0], format, System.Globalization.CultureInfo.InvariantCulture);

                    bool enabled = strArr[1] == "On";

                    Sound sound = (Sound)Enum.Parse(typeof(Sound), strArr[2]);

                    int min = int.Parse(strArr[3]);

                    Schedule repeat = (Schedule)Enum.Parse(typeof(Schedule), strArr[4]);

                    List<DayOfWeek> customDays = new List<DayOfWeek>();
                    foreach (string day in strArr[5].Split(','))
                    {
                        if (Enum.TryParse(day, out DayOfWeek dayOfWeek))
                            customDays.Add(dayOfWeek);
                    }

                    _alarms.Add(new Alarm(time, enabled, min, sound, repeat, customDays));
                }
            }
        }

        private void SaveAlarms()
        {
            using (StreamWriter sw = new StreamWriter("alarms.txt", false))
            {
                foreach (Alarm alarm in _alarms)
                {
                    string customDaysStr = alarm.CustomDays.Count > 0 ? string.Join(",", alarm.CustomDays) : "";
                    
                    string line = $"{alarm.Time.ToString("yyyy MM dd hh mm ss tt")}-" +
                                  $"{(alarm.Enabled ? "On" : "Off")}-" +
                                  $"{alarm.Sound}-" +
                                  $"{alarm.SnoozeMinutes}-" +
                                  $"{alarm.Repeat}-" +
                                  $"{customDaysStr}";

                    sw.WriteLine(line);
                }
            }
        }
    }
}
