using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
    class Tiger : Animal
    {
        
        public Tiger(string Alias)
        {
            type = this.GetType().Name.ToString();
            this.Alias = Alias;
            StartHealth = 4;
            CurrentHealth = StartHealth;
            stage = Stage.Satisfied;
        }
        static Tiger()
        {
            Console.WriteLine("Tiger created");
        }
    }
}
