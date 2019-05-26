using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DropPlus.Models;
using DropPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditProfilePage : ContentPage
	{
		public EditProfilePage ()
		{
			InitializeComponent ();
        }

        private void OnSaveProfile(object sender, EventArgs e)
        {
            var userViewModel = (UserViewModel) BindingContext;
            App.User = Mapper.Map<UserModel>(userViewModel);
            Navigation.PopAsync();
        }

        protected override void OnDisappearing()
        {
            Navigation.PopAsync();
        }
    }
}