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

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnResortsFilterPage;
            FilterFrame.GestureRecognizers.Add(tapGestureRecognizer);
        }

        protected override void OnAppearing()
        {
            var context = (ResortsViewModel)BindingContext;
            var filter = ResortsService.GetFilter();
            context.Resorts = Mapper.Map<ObservableCollection<ResortViewModel>>(filter != null ? ResortsService.ApplyFilter() : ResortsService.GetAll());
        }

        private void OnResortsFilterPage(object sender, EventArgs e)
        {
            var filter = ResortsService.GetFilter();
            var resortsFilterPage = filter != null ? new ResortsFilterPage() { BindingContext = filter } : new ResortsFilterPage() {BindingContext = new ResortsFilterViewModel()};
            resortsFilterPage.OnApplyFilter += OnApplyFilter;
            Navigation.PushAsync(resortsFilterPage);
        }

        private void OnApplyFilter(ResortsFilterViewModel filter)
        {
            ResortsService.SetFilter(filter);
        }
    }
}