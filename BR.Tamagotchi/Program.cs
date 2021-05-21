using BR.Tamagotchi.Model;
using System;
using System.Threading;

namespace BR.Tamagotchi
{
    public class Program
    {
        public  static Dragon dragon;

        static void Main(string[] args)
        {
            dragon = new Dragon("MyDragon");
            var thread = new Thread(new ThreadStart(DragonLifeCycle));
            thread.Start();
           


            while (true)
            {
                Console.WriteLine($"\n Current state of Tamagotchi Name: {dragon.Name} \tLife: {dragon.Life.ToString()} \tAge: {dragon.Age} \tWeight: {dragon.Weight} \tHungerLevel {dragon.HungerLevel} \tHappiness: {dragon.Happiness}");
                Console.WriteLine($"\n\n\nEnter your selection:");
                Console.WriteLine($"\nPress 1 , If you want to Pet your Dragon");
                Console.WriteLine($"\nPress 2 , If you want to Feed your Dragon");
                Console.WriteLine($"\nPress 3 , If you want to Pay with your Dragon\n\n");

                var key= (char)Console.Read();

                switch (key)
                {
                    case '1':
                        dragon.Pet();
                        break;
                    case '2':
                        dragon.Feed();
                        break;
                    case '3':
                        dragon.Play();
                        break;
                    default:
                        break;

                }
                Console.Clear();
                
            }
        }
     
        public   static void DragonLifeCycle()
        {
            while (true)
            {
                Thread.Sleep(3000);

                dragon.Happiness = dragon.Happiness <= 0 ? 0 : --dragon.Happiness;
                dragon.HungerLevel += 1;
                dragon.Age++;

                if (dragon.Age >= 10)
                {
                    switch (dragon.Life)
                    {
                        case Life.Baby:
                            dragon.Life = Life.Child;
                            dragon.Age = 1;
                            break;
                        case Life.Child:
                            dragon.Life = Life.Teen;
                            dragon.Age = 1;
                            break;
                        case Life.Teen:
                            dragon.Life = Life.Adult;
                            dragon.Age = 1;
                            break;
                        case Life.Adult:
                            Console.WriteLine($"Your Dragon Name:{dragon.Name} has reached its life and is dead now :");
                            System.Threading.Thread.Sleep(1000);
                            dragon.Life = Life.Baby;
                            dragon.Age = 1;
                            dragon.Name = dragon.Name;
                            dragon.Weight = 1;
                            dragon.Happiness = 5;
                            dragon.HungerLevel = 5;
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"\n Current state of Tamagotchi Name: {dragon.Name} \tLife: {dragon.Life.ToString()} \tAge: {dragon.Age} \tWeight {dragon.Weight} \tHungerLevel {dragon.HungerLevel} \tHappiness {dragon.Happiness}");
            }

            


        }



    }
}
