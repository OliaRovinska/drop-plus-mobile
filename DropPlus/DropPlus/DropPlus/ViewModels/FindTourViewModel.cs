﻿using System;
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
            Organs = Mapper.Map<ObservableCollection<DiseaseViewModel>>(DiseasesService.GetAll());

            IsDateImportant = true;
            IsDistanceImportant = true;

            StartDate = DateTime.Now.AddMonths(1);
            EndDate = DateTime.Now.AddMonths(1).AddDays(7);
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

        private ObservableCollection<DiseaseViewModel> _organs;
        public ObservableCollection<DiseaseViewModel> Organs
        {
            get => _organs;
            set
            {
                _organs = value;
                OnPropertyChanged();
            }
        }
        public int OrgansListViewHeight => Organs.Count * 40;

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

        private bool _isDateImportant;
        public bool IsDateImportant
        {
            get => _isDateImportant;
            set
            {
                _isDateImportant = value;
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