using System;
using System.Collections.Generic;
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
    }
}
