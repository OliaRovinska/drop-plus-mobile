using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DropPlus.Enums;

namespace DropPlus.ViewModels
{
    public class PopularResortsViewModel : BaseViewModel
    {
        private ObservableCollection<ResortViewModel> _resorts;
        public ObservableCollection<ResortViewModel> Resorts
        {
            get => _resorts;
            set
            {
                _resorts = value;
                OnPropertyChanged();
            }
        }

        public int ResortsListViewHeight => Resorts?.Count * 100 ?? 0;
    }
}