using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using AutoMapper;
using DropPlus.Services;
using Xamarin.Forms;

namespace DropPlus.ViewModels
{
    public class TrackedDayRecordViewModel : BaseViewModel
    {
        public TrackedDayRecordViewModel()
        {
            DrinkTypes = Mapper.Map<ObservableCollection<DrinkTypeViewModel>>(DrinkTypesService.GetAll());
            DrinkType = DrinkTypes.FirstOrDefault();

            Time = DateTime.Now.TimeOfDay;

            Volume = _step;

            DecreasePortionCommand = new Command(DecreasePortion);
            IncreasePortionCommand = new Command(IncreasePortion);
        }

        private int _step = 50;

        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

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

        private ObservableCollection<DrinkTypeViewModel> _drinkTypes;
        public ObservableCollection<DrinkTypeViewModel> DrinkTypes
        {
            get => _drinkTypes;
            set
            {
                _drinkTypes = value;
                OnPropertyChanged();
            }
        }

        public ICommand IncreasePortionCommand { get; }
        private void IncreasePortion()
        {
            Volume += _step;
        }

        public ICommand DecreasePortionCommand { get; }
        private void DecreasePortion()
        {
            if (Volume - _step > 0)
            {
                Volume -= _step;
            }
            else
            {
                Volume = _step;
            }
        }
    }
}