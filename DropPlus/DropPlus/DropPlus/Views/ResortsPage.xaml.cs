using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DropPlus.Services;
using DropPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResortsPage : ContentPage
	{
		public ResortsPage()
		{
			InitializeComponent ();

            BindingContext = new ResortsViewModel()
            {
                Resorts = Mapper.Map<ObservableCollection<ResortViewModel>>(ResortsService.GetAll())
            };
	    }

        protected override void OnAppearing()
        {
            BindingContext = new ResortsViewModel()
            {
                Resorts = Mapper.Map<ObservableCollection<ResortViewModel>>(ResortsService.GetAll())
            };
        }
    }
}