using System;

namespace event_ogranizer
{
    public class Event
    {
        public string name;
        public DateTime begin;
        public DateTime end;
        public Range<DateTime> range;
        public Event(string name, DateTime begin, DateTime end)
        {
            this.name = name;
            //this.begin = begin;
            //this.end = end;
            range = new Range<DateTime>(begin, end);
        }
    }
}
