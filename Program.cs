using BinaryTask2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Timers;

public class Program
{
    public static List<Animal> Zoo = new List<Animal>();
    public static List<Animal> DeadAnimals = new List<Animal>();
    public static int alive_animals = 0;
    public static Random  randomAn = new Random();
  
    public static void Main()
    {
        Thread myThread = new Thread(Live);
        myThread.Start();

        while (true)
        {
      
            Console.WriteLine("Write 1 to add animal, 2- to feed animal, 3 - heal animal, 4 - to delete animal  5 -to show animals");
            string choise = Console.ReadLine();
            Animal animal = new Animal();
            switch (choise)
            {
                case "1": Console.WriteLine("Enter name and type animal");  string name = Console.ReadLine(); string type = Console.ReadLine();Zoo.Add(AnimalFactory.GetAnimal(name,type)); alive_animals++; break;
                case "2": string name1 = Console.ReadLine(); Animal.FeedAnimal(name1,ref Zoo); break;
                case "3": string name2 = Console.ReadLine(); Animal.Heal(name2, ref Zoo); break;
                case "4": string name3 = Console.ReadLine(); Animal.DeleteFromZoo(name3, ref DeadAnimals); break;
                case "5": Show(); break;
                default: break;
            }
        }
    }
    public static void Show()
    {
        foreach(Animal an in Zoo)
        {
            Animal.Show(an);
        }
    }
    private static void Live()
    {
        do
        {
            if (DeadAnimals.Count != 0 && Zoo.Count == 0)
            {
                Console.WriteLine("There isn't alive animal");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (Zoo.Count == 0 && DeadAnimals.Count == 0)
            {
                continue;
            }   
            counter = randomAn.Next(0, Zoo.Count);
            Zoo[counter].DecreaseState();
            if(Zoo[counter].State == State.dead)
            {
                DeadAnimals.Add(Zoo[counter]);
                Zoo.RemoveAt(counter);
            }
            Thread.Sleep(5000);
        } while (true);
    }
    public static int counter;
    
}