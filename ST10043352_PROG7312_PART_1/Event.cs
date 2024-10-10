using System;

namespace ST10043352_PROG7312_PART_1
{
    public class Event : IComparable<Event>
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Event(DateTime date, string category, string title, string description)
        {
            Date = date;
            Category = category;
            Title = title;
            Description = description;
        }

        public int CompareTo(Event other)
        {
            return Date.CompareTo(other.Date);
        }
    }
}
