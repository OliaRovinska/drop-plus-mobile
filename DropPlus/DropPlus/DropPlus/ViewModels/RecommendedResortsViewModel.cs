using System.Collections.ObjectModel;

namespace DropPlus.ViewModels
{
    public class RecommendedResortsViewModel : BaseViewModel
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
    }
}