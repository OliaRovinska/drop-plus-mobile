using DropPlus.Models;

namespace DropPlus.Services
{
    public static class TrackerService
    {
        public static void AddRecord(TrackedDayRecordModel record)
        {
            App.User.TrackedToday().Records.Add(record);
        }
    }
}