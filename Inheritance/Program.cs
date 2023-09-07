using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Animal animal = new Animal();
            animal.HaveEyes = true;
            animal.GreatHearing = "depends on the animal";
            animal.CanRunFast = "only some have the art of speed";
            animal.FightOrFlight = "of course we use it everyday";

            animal.PrintAnimalDetails();

            Bird bird = new Bird();
            Console.WriteLine("---------------------------------------------");
            bird.HaveWings = "of course every bird has wings, but some can't fly.";
            bird.Feathers = "Every bird has feathers or fur of some kind.";
            bird.CanFly = true;
            bird.AreFast = true;

            bird.PrintBirdDetails();
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile = new Reptile();
            Console.WriteLine("----------------------------------------------");
            reptile.HasScale = "Reptiles all have scales";
            reptile.AreDinosaurs = "Reptiles have been around well before us, and will continue after we parish";
            reptile.AreColdBlooded = true;
            reptile.EatsMeat = "they are carnivores";

            reptile.PrintReptileDetails();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
