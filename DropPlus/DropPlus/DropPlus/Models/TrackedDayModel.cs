using System;
using System.Collections.Generic;

namespace DropPlus.Models
{
    public class TrackedDayModel
    {
        public TrackedDayModel()
        {
            Date = DateTime.Now;
            Records = new List<TrackedDayRecordModel>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int Goal { get; set; }

        public List<TrackedDayRecordModel> Records { get; set; }
    }
}