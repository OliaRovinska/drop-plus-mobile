using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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

            BindingContext = Mapper.Map<UserViewModel>(App.User);

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnEditProfilePage;
            EditProfileImage.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void OnFavouriteResortsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FavouriteResortsPage() {
                BindingContext = new FavouriteResortsViewModel()
                {
                    Resorts = Mapper.Map<ObservableCollection<ResortViewModel>>(App.User.FavouriteResorts)
                }
            });
        }

        private void OnEditProfilePage(object sender, EventArgs e)
        {
            var newUser = Mapper.Map<UserViewModel>(App.User);
            var editProfilePage = new EditProfilePage() { BindingContext = newUser };
            Navigation.PushAsync(editProfilePage);
        }

        protected override void OnAppearing()
        {
            BindingContext = Mapper.Map<UserViewModel>(App.User);
        }
    }
}