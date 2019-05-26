using System;
using DropPlus.AutoMapper;
using DropPlus.Enums;
using DropPlus.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DropPlus.Views;

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

            User = new UserModel()
            {
                FirstName = "Ольга",
                LastName = "Ровінська",
                Location = "Львів",
                Age = 21,
                Photo = "https://media.licdn.com/dms/image/C5603AQGAzsg5qZRzzg/profile-displayphoto-shrink_200_200/0?e=1562803200&v=beta&t=WVi627qWCw58aEtQ2DI-jirm3WVdjQWLQCEvy4eOV1A",
                Height = 160,
                Weight = 48,
                Sex = SexEnum.Woman,
                SleepHour = new TimeSpan(23, 0, 0),
                WakeUpHour = new TimeSpan(7, 0, 0)
            };
            MainPage = new MainPage();
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
