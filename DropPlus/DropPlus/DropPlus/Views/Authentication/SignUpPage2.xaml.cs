using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DropPlus.Interfaces;
using DropPlus.Models;
using DropPlus.Services;
using DropPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage2 : ContentPage
	{
		public SignUpPage2 ()
		{
			InitializeComponent ();
		}

        private async void OnSaveProfile(object sender, EventArgs e)
        {
            var userViewModel = (UserViewModel)BindingContext;
            var user = Mapper.Map<UserModel>(userViewModel);
            user.TrackedDays = new List<TrackedDayModel>()
            {
                new TrackedDayModel()
                {
                    Id = 0,
                    Goal = user.Goal,
                    Date = DateTime.Now
                }
            };
            user.Photo = "https://media.licdn.com/dms/image/C5603AQGAzsg5qZRzzg/profile-displayphoto-shrink_200_200/0?e=1562803200&v=beta&t=WVi627qWCw58aEtQ2DI-jirm3WVdjQWLQCEvy4eOV1A";
            App.User = user;
            UsersService.Add(user);
            await Navigation.PushAsync(new MainPage());
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