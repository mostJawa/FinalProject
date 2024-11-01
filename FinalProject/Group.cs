using System.Collections.Generic;
using System.Windows.Controls;

namespace FinalProject
{
    public class Group
    {
        private List<User> groupMembers { get; set; }
        private string groupName { get; set; }
        private User admin { get; set; }
        private List<Event> events { get; set; }

        public Group(string groupName, User admin)
        {
            this.groupName = groupName;
            this.admin = admin;
            groupMembers.Add(admin);
        }
        public Group()
        {
            this.groupName = "defaultGroupName";
            this.admin = null;

        }

        public void newEvent(string description, string eventName, int eventLengthMinutes, int startTime, int endTime, Image photoSource)
        {
            events.Add(new Event(description, eventName, eventLengthMinutes.ToString(), startTime, endTime, photoSource));
        }

        public void addUser(User user)
        {
            groupMembers.Add(user);
        }

    }
}
