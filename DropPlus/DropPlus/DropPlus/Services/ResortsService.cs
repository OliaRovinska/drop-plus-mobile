using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DropPlus.Enums;
using DropPlus.Models;

namespace DropPlus.Services
{
    public static class ResortsService
    {
        public static List<ResortModel> Resorts { get; set; }

        static ResortsService()
        {
            Resorts = new List<ResortModel>()
            {
                new ResortModel()
                {
                    Id = 0,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино",
                    IsSponsored = true,
                    Description = "Солотвино це лікувально – оздоровчий курорт. З 1968 тут практикують лікування астми та інших захворювань дихальних шляхів в спеціальних палатах, розташованих на глибині понад 200м. В 1976 р. було побудувано Українську республіканську алергологічну лікарню, яка успішно працює до тепер. Щорічно влітку до Солотвино приїзджає багато туристів, щоб полежати в солених озерах, куди ропа(насичена солями вода) потрапляє безпосередньо з шахти. Саме полежати, тому що вода саме виштовхує тіло на поверхню, що створює ефект невагомості. Солені озера Солотвино містять лікувальну ропу та сульфідну грязь. Навколо озер розташовані пляжі, кафе, бази відпочинку",
                    Seasons = new List<SeasonEnum> {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring}
                },
                new ResortModel()
                {
                    Id = 1,
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/08/4a/79/34/pushkar-resorts.jpg",
                    Location = "Синевир",
                    IsSponsored = true,
                    Description = "Солотвино це лікувально – оздоровчий курорт.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 3.5f,
                            Text = "Після відвідання цього туру, лишолося багато приємних вражень. Серед переваг я можу виділити наступні: гарний сервіс, гарна природа і чисті номери. Серед недоліків: фвіфіваіб, фіа івафіафів і афівжаолждфвоіалдж",
                            User = new UserModel() {FirstName = "Сергій", LastName = "Шевченко", Location = "Львів, Рясне", Photo = "https://jbwebanalytics.com/wp-content/uploads/2015/11/Brian-Toomey.png" },
                            Date = DateTime.Now
                        },
                        new ReviewModel()
                        {
                            Rating = 4.5f,
                            Text = "Після відвідання цього туру, лишолося багато приємних вражень.",
                            User = new UserModel() {FirstName = "Оля", LastName = "Ровінська", Location = "Львів, Рясне", Photo = "https://www.unitedagents.co.uk/sites/default/files/styles/client_thumb_400x400/public/thumbnails/image/Headshot%201.PNG?itok=kHVT8TNT&c=277a71a7cdf9a41c57ff520dc593f271" },
                            Date = new DateTime(2017, 11, 25)
                        },
                    }
                },
                new ResortModel()
                {
                    Id = 2,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино32",
                    IsSponsored = true,
                    Description = "Солотвино це лікувально – оздоровчий курорт",
                    Seasons = new List<SeasonEnum> {SeasonEnum.Autumn, SeasonEnum.Winter}
                },
                new ResortModel()
                {
                    Id = 3,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино",
                    IsSponsored = false,
                    Description = "Солотвино це лікувально – оздоровчий курорт. З 1968 тут практикують лікування астми та інших захворювань дихальних шляхів в спеціальних палатах, розташованих на глибині понад 200м. В 1976 р. було побудувано Українську республіканську алергологічну лікарню, яка успішно працює до тепер. Щорічно влітку до Солотвино приїзджає багато туристів, щоб полежати в солених озерах, куди ропа(насичена солями вода) потрапляє безпосередньо з шахти. Саме полежати, тому що вода саме виштовхує тіло на поверхню, що створює ефект невагомості. Солені озера Солотвино містять лікувальну ропу та сульфідну грязь. Навколо озер розташовані пляжі, кафе, бази відпочинку",
                    Seasons = new List<SeasonEnum> {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring}
                },
                new ResortModel()
                {
                    Id = 4,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино",
                    IsSponsored = false,
                    Description = "Солотвино це лікувально – оздоровчий курорт. З 1968 тут практикують лікування астми та інших захворювань дихальних шляхів в спеціальних палатах, розташованих на глибині понад 200м. В 1976 р. було побудувано Українську республіканську алергологічну лікарню, яка успішно працює до тепер. Щорічно влітку до Солотвино приїзджає багато туристів, щоб полежати в солених озерах, куди ропа(насичена солями вода) потрапляє безпосередньо з шахти. Саме полежати, тому що вода саме виштовхує тіло на поверхню, що створює ефект невагомості. Солені озера Солотвино містять лікувальну ропу та сульфідну грязь. Навколо озер розташовані пляжі, кафе, бази відпочинку",
                    Seasons = new List<SeasonEnum> {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring}
                }
            };
        }

        public static List<ResortModel> GetAll()
        {
            return Resorts;
        }

        public static List<ResortModel> GetSponsored()
        {
            return Resorts.Where(resort => resort.IsSponsored).ToList();
        }

        public static ResortModel Get(int id)
        {
            return Resorts.First(resort => resort.Id == id);
        }
    }
}