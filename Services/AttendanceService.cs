using System.Collections.Generic;

namespace EventEaseApp.Services
{
    public class AttendanceService
    {
        private readonly Dictionary<int, List<string>> _attendance = new();

        public void MarkAttendance(int eventId, string userName)
        {
            if (!_attendance.ContainsKey(eventId))
                _attendance[eventId] = new List<string>();

            if (!_attendance[eventId].Contains(userName))
                _attendance[eventId].Add(userName);
        }

        public IReadOnlyList<string> GetAttendees(int eventId)
        {
            return _attendance.ContainsKey(eventId) ? _attendance[eventId] : new List<string>();
        }
    }
}
