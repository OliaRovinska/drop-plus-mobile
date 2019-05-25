using System;
using System.Collections.ObjectModel;

namespace DropPlus.ViewModels
{
    public class ResortsViewModel : BaseViewModel
    {
        public ObservableCollection<ResortViewModel> Resorts { get; set; }

        public ResortsViewModel()
        {
            Resorts = new ObservableCollection<ResortViewModel>()
            {
                new ResortViewModel()
                {
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино",
                    IsFavourite = false
                },
                new ResortViewModel()
                {
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/08/4a/79/34/pushkar-resorts.jpg",
                    Location = "Синевир",
                    IsFavourite = true
                },
                new ResortViewModel()
                {
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино",
                    IsFavourite = false
                },
                new ResortViewModel()
                {
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/08/4a/79/34/pushkar-resorts.jpg",
                    Location = "Синевир",
                    IsFavourite = true
                },
                new ResortViewModel()
                {
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино",
                    IsFavourite = false
                },
                new ResortViewModel()
                {
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/08/4a/79/34/pushkar-resorts.jpg",
                    Location = "Синевир",
                    IsFavourite = true
                }
            };
        }
    }
}