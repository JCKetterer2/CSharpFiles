using System;

namespace week1.Fundamentals
{
    public class Pterodactyl : Dinosaur
    {
        public override void Eat()
        {
            Console.WriteLine("Pterodactyl Eat");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        
    }
}