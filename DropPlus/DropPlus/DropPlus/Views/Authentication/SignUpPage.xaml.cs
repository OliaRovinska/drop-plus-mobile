using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropPlus.Models;
using DropPlus.Services;
using DropPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();

            BindingContext = new UserViewModel();
            SignInLabel.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(OnSignIn)
            });
        }

        private async void OnSignUp(object sender, EventArgs e)
        {
            var user = (UserViewModel)BindingContext;
            if (String.IsNullOrEmpty(user.FirstName))
            {
                ShowError("Вкажіть ім'я");
                return;
            }
            if (String.IsNullOrEmpty(user.LastName))
            {
                ShowError("Вкажіть прізвище");
                return;
            }
            if (String.IsNullOrEmpty(user.Email))
            {
                ShowError("Вкажіть емейл");
                return;
            }
            if (String.IsNullOrEmpty(user.Password))
            {
                ShowError("Вкажіть пароль");
                return;
            }
            await Navigation.PushAsync(new SignUpPage2() {BindingContext = user});
        }

        public void ShowError(string text)
        {
            Error.IsVisible = true;
            SignUpButton.Margin = new Thickness(25, 0);
            HelloLabel.Margin = new Thickness(5, 0, 0, 0);
            Error.Text = text;
        }

        private async void OnSignIn()
        {
            await Navigation.PushAsync(new SignInPage());
        }
    }
}