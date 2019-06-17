using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DropPlus.Enums;
using DropPlus.Services;
using DropPlus.ViewModels;
using Xamarin.Forms;

namespace DropPlus.Models
{
    public class UserModel
    {
        public UserModel()
        {
            TrackedDays = new List<TrackedDayModel>();
            FavouriteResorts = new List<ResortModel>();
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ImageSource Photo { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public SexEnum Sex { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public TimeSpan WakeUpHour { get; set; }
        public TimeSpan SleepHour { get; set; }
        public List<ResortModel> FavouriteResorts { get; set; }
        public List<TrackedDayModel> TrackedDays { get; set; }

        public TrackedDayModel TrackedToday()
        {
            return TrackedDay(DateTime.Now);
        }

        public TrackedDayModel TrackedDay(DateTime date)
        {
            var result = TrackedDays.FirstOrDefault(trackedDay =>
                trackedDay.Date.ToString("d") == date.ToString("d"));

            if (result == null)
            {
                result = TrackerService.AddTrackedDay(App.User.Goal, date);
            }

            return result;
        }

        public int Goal
        {
            get
            {
                if (IndexOfWeight > 20)
                {
                    return Convert.ToInt32(20 * Math.Pow((Height / 100.0), 2) * 30);
                }
                else
                {
                    return Weight * 30;
                }
            }
        }

        public double IndexOfWeight => Weight / Math.Pow((Height / 100.0), 2);
    }
}