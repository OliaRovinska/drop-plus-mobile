using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            }
        }
    }
}