using System.Collections.Generic;
using DropPlus.Models;

namespace DropPlus.Services
{
    public static class DiseasesService
    {
        public static List<DiseaseModel> Diseases { get; set; }

        static DiseasesService()
        {
            Diseases = new List<DiseaseModel>()
            {
                new DiseaseModel() {Name = "Грип"},
                new DiseaseModel() {Name = "Кашель"},
                new DiseaseModel() {Name = "Печія"},
                new DiseaseModel() {Name = "Нежить"}
            };
        }

        public static List<DiseaseModel> GetAll()
        {
            return Diseases;
        }
    }
}