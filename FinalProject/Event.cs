using System.Windows.Controls;

namespace FinalProject
{
    internal class Event
    {
        //public Group EventGroup { get; private set; }
        public string Description { get; private set; }
        public string EventName { get; private set; }
        public string EventLengthMinutes { get; private set; }
        public int StartTime { get; private set; }
        public int EndTime { get; private set; }
        public Image PhotoSource { get; private set; }

        /*public Event(Group eventGroup, string description, string eventName, int eventLengthMinutes, int startTime, int endTime, string photoSource)
        {
            EventGroup = eventGroup;
            Description = description;
            EventName = eventName;
            EventLengthMinutes = eventLengthMinutes;
            StartTime = startTime;
            EndTime = endTime;
            PhotoSource = photoSource;
        }*/
        public Event(string description, string eventName, string eventLengthMinutes, int startTime, int endTime, Image photo)
        {
            Description = description;
            EventName = eventName;
            EventLengthMinutes = eventLengthMinutes;
            StartTime = startTime;
            EndTime = endTime;
            PhotoSource = photo;
        }

    }
}
