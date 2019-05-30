using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FindTourPage1 : ContentPage
	{
		public FindTourPage1 ()
		{
			InitializeComponent ();
		}

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ((ListView)sender).SelectedItem = null;
            }
        }


        private void OnNextPage(object sender, EventArgs e)
        {
            var context = (FindTourViewModel) BindingContext;
            var findTourPage2 = new FindTourPage2() {BindingContext = context};
            Navigation.PushAsync(findTourPage2);
        }
    }
}