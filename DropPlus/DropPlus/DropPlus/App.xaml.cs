using System;
using System.Collections.Generic;
using DropPlus.AutoMapper;
using DropPlus.Enums;
using DropPlus.Models;
using DropPlus.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DropPlus.Views;
using Rg.Plugins.Popup.Pages;

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
                WakeUpHour = new TimeSpan(7, 0, 0),
            };
            var drinkTypes = DrinkTypesService.GetAll();
            User.TrackedDays = new List<TrackedDayModel>()
            {
                new TrackedDayModel()
                {
                    Id = 0,
                    Goal = User.Goal,
                    Date = DateTime.Now,
                    Records = new List<TrackedDayRecordModel>()
                    {
                        new TrackedDayRecordModel()
                        {
                            Id = 0,
                            DrinkType = drinkTypes[0],
                            Volume = 200
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 1,
                            DrinkType = drinkTypes[0],
                            Volume = 100
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 2,
                            DrinkType = drinkTypes[0],
                            Volume = 600
                        }
                    }
                },
                new TrackedDayModel()
                {
                    Id = 1,
                    Goal = User.Goal,
                    Date = DateTime.Now.AddDays(-2),
                    Records = new List<TrackedDayRecordModel>()
                    {
                        new TrackedDayRecordModel()
                        {
                            Id = 0,
                            DrinkType = drinkTypes[0],
                            Volume = 600
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 1,
                            DrinkType = drinkTypes[0],
                            Volume = 500
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 2,
                            DrinkType = drinkTypes[0],
                            Volume = 700
                        }
                    }
                },
                new TrackedDayModel()
                {
                    Id = 2,
                    Goal = User.Goal,
                    Date = DateTime.Now.AddDays(-1),
                    Records = new List<TrackedDayRecordModel>()
                    {
                        new TrackedDayRecordModel()
                        {
                            Id = 0,
                            DrinkType = drinkTypes[0],
                            Volume = 400
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 1,
                            DrinkType = drinkTypes[0],
                            Volume = 500
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 2,
                            DrinkType = drinkTypes[0],
                            Volume = 900
                        }
                    }
                },
                new TrackedDayModel()
                {
                    Id = 3,
                    Goal = User.Goal,
                    Date = DateTime.Now.AddDays(-3),
                    Records = new List<TrackedDayRecordModel>()
                    {
                        new TrackedDayRecordModel()
                        {
                            Id = 0,
                            DrinkType = drinkTypes[0],
                            Volume = 200
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 1,
                            DrinkType = drinkTypes[0],
                            Volume = 1200
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 2,
                            DrinkType = drinkTypes[0],
                            Volume = 900
                        }
                    }
                },
                new TrackedDayModel()
                {
                    Id = 4,
                    Goal = User.Goal,
                    Date = DateTime.Now.AddDays(-8),
                    Records = new List<TrackedDayRecordModel>()
                    {
                        new TrackedDayRecordModel()
                        {
                            Id = 0,
                            DrinkType = drinkTypes[0],
                            Volume = 200
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 1,
                            DrinkType = drinkTypes[0],
                            Volume = 300
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 2,
                            DrinkType = drinkTypes[0],
                            Volume = 300
                        }
                    }
                },
                new TrackedDayModel()
                {
                    Id = 5,
                    Goal = User.Goal,
                    Date = DateTime.Now.AddDays(-5),
                    Records = new List<TrackedDayRecordModel>()
                    {
                        new TrackedDayRecordModel()
                        {
                            Id = 0,
                            DrinkType = drinkTypes[0],
                            Volume = 200
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 1,
                            DrinkType = drinkTypes[0],
                            Volume = 300
                        },
                        new TrackedDayRecordModel()
                        {
                            Id = 2,
                            DrinkType = drinkTypes[0],
                            Volume = 300
                        }
                    }
                }
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
