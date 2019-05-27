using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DropPlus.Interfaces;
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

        private async void OnUploadPhotoClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.IsEnabled = false;
            var picturePicker = DependencyService.Get<IPicturePicker>();
            Stream stream = await picturePicker.GetImageStreamAsync();

            if (stream != null)
            {
                // save to server!!!
                UserImage.Source = ImageSource.FromStream(() => stream);
            }

            button.IsEnabled = true;
        }
    }
}