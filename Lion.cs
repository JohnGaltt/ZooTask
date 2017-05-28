using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
    class Lion : Animal
    {

        public Lion(string Alias)
        {
            type = this.GetType().Name.ToString();
            this.Alias = Alias;
            StartHealth = 5;
            CurrentHealth = StartHealth;
            stage = Stage.Satisfied;
        }
        static Lion()
        {
            Console.WriteLine("Lion created");
        }
    }
}
