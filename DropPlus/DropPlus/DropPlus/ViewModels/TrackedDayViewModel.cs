using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DropPlus.ViewModels
{
    public class TrackedDayViewModel : BaseViewModel
    {
        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        private int _goal;
        public int Goal
        {
            get => _goal;
            set
            {
                _goal = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<TrackedDayRecordViewModel> _records;
        public ObservableCollection<TrackedDayRecordViewModel> Records
        {
            get => _records;
            set
            {
                _records = value;
                OnPropertyChanged();
                OnPropertyChanged("SortedRecords");
            }
        }

        public ObservableCollection<TrackedDayRecordViewModel> SortedRecords => new ObservableCollection<TrackedDayRecordViewModel>(Records.OrderByDescending(record => record.Time));

        public int Drunk => Records.Sum(record => Convert.ToInt32(record.Volume * record.DrinkType.Coefficient));

        public int DrunkInPercentage
        {
            get
            {
                var result = (int)(Records.Sum(record => Convert.ToInt32(record.Volume * record.DrinkType.Coefficient)) / (double)Goal * 100);
                return result > 100 ? 100 : result;
            }
        }
    }
}