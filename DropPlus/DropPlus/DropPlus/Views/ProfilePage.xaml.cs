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
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			InitializeComponent ();

            BindingContext = App.User;
        }

        private void OnFavouriteResortsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FavouriteResortsPage() { BindingContext = new FavouriteResortsViewModel() { Resorts = App.User.FavouriteResorts } });
        }
    }
}