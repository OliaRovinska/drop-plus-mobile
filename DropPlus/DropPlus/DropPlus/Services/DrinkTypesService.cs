using System.Collections.Generic;
using System.Linq;
using DropPlus.Models;

namespace DropPlus.Services
{
    public class DrinkTypesService
    {
        public static List<DrinkTypeModel> DrinkTypes { get; set; }

        static DrinkTypesService()
        {
            DrinkTypes = new List<DrinkTypeModel>()
            {
                new DrinkTypeModel() {Name = "Вода", Coefficient = 1},
                new DrinkTypeModel() {Name = "Сік", Coefficient = 0.6},
                new DrinkTypeModel() {Name = "Кава", Coefficient = 0.4},
                new DrinkTypeModel() {Name = "Чай", Coefficient = 0.4},
                new DrinkTypeModel() {Name = "Сода", Coefficient = 0.2},
                new DrinkTypeModel() {Name = "Квас", Coefficient = 0.6}
            };
        }

        public static List<DrinkTypeModel> GetAll()
        {
            return DrinkTypes;
        }

        public static DrinkTypeModel Get(string name)
        {
            return DrinkTypes.FirstOrDefault(drinkType => drinkType.Name == name);
        }
    }
}