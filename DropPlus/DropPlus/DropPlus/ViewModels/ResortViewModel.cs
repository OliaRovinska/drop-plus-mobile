using System.Collections.ObjectModel;
using System.Windows.Input;
using DropPlus.Enums;
using Xamarin.Forms;

namespace DropPlus.ViewModels
{
    public class ResortViewModel : BaseViewModel
    {
        public ResortViewModel()
        {
            UpdateFavouriteCommand = new Command(UpdateFavourite);
        }

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

        private bool _isFavourite;
        public bool IsFavourite
        {
            get => _isFavourite;
            set
            {
                _isFavourite = value;
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

        public ICommand UpdateFavouriteCommand { get; }
        private void UpdateFavourite()
        {
            IsFavourite = !IsFavourite;
        }
    }
}