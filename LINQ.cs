using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
    class LINQ
    {
        
        public void ShowAllAnimals(ref List<Animal> OurZoo)
        {
            var allanimals = OurZoo.Select(x => x).OrderBy(x=>x.GetType().Name);
            foreach(var i in allanimals)
            {
                i.Show();
            }
        }
        public void AnimalsOrderByStage(ref List<Animal> OurZoo, Stage stage)
        {
            var AnimalsByStage = OurZoo.Select(x => x).Where(x => x.stage == stage);
            foreach (var i in AnimalsByStage )
            {
                i.Show();
            }
        }
        public void SickTigersShow(ref List<Animal> OurZoo)
        {
            var SickTigers = OurZoo.Select(x => x).Where(x => x.stage == Stage.Sick);
            foreach (var i in SickTigers)
            {
                i.Show();
            }
        }
        public void ShowElephantByAlias(ref List<Animal> OurZoo,string Alias)
        {
            var Elephant = OurZoo.Select(x => x).Where(x => x.Alias == Alias);
            foreach (var i in Elephant)
            {
                i.Show();
            }
        }
        public void HungryAnimalsShow(ref List<Animal> OurZoo)
        {
            var HungryAnimals = OurZoo.Select(x => x).Where(x => x.stage == Stage.Hungry);
            foreach (var i in HungryAnimals)
            {
                Console.WriteLine(i.Alias);
            }
        }
        public void HealthyAnimalsFunc(ref List<Animal> OurZoo)
        {
            var OurZooAn = OurZoo.GroupBy(x => x.type).Select(y => y.First()).OrderBy(x => x.CurrentHealth);
            foreach (var i in OurZooAn)
            {
                i.Show();
            }            
        }
        public void DeadAnimalsShow(ref List<Animal> DeadAnimals)
        {
            var deadanimals = DeadAnimals.GroupBy(x => x.type).Select(y => y.First());
            foreach (var i in deadanimals)
            {
                i.Show();
            }
        }
        public void BearsAndWolvesHealthMoreThan3Show(ref List<Animal> OurZoo)
        {
            var BearsAndWolves = OurZoo.Select(x => x).Where(x => (x.type == "Wolf" || x.type == "Bear") && x.CurrentHealth > 3);
            foreach (var i in BearsAndWolves)
            {
                i.Show();
            }
        }
        public void AnimalsWithMaxAndMinHealthShow(ref List<Animal> OurZoo)
        {
            //int max =  OurZoo.Max(x => x.CurrentHealth);
            //int min = OurZoo.Min(x => x.CurrentHealth);
            var AnimalsWithMaxAndMinHealth = new { Max = OurZoo.OrderByDescending(x => x.CurrentHealth).First(), Min = OurZoo.OrderByDescending(z => z.CurrentHealth).First() };
            Console.WriteLine("Result: {0} ----------------- {1} has MAX - {2}", AnimalsWithMaxAndMinHealth.Max, AnimalsWithMaxAndMinHealth.Max.Alias, AnimalsWithMaxAndMinHealth.Max.CurrentHealth);
            Console.WriteLine("Result: {0} ----------------- {1} has MIN - {2}", AnimalsWithMaxAndMinHealth.Min, AnimalsWithMaxAndMinHealth.Min.Alias, AnimalsWithMaxAndMinHealth.Min.CurrentHealth);



            //  .Where(x => ($"{x.CurrentHealth }".Max() == x.CurrentHealth) || ($"{x.CurrentHealth}".Min() == x.CurrentHealth))

          
        }
        public void AverageHealthShow(ref List<Animal> OurZoo)
        {
            var AverageHealth = OurZoo.Average(x => x.CurrentHealth);
            Console.WriteLine($"The average health in zoo is: {AverageHealth}");
        }
    }
}
