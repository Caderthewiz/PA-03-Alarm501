using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501_MC
{
    public class Alarm
    {
        public DateTime Time { get; set; }

        public bool Enabled { get; set; }

        public bool WentOff { get; set; } = false;

        public Sound Sound { get; set; }

        public int SnoozeMinutes { get; set; } = 1;

        public Schedule Repeat { get; set; } = Schedule.Once;

        public List<DayOfWeek> CustomDays { get; set; } = new List<DayOfWeek>();

        public Alarm(DateTime time, bool enabled, int snoozeMinutes, Sound sound = Sound.Radar, Schedule repeat = Schedule.Once, List<DayOfWeek>? customDays = null)
        {
            Time = time;
            Enabled = enabled;
            Sound = sound;
            SnoozeMinutes = snoozeMinutes;
            Repeat = repeat;
            CustomDays = customDays ?? new List<DayOfWeek>();
        }

        public override string ToString() => $"{Time:hh:mm tt} - {(Enabled ? "On" : "Off")}";
    }
}
