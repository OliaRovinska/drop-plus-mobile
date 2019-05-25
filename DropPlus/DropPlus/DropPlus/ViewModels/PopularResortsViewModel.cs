using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DropPlus.Enums;

namespace DropPlus.ViewModels
{
    public class PopularResortsViewModel : BaseViewModel
    {
        public ObservableCollection<ResortViewModel> Resorts { get; set; }

        public PopularResortsViewModel()
        {
            Resorts = new ObservableCollection<ResortViewModel>()
            {
                new ResortViewModel()
                {
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/df/Town_and_Country_fh000023.jpg",
                    Location = "Солотвино",
                    IsFavourite = false,
                    Description = "Солотвино це лікувально – оздоровчий курорт. З 1968 тут практикують лікування астми та інших захворювань дихальних шляхів в спеціальних палатах, розташованих на глибині понад 200м. В 1976 р. було побудувано Українську республіканську алергологічну лікарню, яка успішно працює до тепер. Щорічно влітку до Солотвино приїзджає багато туристів, щоб полежати в солених озерах, куди ропа(насичена солями вода) потрапляє безпосередньо з шахти. Саме полежати, тому що вода саме виштовхує тіло на поверхню, що створює ефект невагомості. Солені озера Солотвино містять лікувальну ропу та сульфідну грязь. Навколо озер розташовані пляжі, кафе, бази відпочинку",
                    Seasons = new ObservableCollection<SeasonEnum> {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring}
                },
                new ResortViewModel()
                {
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/08/4a/79/34/pushkar-resorts.jpg",
                    Location = "Синевир",
                    IsFavourite = true,
                    Description = "Солотвино це лікувально – оздоровчий курорт.",
                    Seasons = new ObservableCollection<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Reviews = new ObservableCollection<ReviewViewModel>()
                    {
                        new ReviewViewModel()
                        {
                            Rating = 3.5f,
                            Text = "Після відвідання цього туру, лишолося багато приємних вражень. Серед переваг я можу виділити наступні: гарний сервіс, гарна природа і чисті номери. Серед недоліків: фвіфіваіб, фіа івафіафів і афівжаолждфвоіалдж",
                            User = new UserViewModel() {FirstName = "Сергій", LastName = "Шевченко", Location = "Львів, Рясне", Photo = "https://jbwebanalytics.com/wp-content/uploads/2015/11/Brian-Toomey.png" },
                            Date = DateTime.Now
                        },
                        new ReviewViewModel()
                        {
                            Rating = 4.5f,
                            Text = "Після відвідання цього туру, лишолося багато приємних вражень.",
                            User = new UserViewModel() {FirstName = "Оля", LastName = "Ровінська", Location = "Львів, Рясне", Photo = "https://www.unitedagents.co.uk/sites/default/files/styles/client_thumb_400x400/public/thumbnails/image/Headshot%201.PNG?itok=kHVT8TNT&c=277a71a7cdf9a41c57ff520dc593f271" },
                            Date = new DateTime(2017, 11, 25)
                        },
                    }
                }
            };
        }
    }
}