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
            try
            {
                var jumps = result.Split(' ');
                var validJumps = jumps
                    .Select(j => double.Parse(j))
                    .Where(j => j > 0);

                return validJumps.Count();
            }
            catch
            {
                return 0;
            }
        }

        public double AverageJump()
        {
            try
            {
                var jumps = result.Split(' ');
                var validJumps = jumps
                    .Select(j => double.Parse(j))
                    .Where(j => j > 0);

                if (validJumps.Count() == 0)
                    return 0;

                return Math.Round(validJumps.Average(), 2);
            }
            catch
            {
                return 0;
            }
        }

        public double BestJump()
        {
            try
            {
                var jumps = result.Split(' ');
                var validJumps = jumps
                    .Select(j => double.Parse(j))
                    .Where(j => j > 0);

                if (validJumps.Count() == 0)
                    return 0;

                return Math.Round(validJumps.Max(), 2);
            }
            catch
            {
                return 0;
            }
        }

    }
}