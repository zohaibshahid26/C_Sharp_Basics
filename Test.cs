using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    internal class Test
    {
        public void f2(int x, int y, int z)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }


        public void F1(int a, int b = 1, int c = 40)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }


        public string MyFunction(int x, out int y)
        {
            y = 12;
            return "some string";
        }
    }
}
