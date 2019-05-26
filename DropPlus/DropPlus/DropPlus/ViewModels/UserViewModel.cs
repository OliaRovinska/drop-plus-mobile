using System;
using DropPlus.Enums;

namespace DropPlus.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public string UserName => FirstName + " " + LastName;

        private string _photo;
        public string Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged();
            }
        }

        private string _location;
        public string Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged();
            }
        }

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        private SexEnum _sex;
        public SexEnum Sex
        {
            get => _sex;
            set
            {
                _sex = value;
                OnPropertyChanged();
            }
        }

        private int _height;
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged();
            }
        }

        private int _weight;
        public int Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }

        private TimeSpan _wakeUpHour;
        public TimeSpan WakeUpHour
        {
            get => _wakeUpHour;
            set
            {
                _wakeUpHour = value;
                OnPropertyChanged();
            }
        }

        private TimeSpan _sleepHour;
        public TimeSpan SleepHour
        {
            get => _sleepHour;
            set
            {
                _sleepHour = value;
                OnPropertyChanged();
            }
        }

        public string DayHours => WakeUpHour.ToString(@"hh\:mm") + " - " + SleepHour.ToString(@"hh\:mm");
    }
}