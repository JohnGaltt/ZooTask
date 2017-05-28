using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
    class AnimalFactory
    {
        //public string Name { get; set; }
        //public string Type { get; set; }


        public Animal AddAnimal(string name, string type)
        {
            switch (type)
            {
                case "Fox": return new Fox(name);
                case "Tiger": return new Tiger(name);
                case "Elephant": return new Elephant(name);
                case "Wolf": return new Wolf(name);
                case "Lion": return new Lion(name);
                case "Bear": return new Bear(name);
                default: Console.WriteLine("You wrote invalid word");
                    break;
            }
            return new Fox("0");
        }
        public void FeedAnimalFunc(string name,ref List<Animal> Zoo)
        {
            foreach(var i in Zoo)
            {
                if(name == i.Alias)
                {
                    i.FeedAnimal();
                }
            }
        }
        public void HealAnimalFunc(string name,ref List<Animal> Zoo)
        {
            foreach (var i in Zoo)
            {
                if (name == i.Alias)
                {
                    i.BetterStatus();
                }
            }
        }
        public void DeleteAnimalFunc(string name,ref List<Animal> Zoo,ref List<Animal> DeadAnimals)
        {
            foreach (var i in Zoo)
            {
                if (name == i.Alias && i.stage == Stage.Dead)
                {
                    Zoo.Remove(i);
                    DeadAnimals.Add(i);
                }
            }
        }
        public string GetName()
        {
            string name = Console.ReadLine();
            return name;
        }
       public string GetType()
        {
            string type = Console.ReadLine();
            return type;
        }
        public string GetStage()
        {
            string stage = Console.ReadLine();
            return stage;
        }
        public void ShowAllAliveAnimals(ref List<Animal> Zoo)
        {
            foreach (var i in Zoo) 
            {
                i.Show();
            }
        }

    }
}
