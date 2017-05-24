using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2
{
    public class Elephant : Animal
    {
     
        public Elephant(string name)
        {
            this.name = name;     
            this.health = 7;
            Console.WriteLine("Elephant" + name);
        }
    }
}
