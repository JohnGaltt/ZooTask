using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTask2.ByMyself
{
    class Menu
    {
        Dictionary<int, string> MainMenu = new Dictionary<int, string>();
        Dictionary<int, string> LINQMenu = new Dictionary<int, string>();
        Dictionary<int, string> StageMenu = new Dictionary<int, string>();

        Hashtable ZooMenu = new Hashtable();
        public void Init()
        {
            StageMenu.Add(1, "Dead");
            StageMenu.Add(2, "Sick");
            StageMenu.Add(3, "Hungry");
            StageMenu.Add(4, "Satiesfied");

            MainMenu.Add(1, "To add animal");
            MainMenu.Add(2, "To feed animal");
            MainMenu.Add(3, "To heal animal");
            MainMenu.Add(4, "To delete animal");
            MainMenu.Add(5, "To see animals");
            MainMenu.Add(6, "To see the procces");
            MainMenu.Add(7, "LINQ");

            ZooMenu.Add("Fox", "Type 'Fox' if you want to add Fox");
            ZooMenu.Add("Tiger", "Type 'Tiger' if you want to add Tiger");
            ZooMenu.Add("Elephant", "Type 'Elephant' if you want to add Elephant");
            ZooMenu.Add("Bear", "Type 'Bear' if you want to add Bear");
            ZooMenu.Add("Wolf", "Type 'Wolf' if you want to add Wolf");
            ZooMenu.Add("Lion", "Type 'Lion' if you want to add Lion");

            LINQMenu.Add(1, "To see all animals order by type of the animal");
            LINQMenu.Add(2, "Order animals by stage");
            LINQMenu.Add(3, "To see sick tigers");
            LINQMenu.Add(4, "To see Elephant by name");
            LINQMenu.Add(5, "To show hungry animals");
            LINQMenu.Add(6, "To show distinct healthy animals");
            LINQMenu.Add(7, "To show deadAnimals ");
            LINQMenu.Add(8, "To show bears and wolves with health more than 3");
            LINQMenu.Add(9, "To show the animals with min health and with max health");
            LINQMenu.Add(10, "To show the average health in Zoo");
        }
        public void ShowMenu()
        {
            
            foreach (KeyValuePair<int, string> keyValue in MainMenu)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }
        }
        public void SecondMenu()
        {
            foreach(DictionaryEntry value in ZooMenu)
            {
                Console.WriteLine(value.Value);
            }
        }
        public void ThirdMenuStrip(ref List<Animal> AliveAnimals)
        {
            foreach(var i in AliveAnimals)
            {
                i.Show();
            }
        }
        public void LinqMenuShow()
        {
            foreach (KeyValuePair<int, string> keyValue in LINQMenu)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
      public void StageMenuShow()
        {
            foreach (KeyValuePair<int, string> keyValue in StageMenu)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
    }
}
