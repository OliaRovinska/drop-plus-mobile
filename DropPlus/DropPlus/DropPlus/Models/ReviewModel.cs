using System;

namespace DropPlus.Models
{
    public class ReviewModel
    {
        public ReviewModel()
        {
            Date = DateTime.Now;
        }

        public int Id { get; set; }
        public UserModel User { get; set; }
        public string Text { get; set; }
        public float Rating { get; set; }
        public DateTime Date { get; set; }
    }
}