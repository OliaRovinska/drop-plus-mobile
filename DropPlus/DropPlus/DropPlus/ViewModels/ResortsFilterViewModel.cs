using System;
using System.Collections.ObjectModel;
using AutoMapper;
using DropPlus.Enums;
using DropPlus.Services;
using DropPlus.Helpers;

namespace DropPlus.ViewModels
{
    public class ResortsFilterViewModel : BaseViewModel
    {
        public ResortsFilterViewModel()
        {
            MinRating = 0;
            MaxRating = 5;
            RatingOptions = new ObservableCollection<int>();
            for (int i = 0; i <= MaxRating; i++)
            {
                RatingOptions.Add(i);
            }
            Season = SeasonEnum.Summer;
            Diseases = Mapper.Map<ObservableCollection<DiseaseViewModel>>(DiseasesService.GetAll());
        }

        public ObservableCollection<int> RatingOptions { get; set; }

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

        private ObservableCollection<DiseaseViewModel> _diseases;
        public ObservableCollection<DiseaseViewModel> Diseases
        {
            get => _diseases;
            set
            {
                _diseases = value;
                OnPropertyChanged();
            }
        }
        public int DiseasesListViewHeight => Diseases.Count * 40;

        private int _minRating;
        public int MinRating
        {
            get => _minRating;
            set
            {
                _minRating = value;
                OnPropertyChanged();
            }
        }

        private int _maxRating;
        public int MaxRating
        {
            get => _maxRating;
            set
            {
                _maxRating = value;
                OnPropertyChanged();
            }
        }

        private SeasonEnum _season;
        public SeasonEnum Season
        {
            get => _season;
            set
            {
                _season = value;
                OnPropertyChanged();
            }
        }

        private bool _isSanatorium;
        public bool IsSanatorium
        {
            get => _isSanatorium;
            set
            {
                _isSanatorium = value;
                OnPropertyChanged();
            }
        }

        public string[] Seasons => EnumHelper.GetDescriptions(typeof(SeasonEnum)).ToArray();
    }
}