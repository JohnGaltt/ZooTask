using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
    class Elephant : Animal
    {
     
        public Elephant(string Alias)
        {
            type = this.GetType().Name.ToString();
            this.Alias = Alias;
            StartHealth = 7;
            CurrentHealth = StartHealth;
            stage = Stage.Satisfied;
        }
        static Elephant()
        {
            Console.WriteLine("Elephant created");
        }
    }
}
