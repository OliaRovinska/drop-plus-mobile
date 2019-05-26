using System;
using DropPlus.Enums;

namespace DropPlus.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public SexEnum Sex { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public TimeSpan WakeUpHour { get; set; }
        public TimeSpan SleepHour { get; set; }
    }
}