using System;
using System.Collections.Generic;
using DropPlus.Enums;

namespace DropPlus.Models
{
    public class UserModel
    {
        public UserModel()
        {
            FavouriteResorts = new List<ResortModel>();
        }

        public string Id { get; set; }
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
        public List<ResortModel> FavouriteResorts { get; set; }
    }
}