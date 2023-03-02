using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagothi
{
    struct Fruit
    {
        public string type;
        public int health;
        
    }
   
    class Cat
    {
        public string name;
        public int hunger;
        public void Meow()
        {
            Console.WriteLine("meow meow!");
        }
        public void Eat(Fruit f, Cat cat)
        { 
           
            Console.WriteLine($"{name} eats {f.type}. {f.health} hp.");
            hunger = hunger + f.health;
        }
        public void Play()
        {
            hunger = hunger - 5;
            Console.WriteLine("Cat is playing...  Hunger is " + hunger);
        }
        public void Run()
        {
            hunger = hunger - 10;
            Console.WriteLine("Cat is runing... Hunger is " + hunger);
        }
        public void Wait()
        {
            Random rnd = new Random();
            hunger = hunger - rnd.Next(2,4);
           
        }
        
    }
}
