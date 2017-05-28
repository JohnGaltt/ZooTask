using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
    class Fox : Animal
    {
      
        public Fox(string Alias)
        {
            type = this.GetType().Name.ToString();
            this.Alias = Alias;
            StartHealth = 3;
            CurrentHealth = StartHealth;
            stage = Stage.Satisfied;
        }
        static Fox()
        {
            Console.WriteLine("Fox created");
        }
    }
}
