using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DropPlus.Models;

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

        private ObservableCollection<TrackedDayRecordModel> _records;
        public ObservableCollection<TrackedDayRecordModel> Records
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