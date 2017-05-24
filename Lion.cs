using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2
{
   public class Lion : Animal
    {
       
        public Lion(string name)
        {
            this.name = name;
            this.health = 5;
            Console.WriteLine("Lion" + name);
        }
    }
}
