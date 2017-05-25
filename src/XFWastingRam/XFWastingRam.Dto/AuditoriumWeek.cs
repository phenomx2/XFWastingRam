using System;
using System.Collections.Generic;

namespace XFWastingRam.Dto
{
    public class AuditoriumWeek
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public IList<Tuple<TimeSpan,TimeSpan>> MondayBusyHours { get; set; }
        public IList<Tuple<TimeSpan, TimeSpan>> TuestdayBusyHours { get; set; }
        public IList<Tuple<TimeSpan, TimeSpan>> WednesdayBusyHours { get; set; }
        public IList<Tuple<TimeSpan, TimeSpan>> ThursdayBusyHours { get; set; }
        public IList<Tuple<TimeSpan, TimeSpan>> FridayBusyHours { get; set; }
        public IList<Tuple<TimeSpan, TimeSpan>> SaturdayBusyHours { get; set; }
        public IList<Tuple<TimeSpan, TimeSpan>> SundayBusyHours { get; set; }
    }
}