using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavugras_FanniNikol
{
    internal class Student
    {
        public string name;
        public string city;
        public string result;

        public Student(string name, string city, string result)
        {
            this.name = name;
            this.city = city;
            this.result = result;
        }

        override public string ToString()
        {
            return $"{name} ({city})";
        }

        public int ValidJumpsCount()
        {
            var jumps = result.Split(' ');
            jumps = jumps.Take(jumps.Length - 1).ToArray(); ;
            var validJumps = jumps.Select(j => double.Parse(j))
                        .Where(j => j > 0)
                        .Count();
            return validJumps;
        }

        public double AverageJump()
        {
            var jumps = result.Split(' ');

            jumps = jumps.Take(jumps.Length - 1).ToArray(); ;
            
            var validJumps = jumps.Select(j => double.Parse(j))
                                  .Where(j => j > 0 );

            double avg = validJumps.Average();
            return Math.Round(avg, 2);
        }

        public double BestJump()
        {
            var jumps = result.Split(' ');
            jumps = jumps.Take(jumps.Length - 1).ToArray(); ;
            var validJumps = jumps.Select(j => double.Parse(j))
                                  .Where(j => j > 0);

            double best = validJumps.Max();
            return Math.Round(best, 2);
        }

    }
}