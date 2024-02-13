using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    internal class Person
    {

        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        // returning multiple values or tuple
        public (string, string, int) GetPerson()
        {
            return (Name, Country, Age);
        }
    }
}
