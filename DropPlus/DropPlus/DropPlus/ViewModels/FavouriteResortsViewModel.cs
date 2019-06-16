using System.Collections.ObjectModel;

namespace DropPlus.ViewModels
{
    public class FavouriteResortsViewModel : BaseViewModel
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