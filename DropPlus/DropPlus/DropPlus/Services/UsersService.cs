using System;
using System.Collections.Generic;
using System.Linq;
using DropPlus.Enums;
using DropPlus.Models;
using Xamarin.Forms;

namespace DropPlus.Services
{
    public class UsersService
    {
        public static List<UserModel> Users { get; set; }

        static UsersService()
        {
            Users = new List<UserModel>();
            var User = new UserModel()
            {
                FirstName = "Ольга",
                LastName = "Ровінська",
                Email = "olia@gmail.com",
                Password = "123456",
                Location = "Львів",
                Age = 21,
                Photo = ImageSource.FromUri(new Uri("https://media.licdn.com/dms/image/C5603AQGAzsg5qZRzzg/profile-displayphoto-shrink_200_200/0?e=1562803200&v=beta&t=WVi627qWCw58aEtQ2DI-jirm3WVdjQWLQCEvy4eOV1A")),
                Height = 160,
                Weight = 48,
                Sex = SexEnum.Woman,
                SleepHour = new TimeSpan(23, 0, 0),
                WakeUpHour = new TimeSpan(7, 0, 0),
            };
            Users.Add(User);
            // Add tracked days
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
        }

        public static UserModel Get(string email)
        {
            return Users.FirstOrDefault(user => user.Email == email);
        }

        public static void Add(UserModel user)
        {
            Users.Add(user);
        }
    }
}