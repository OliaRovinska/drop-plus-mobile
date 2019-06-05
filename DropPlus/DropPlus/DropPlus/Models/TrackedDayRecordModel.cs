using System;

namespace DropPlus.Models
{
    public class TrackedDayRecordModel
    {
        public TrackedDayRecordModel()
        {
            Time = DateTime.Now.TimeOfDay;
        }

        public int Id { get; set; }

        public DrinkTypeModel DrinkType { get; set; }

        public int Volume { get; set; }

        public TimeSpan Time { get; set; }
    }
}