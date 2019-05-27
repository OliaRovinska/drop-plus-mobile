using System;
using System.Collections.ObjectModel;
using AutoMapper;
using DropPlus.Enums;
using DropPlus.Services;

namespace DropPlus.ViewModels
{
    public class ResortsFilterViewModel : BaseViewModel
    {
        public ResortsFilterViewModel()
        {
            MinRating = 0;
            MaxRating = 5;
            Season = SeasonEnum.Summer;
            IsSanatorium = true;
            Diseases = Mapper.Map<ObservableCollection<DiseaseViewModel>>(DiseasesService.GetAll());
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

        private float _minRating;
        public float MinRating
        {
            get => _minRating;
            set
            {
                _minRating = value;
                OnPropertyChanged();
            }
        }

        private float _maxRating;
        public float MaxRating
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

        public string[] Seasons => Enum.GetNames(typeof(SeasonEnum));
    }
}