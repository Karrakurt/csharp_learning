using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы__структуры_и_пространства_имен
{
    internal class Person
    {
        public string name = "Undefined";
        public void Print()
        {
            Console.WriteLine($"Person {name}");
        }
    }
}
