using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
   public enum Stage
    {
        Dead,  
        Sick,
        Hungry,
        Satisfied
    }
    public abstract class Animal
    {
        protected int StartHealth;
        public int CurrentHealth;
        public string Alias;
        public Stage stage;
        public string type;
       
        public void SatisfiedStage()
        {
            stage = Stage.Satisfied;
        }
        public void WorsenStatus()
        {
            if(stage != Stage.Sick)
            {
                stage--;
            }
        }
        public void DecreaseHealth()
        {
            if(stage == Stage.Sick && CurrentHealth !=0)
            {
                CurrentHealth--;
            }
            if(CurrentHealth == 0)
            {
                stage = Stage.Dead;
            }
        }
        public void BetterStatus()
        {
            if(stage != Stage.Satisfied){
                stage++;
            }
            Console.WriteLine(" " + this.GetType().Name + " " + this.Alias + "has better health");
        }

        public void FeedAnimal()
        {
            this.stage = Stage.Satisfied;
            Console.WriteLine(" " + this.GetType().Name + " " + this.Alias + "is well-fed");
        }
        public void Show()
        {
            Console.WriteLine("Animal  {0} has {1} alias has {2} health and he is {3} ", this.GetType().Name,this.Alias,this.CurrentHealth,this.stage);
        }
       
    }
 
}
