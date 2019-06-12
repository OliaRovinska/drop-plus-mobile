using System;
using System.Collections.Generic;
using DropPlus.AutoMapper;
using DropPlus.Enums;
using DropPlus.Models;
using DropPlus.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DropPlus.Views.Authentication;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DropPlus
{
    public partial class App : Application
    {
        public static UserModel User;

        public App()
        {
            InitializeComponent();

            Mapping.Initialize();
            MainPage = new NavigationPage(new SignInPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
