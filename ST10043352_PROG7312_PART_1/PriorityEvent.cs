using System;

namespace ST10043352_PROG7312_PART_1
{
    public class PriorityEvent : IComparable<PriorityEvent>
    {
        public Event Event { get; set; }
        public int Priority { get; set; } // Lower number = higher priority

        public PriorityEvent(Event evt)
        {
            Event = evt;
            Priority = (int)(evt.Date - DateTime.Now).TotalDays;
        }

        public int CompareTo(PriorityEvent other)
        {
            int result = Priority.CompareTo(other.Priority);
            if (result == 0)
            {
                result = Event.Title.CompareTo(other.Event.Title);
            }
            return result;
        }
    }
}
