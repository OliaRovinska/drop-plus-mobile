using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropPlus.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignInPage : ContentPage
	{
		public SignInPage ()
		{
			InitializeComponent ();

            SignUpLabel.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(OnSignUp)
            });
        }

        private async void OnSignIn(object sender, EventArgs e)
        {
            var user = UsersService.Get(Email.Text);
            if (user != null && user.Password == Password.Text)
            {
                App.User = user;
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                EmailError.IsVisible = true;
                SignInButton.Margin = new Thickness(25, 0);
                HelloLabel.Margin = new Thickness(5, 0, 0, 0);
                EmailError.Text = "Login or password is incorrect";
            }
        }

        private async void OnSignUp()
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}