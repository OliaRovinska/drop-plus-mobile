using System.Collections.Generic;
using DropPlus.Models;

namespace DropPlus.Services
{
    public static class TourAimsService
    {
        public static List<TourAimModel> TourAims { get; set; }

        static TourAimsService()
        {
            TourAims = new List<TourAimModel>()
            {
                new TourAimModel() {Name = "Підлікуватися"},
                new TourAimModel() {Name = "Відпочити"}
            };
        }

        public static List<TourAimModel> GetAll()
        {
            return TourAims;
        }
    }
}