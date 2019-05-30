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
	public partial class FindTourPage3 : ContentPage
	{
		public FindTourPage3 ()
		{
			InitializeComponent ();
		}

        private void OnSave(object sender, EventArgs e)
        {
            for (int i = Navigation.NavigationStack.Count - 1; i > 0; i--)
            {
                Navigation.RemovePage(Navigation.NavigationStack[i]);
            }
            var context = (FindTourViewModel)BindingContext;
            Navigation.PushAsync(new RecommendedResortsPage()
            {
                BindingContext = new RecommendedResortsViewModel()
                {
                    Resorts = Mapper.Map<ObservableCollection<ResortViewModel>>(ResortsService.GetRecommended(context))
                }
            });
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}