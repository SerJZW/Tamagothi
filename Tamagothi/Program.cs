using System;
namespace Tamagothi
{
    class Program
    {
        static void Main(string[] args)
        {


            Cat cat = new Cat { name = "Barsic", hunger = 10 };
            cat.Meow();

            Fruit fruitApple = new Fruit { type = "apple", health = 10 };
            Fruit fruitOrange = new Fruit { type = "oragne", health = 5 };
            while (true)
            {
                Console.WriteLine("what we do with a cat? \n1)Do meal \n2)Go play \n3)Go run \n4)Meow! \n5)wait \n6)exit \n7)hunger");
                if (cat.hunger < 5 || cat.hunger == 0)
                {
                    Console.WriteLine("CAT DIED =(");
                    break;
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("what fruit give to cat? \n1)Apple \n2)Orange");
                int variaty = Convert.ToInt32(Console.ReadLine());
                if (variaty == 1)
                {
                    DoMeal(cat, fruitOrange, cat);
                }
                if (variaty == 2)
                {
                    DoMeal(cat, fruitApple, cat);
                }
                if (cat.hunger >= 50)
                {
                    Console.WriteLine("Cat is full");
                    cat.Play();
                }
                continue;
                    case 2:
                        cat.Run();
                if (cat.hunger <= 0)
                {
                    cat.Meow();
                }
                continue;
                    case 3:
                        cat.Run();
                if (cat.hunger <= 0)
                {
                    cat.Meow();
                }
                continue;
                    case 4:
                        cat.Meow();
                continue;
                    case 5:
                        
                        cat.Wait();
                        Console.WriteLine("Cat is waiting...." + cat.hunger + "Hunger waste");
                        continue;
                    case 6:
                        Console.WriteLine("Bye Bye!!");
                        break;
                    case 7:
                        Console.WriteLine(cat.hunger);
                        continue;
            }
            break;
        }

    }
    static void DoMeal(Cat c, Fruit f, Cat cat)
    {
        c.Eat(f, cat);
    }
}
}
