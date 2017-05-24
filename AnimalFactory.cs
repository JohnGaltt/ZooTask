using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2
{
   public static class AnimalFactory
    {
      public static int alive_animals = 0;
        public static Animal GetAnimal(string name, string type)
        {     
            Console.WriteLine("enter name and type animal");
            
            switch (type)
            {
               
                case "Elephant": return new Elephant(name); 
                case "Wolf": return new Wolf(name); 
                case "Bear": return new Bear(name); 
                case "Lion": return new Lion(name); 
                case "Fox": return new Fox(name); 
                case "Tiger":return new Tiger(name);
                default: return new Animal();

            }
        
        }
    }
}
