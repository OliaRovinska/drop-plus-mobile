using System.Collections.ObjectModel;

namespace DropPlus.ViewModels
{
    public class FavouriteResortsViewModel : BaseViewModel
    {
        public ObservableCollection<ResortViewModel> Resorts { get; set; }
    }
}