using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2
{
    public enum State
    {
        dead,
        sick,
        hungry,
        satisfied
    }
    public class Animal 
    {
       public int GeneralHealth;
       public int health;
       public string name;
       State state;
        public Animal()
        {
            this.State = State.satisfied;
        }

        

        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }

        public State State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
        

        public static void Show(Animal animal)
        {
            Console.WriteLine("Animal {0} has {1} health is called {2} status {3}  ", animal.GetType().Name,animal.Health,animal.name, animal.state);
        }
        public static void Heal(string name, ref List<Animal> Zoo)
        {
            foreach (var n in Zoo)
            {
                if (n.name == name && n.health < n.GeneralHealth)
                {
                    n.health++;
                }
            }
        }
        public static void DeleteFromZoo(string name,ref List<Animal> deadanimals)
        {
            foreach(var n in deadanimals)
            {
                deadanimals.Remove(n);
            }
        }
        public static void FeedAnimal(string name,ref List<Animal> Zoo)
        {
            
        foreach(var n in Zoo)
            {
                if(n.name == name)
                {
                    n.state = State.satisfied;
                }
            }

        }
        public void DecreaseState()
        {
            if(state == State.sick)
            {
                Health--;
                if(Health == 0)
                {
                    state = State.dead;
                }
            }
            else
            {
                if(state > 0)
                {
                    state--;
                }
            }
        }
        public void IncreaseState()
        {
            if(Health < GeneralHealth)
            {
                Health++;
            }
        }
        
    }
}
