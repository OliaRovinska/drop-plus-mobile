using System.Collections.ObjectModel;
using System.Windows.Input;
using AutoMapper;
using DropPlus.Enums;
using DropPlus.Models;
using Xamarin.Forms;

namespace DropPlus.ViewModels
{
    public class ResortViewModel : BaseViewModel
    {
        public ResortViewModel()
        {
            UpdateFavouriteCommand = new Command(UpdateFavourite);
        }

        public int Id { get; set; }

        private string _image;
        public string Image
        {
            get => _image;
            set
            {
                _image = value;
                OnPropertyChanged();
            }
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

        public bool IsFavourite => App.User.FavouriteResorts.Find(resort => resort.Id == Id) != null;

        private bool _isSponsored;
        public bool IsSponsored
        {
            get => _isSponsored;
            set
            {
                _isSponsored = value;
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

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<SeasonEnum> _seasons;
        public ObservableCollection<SeasonEnum> Seasons
        {
            get => _seasons;
            set
            {
                _seasons = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ReviewViewModel> _reviews;
        public ObservableCollection<ReviewViewModel> Reviews
        {
            get => _reviews;
            set
            {
                _reviews = value;
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

        public ICommand UpdateFavouriteCommand { get; }
        private void UpdateFavourite()
        {
            if (IsFavourite)
            {
                var resort = App.User.FavouriteResorts.Find(r => r.Id == Id);
                App.User.FavouriteResorts.Remove(resort);
            }
            else
            {
                App.User.FavouriteResorts.Add(Mapper.Map<ResortModel>(this));
            }
            OnPropertyChanged($"IsFavourite");
        }
    }
}