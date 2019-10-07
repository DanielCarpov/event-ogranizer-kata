using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_ogranizer
{
    public class Range<T> where T : IComparable
    {
        readonly T min;
        readonly T max;

        public Range(T min, T max)
        {
            this.min = min;
            this.max = max;
        }

        public List<T> CheckOverlapping(Range<T> other)
        {
            if (Min.CompareTo(other.Max) <= 0 && other.Min.CompareTo(Max) <= 0)
            {
                T begin = Min;
                T end = Max;

                if (Max.CompareTo(other.Max) >= 0)
                    begin = other.Max;
                if (Min.CompareTo(other.Min) <= 0)
                    end = other.Min;

                List<T> res = new List<T>();
                res.Add(begin);
                res.Add(end);
                return res;
            }
            return null;
        }

        public T Min { get { return min; } }
        public T Max { get { return max; } }

    }
}
