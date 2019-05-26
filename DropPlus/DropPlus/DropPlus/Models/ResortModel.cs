using System.Collections.Generic;
using DropPlus.Enums;

namespace DropPlus.Models
{
    public class ResortModel
    {
        public ResortModel()
        {
            Seasons = new List<SeasonEnum>();
            Reviews = new List<ReviewModel>();
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public bool IsSponsored { get; set; }
        public string Description { get; set; }
        public List<SeasonEnum> Seasons { get; set; }
        public List<ReviewModel> Reviews { get; set; }
    }
}