﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DropPlus.Enums;
using DropPlus.Models;
using DropPlus.Services;
using Xamarin.Forms;
using Mapper = AutoMapper.Mapper;

namespace DropPlus.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public UserViewModel()
        {
            DecreasePortionCommand = new Command(DecreasePortion);
            IncreasePortionCommand = new Command(IncreasePortion);
            AddWaterRecordCommand = new Command(AddWaterRecord);

            PortionSize = 200;
        }

        public int Id { get; set; }

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

        public string[] Sexes => Enum.GetNames(typeof(SexEnum));

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

        private ObservableCollection<ResortViewModel> _favouriteResorts;
        public ObservableCollection<ResortViewModel> FavouriteResorts
        {
            get => _favouriteResorts;
            set
            {
                _favouriteResorts = value;
                OnPropertyChanged();
            }
        }

        // tracker
        private ObservableCollection<TrackedDayViewModel> _trackedDays;
        public ObservableCollection<TrackedDayViewModel> TrackedDays
        {
            get => _trackedDays;
            set
            {
                _trackedDays = value;
                OnPropertyChanged();
            }
        }

        public TrackedDayViewModel TrackedToday()
        {
            return TrackedDays.FirstOrDefault(trackedDay =>
                trackedDay.Date.ToString("d") == DateTime.Now.ToString("d"));
        }

        public int Goal => Weight * 30;

        public int NumberOfDays
        {
            get
            {
                int numberOfDays = 0;
                var days = TrackedDays.Where(trackedDay => trackedDay.Date.ToString("d") != DateTime.Now.ToString("d")).OrderByDescending(trackedDay => trackedDay.Date).ToList();
                for (int i = 0; i < days.Count(); i++)
                {
                    if (days[i].Records.Sum(record => record.Volume) >= days[i].Goal)
                    {
                        numberOfDays++;
                    }
                    else
                    {
                        break;
                    }
                }

                return numberOfDays;
            }
        }

        private int _portionSize;
        public int PortionSize
        {
            get => _portionSize;
            set
            {
                _portionSize = value;
                OnPropertyChanged();
            }
        }

        public int DrunkToday
        {
            get
            {
                var trackedToday = TrackedToday();
                if (trackedToday == null)
                {
                    trackedToday = new TrackedDayViewModel();
                    TrackedDays.Add(trackedToday);
                    return 0;
                }
                else
                {
                    return trackedToday.Records.Sum(record => record.Volume);
                }
            }
        }

        public string DrunkTodayString
        {
            get
            {
                if (DrunkTodayInPercentage > 75)
                {
                    return "супер";
                } else if (DrunkTodayInPercentage > 50)
                {
                    return "добре";
                } else if (DrunkTodayInPercentage > 25)
                {
                    return "продовжуй";
                }
                else
                {
                    return "мало";
                }
            }
        }

        public int DrunkTodayInPercentage
        {
            get
            {
                var trackedToday = TrackedToday();
                if (trackedToday == null)
                {
                    trackedToday = new TrackedDayViewModel();
                    // TODO: Add to the service
                    TrackedDays.Add(trackedToday);
                    return 0;
                }
                else
                {
                    var result = (int)(trackedToday.Records.Sum(record => record.Volume) / (double)trackedToday.Goal * 100);
                    return result > 100 ? 100 : result;
                }
            }
        }

        public ICommand IncreasePortionCommand { get; }
        private void IncreasePortion()
        {
            PortionSize += 100;
        }

        public ICommand DecreasePortionCommand { get; }
        private void DecreasePortion()
        {
            if (PortionSize - 100 > 0)
            {
                PortionSize -= 100;
            }
            else
            {
                PortionSize = 0;
            }
        }

        public ICommand AddWaterRecordCommand { get; }
        private void AddWaterRecord()
        {
            var trackedToday = TrackedToday();
            // TODO: add to service
            trackedToday.Records.Add(new TrackedDayRecordViewModel()
            {
                DrinkType = Mapper.Map<DrinkTypeViewModel>(DrinkTypesService.Get("вода")),
                Volume = PortionSize
            });
            OnPropertyChanged("DrunkToday");
            OnPropertyChanged("DrunkTodayString");
            OnPropertyChanged("DrunkTodayInPercentage");
        }
    }
}