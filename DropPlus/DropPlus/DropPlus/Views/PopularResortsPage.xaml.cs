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
	public partial class PopularResortsPage : ContentPage
	{
		public PopularResortsPage()
		{
			InitializeComponent ();

            BindingContext = new PopularResortsViewModel()
            {
                Resorts = Mapper.Map<ObservableCollection<ResortViewModel>>(ResortsService.GetSponsored())
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnFindTourPage;
            FindTourFrame.GestureRecognizers.Add(tapGestureRecognizer);
        }

        protected override void OnAppearing()
        {
            var context = (PopularResortsViewModel)BindingContext;
            context.Resorts = Mapper.Map<ObservableCollection<ResortViewModel>>(ResortsService.GetSponsored());
        }

        private void OnFindTourPage(object sender, EventArgs e)
        {
            var model = new FindTourViewModel();
            var findTourPage = new FindTourPage1() {BindingContext = model};
            Navigation.PushAsync(findTourPage);
        }
    }
}