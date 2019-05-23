using System;
using System.Collections.Generic;
using DropPlus.Models;

namespace DropPlus.ViewModels
{
    public class ResortsViewModel : BaseViewModel
    {
        public List<ResortModel> Resorts { get; set; }

        public ResortsViewModel()
        {
            Resorts = new List<ResortModel>()
            {
                new ResortModel()
                {
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино"
                },
                new ResortModel()
                {
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/08/4a/79/34/pushkar-resorts.jpg",
                    Location = "Синевир"
                }
            };
        }
    }
}