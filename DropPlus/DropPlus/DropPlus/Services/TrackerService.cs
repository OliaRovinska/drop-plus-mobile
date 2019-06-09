using System;
using System.Linq;
using DropPlus.Models;

namespace DropPlus.Services
{
    public static class TrackerService
    {
        public static TrackedDayRecordModel AddRecordToday(TrackedDayRecordModel record)
        {
            record.Id = App.User.TrackedToday().Records.Max(r => r.Id) + 1;
            App.User.TrackedToday().Records.Insert(0, record);
            return record;
        }

        public static TrackedDayRecordModel GetRecordToday(int id)
        {
            return App.User.TrackedToday().Records.FirstOrDefault(record => record.Id == id);
        }

        public static void AddRecord(TrackedDayRecordModel record, DateTime date)
        {
            if (App.User.TrackedDay(date).Records.Any())
            {
                record.Id = App.User.TrackedDay(date).Records.Max(r => r.Id) + 1;
            }
            else
            {
                record.Id = 0;
            }
            App.User.TrackedDay(date).Records.Insert(0, record);
        }

        public static void RemoveRecord(int id, DateTime date)
        {
            var record = GetRecord(id, date);
            App.User.TrackedDay(date).Records.Remove(record);
        }

        public static void EditRecord(TrackedDayRecordModel newRecord, DateTime date)
        {
            var index = App.User.TrackedDay(date).Records.FindIndex(record => record.Id == newRecord.Id);
            App.User.TrackedDay(date).Records[index] = newRecord;
        }

        public static TrackedDayRecordModel GetRecord(int id, DateTime date)
        {
            return App.User.TrackedDay(date).Records.FirstOrDefault(record => record.Id == id);
        }

        public static TrackedDayModel AddTrackedDay(int goal, DateTime? date = null)
        {
            var trackedDay = new TrackedDayModel() {Goal = goal};
            if (date.HasValue)
            {
                trackedDay.Date = date.Value;
            }

            trackedDay.Id = App.User.TrackedDays.Max(t => t.Id) + 1;
            App.User.TrackedDays.Add(trackedDay);
            return trackedDay;
        }
    }
}