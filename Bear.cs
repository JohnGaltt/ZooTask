using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2
{
   public class Bear : Animal
    {
      
        public Bear(string name)
        {
            this.name = name;
            this.health = 6;
            Console.WriteLine("Bear" + name);
        // hello
        }
    }
}
