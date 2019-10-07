using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_ogranizer
{
    public class Translator
    {
        List<Event> events;


        public void EventFFTL(string path)
        {
            //from file to list of events
            string line;

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    CreateEvent(events, line);
                }
            }
        }

        public void CreateEvent(List<Event> events, string line)
        {

            string[] splited;
            splited = line.Split(',');

            var b = splited[0];
            DateTime.TryParse(splited[1], out DateTime c);
            DateTime.TryParse(splited[2], out DateTime d);

            var a = new Event(b, c, d);
            events.Add(a);
        }
    }
}

