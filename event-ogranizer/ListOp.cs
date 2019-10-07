using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_ogranizer
{
    class ListOp
    {
        public void FindCrosses(List<Event> events)
        {
            int a;
            int b;
            List<DateTime> Overlap;
            foreach(Event i in events)
            {
                foreach(Event j in events)
                {
                    Overlap = i.range.CheckOverlapping(j.range);

                    if (Overlap != null)    
                    {
                        PrintNames(i, j);
                        PrintDates(Overlap);
                    }
                }
            }
        }

        public void PrintNames(Event q, Event p)
        {
            Console.Write(q.name + " " + p.name + " ");
        }
        public void PrintDates(List<DateTime> Overlap)
        {
            Console.WriteLine(Overlap.ElementAt(0) + " " + Overlap.ElementAt(1));
        }
    }
}
