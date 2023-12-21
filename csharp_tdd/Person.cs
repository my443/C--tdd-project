using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tdd
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Constructor
        public  Person(string name) { 
            this.Name = name;
            Console.WriteLine(name);        
        }
    }
}
