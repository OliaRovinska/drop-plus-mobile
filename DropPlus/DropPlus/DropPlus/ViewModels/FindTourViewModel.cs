using System;
using System.Collections.ObjectModel;
using AutoMapper;
using DropPlus.Services;

namespace DropPlus.ViewModels
{
    public class FindTourViewModel : BaseViewModel
    {
        public FindTourViewModel()
        {
            TourAims = Mapper.Map<ObservableCollection<TourAimViewModel>>(TourAimsService.GetAll());
            Organs = Mapper.Map<ObservableCollection<OrganViewModel>>(OrgansService.GetAll());
        }

        private ObservableCollection<TourAimViewModel> _tourAims;
        public ObservableCollection<TourAimViewModel> TourAims
        {
            get => _tourAims;
            set
            {
                _tourAims = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<OrganViewModel> _organs;
        public ObservableCollection<OrganViewModel> Organs
        {
            get => _organs;
            set
            {
                _organs = value;
                OnPropertyChanged();
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;
                OnPropertyChanged();
            }
        }

        private bool _isDistanceImportant;
        public bool IsDistanceImportant
        {
            get => _isDistanceImportant;
            set
            {
                _isDistanceImportant = value;
                OnPropertyChanged();
            }
        }
    }
}