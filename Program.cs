using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace BinaryTask2.ByMyself
{
    class Program
    {
        static List<Animal> OurZoo = new List<Animal>();
        static List<Animal> DeadAnimals = new List<Animal>();
        static Random random = new Random();
        
        static int counter;
        static void Main(string[] args)
        {
            Stage tempstage = Stage.Satisfied;
            var th = new Thread(Live);
            th.Start();
            LINQ linq = new LINQ();
            AnimalFactory animFact = new AnimalFactory();
            Menu menu = new Menu();

            string name;
            string type;
            menu.Init();
            try
            {
                while (true)
                {


                    menu.ShowMenu();
                    int choice = Int32.Parse(Console.ReadLine());

                    switch (choice)
                    {

                        case 1:
                            menu.SecondMenu();
                            Console.WriteLine("\nEnter the name and type of the animal");
                            name = animFact.GetName();
                            type = animFact.GetType();
                            OurZoo.Add(animFact.AddAnimal(name, type));
                            break;
                        case 2:
                            Console.WriteLine("\nEnter the name of the animal");
                            name = animFact.GetName();
                            animFact.FeedAnimalFunc(name, ref OurZoo);
                            break;
                        case 3:
                            Console.WriteLine("\nEnter the name of the animal");
                            name = animFact.GetName();
                            animFact.HealAnimalFunc(name, ref OurZoo);
                            break;
                        case 4:
                            Console.WriteLine("\nEnter the name of the animal");
                            name = animFact.GetName();
                            animFact.DeleteAnimalFunc(name, ref OurZoo, ref DeadAnimals);
                            break;
                        case 5:
                            animFact.ShowAllAliveAnimals(ref OurZoo);
                            break;
                        case 6:
                            
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Press 1 to ComeBack\n\n");
                                Console.WriteLine("Press anything to reload page\n\n");
                                menu.ThirdMenuStrip(ref OurZoo);
                                string a = Console.ReadLine();
                                if (a == "1") break;
                            } 
                            break;
                        case 7:
                            menu.LinqMenuShow();
                            int choiceLinq = Int32.Parse(Console.ReadLine());
                            switch (choiceLinq)
                            {
                                case 1: linq.ShowAllAnimals(ref OurZoo); break;
                                case 2:
                                   
                                    menu.StageMenuShow();
                                    int ChooseStage = Int32.Parse(Console.ReadLine());
                                    switch (ChooseStage)
                                    {
                                        case 1: tempstage = Stage.Dead; break;
                                        case 2: tempstage = Stage.Sick; break;
                                        case 3: tempstage = Stage.Hungry; break;
                                        case 4: tempstage = Stage.Satisfied; break;
                                        default: break;
                                    }
                                    linq.AnimalsOrderByStage(ref OurZoo,tempstage); break;
                                case 3: linq.SickTigersShow(ref OurZoo); break;

                                case 4: name = animFact.GetName();
                                    linq.ShowElephantByAlias(ref OurZoo, name); break;
                                case 5: linq.HungryAnimalsShow(ref OurZoo);break;
                                case 6: linq.HealthyAnimalsFunc(ref OurZoo); break;
                                case 7: linq.DeadAnimalsShow(ref DeadAnimals); break;
                                case 8: linq.BearsAndWolvesHealthMoreThan3Show(ref OurZoo);break;
                                case 9: linq.AnimalsWithMaxAndMinHealthShow(ref OurZoo);break;
                                case 10: linq.AverageHealthShow(ref OurZoo); break;

                                default: break;
                                
                            }
                            break;
                        default: Console.WriteLine("Please enter correct number"); break;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
            private static void Live()
        {
            do
            {
                if (DeadAnimals.Count != 0 && OurZoo.Count == 0)
                {
                    Console.WriteLine("There isn't alive animal");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (OurZoo.Count == 0 && DeadAnimals.Count == 0)
                {
                    continue;
                }
                counter = random.Next(0, OurZoo.Count);
                OurZoo[counter].WorsenStatus();
                if(OurZoo[counter].stage == Stage.Sick)
                {
                    
                    OurZoo[counter].DecreaseHealth();
                }
                if(OurZoo[counter].stage == Stage.Dead)
                {
                    DeadAnimals.Add(OurZoo[counter]);
                    OurZoo.RemoveAt(counter);
                }
                Thread.Sleep(5000);
            } while (true);

            //  Console.ReadLine();
        }
    }
}
