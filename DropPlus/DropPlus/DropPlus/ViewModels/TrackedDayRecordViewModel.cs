using System;

namespace DropPlus.ViewModels
{
    public class TrackedDayRecordViewModel : BaseViewModel
    {
        private DrinkTypeViewModel _drinkType;
        public DrinkTypeViewModel DrinkType
        {
            get => _drinkType;
            set
            {
                _drinkType = value;
                OnPropertyChanged();
            }
        }

        private int _volume;
        public int Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                OnPropertyChanged();
            }
        }

        private TimeSpan _time;
        public TimeSpan Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged();
            }
        }
    }
}