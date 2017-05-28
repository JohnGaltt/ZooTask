using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
    class Bear : Animal
    {
      
        public Bear(string Alias)
        {
            type = this.GetType().Name.ToString();
            this.Alias = Alias;
            StartHealth = 6;
            CurrentHealth = StartHealth;
            stage = Stage.Satisfied;
        }
        static Bear()
        {
            Console.WriteLine("Bear created");
        }
    }
}
