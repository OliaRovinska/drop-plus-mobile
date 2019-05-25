using System.Collections.Generic;
using System.Windows.Input;
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

        public ICommand UpdateFavouriteCommand { get; }
        private void UpdateFavourite()
        {
            IsFavourite = !IsFavourite;
        }
    }
}