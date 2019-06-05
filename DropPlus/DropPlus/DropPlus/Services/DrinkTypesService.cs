using System.Collections.Generic;
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
                new DrinkTypeModel() {Name = "Вода"},
                new DrinkTypeModel() {Name = "Сік"},
                new DrinkTypeModel() {Name = "Кава"},
                new DrinkTypeModel() {Name = "Чай"},
                new DrinkTypeModel() {Name = "Сода"},
                new DrinkTypeModel() {Name = "Квас"}
            };
        }

        public static List<DrinkTypeModel> GetAll()
        {
            return DrinkTypes;
        }
    }
}