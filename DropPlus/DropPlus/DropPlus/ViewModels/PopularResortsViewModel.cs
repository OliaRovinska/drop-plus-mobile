using System;
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
                    Seasons = new SeasonEnum[] {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring}
                },
                new ResortViewModel()
                {
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/08/4a/79/34/pushkar-resorts.jpg",
                    Location = "Синевир",
                    IsFavourite = true,
                    Description = "Солотвино це лікувально – оздоровчий курорт.",
                    Seasons = new SeasonEnum[] {SeasonEnum.Autumn, SeasonEnum.Winter}
                }
            };
        }
    }
}