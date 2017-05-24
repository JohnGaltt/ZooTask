using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2
{
    public class Fox : Animal
    {
      
        public Fox(string name)
        {
            this.name = name;
            this.health = 3;
            Console.WriteLine("Fox " + name);
        }
    }
}
