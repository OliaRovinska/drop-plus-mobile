using System;
using System.Collections.Generic;
using System.Linq;
using DropPlus.Enums;

namespace DropPlus.Models
{
    public class ResortModel
    {
        public ResortModel()
        {
            Seasons = new List<SeasonEnum>();
            Reviews = new List<ReviewModel>();
            Diseases = new List<DiseaseModel>();
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public bool IsSponsored { get; set; }
        public bool IsSanatorium { get; set; }
        public string Description { get; set; }
        public double Rating => Reviews.Count > 0 ? Reviews.Average(review => review.Rating) : 0;
        public List<SeasonEnum> Seasons { get; set; }
        public List<ReviewModel> Reviews { get; set; }
        public List<DiseaseModel> Diseases { get; set; }
    }
}