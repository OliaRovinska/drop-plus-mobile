using DropPlus.Enums;

namespace DropPlus.Models
{
    public class ResortModel
    {
        public string Image { get; set; }
        public string Location { get; set; }
        public bool IsFavourite { get; set; }
        public string Description { get; set; }
        public SeasonEnum[] Seasons { get; set; }
    }
}