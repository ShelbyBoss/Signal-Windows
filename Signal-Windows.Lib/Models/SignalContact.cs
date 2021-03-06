using System.Collections.Generic;

namespace Signal_Windows.Models
{
    // Database model
    public class SignalContact : SignalConversation
    {
        public string Color { get; set; }
        public bool Blocked { get; set; }
        public List<GroupMembership> GroupMemberships { get; set; }
    }
}