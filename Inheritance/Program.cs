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
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class



            Bird tweety = new Bird();
            {
                tweety.NumberOfWings = 2;
                tweety.CanFly = true;
                tweety.Eyes = 2;
                tweety.BeakLength = "nine inches";
                Console.WriteLine($"Tweety has {tweety.NumberOfWings} wings, a beak of {tweety.BeakLength}, and {tweety.Eyes} eyes.");
                Console.WriteLine();
            }

            Reptile croc = new Reptile();
            {
                croc.Eyes = 2;
                croc.PetName = "Killer Croc";
                croc.ScaleColor = "Greenish gray";
                croc.Legs = 2; //because it's Killer Croc
                Console.WriteLine($"Waylon Jones' criminal name is {croc.PetName}.");
                Console.WriteLine($"His skin color is {croc.ScaleColor}.");
                Console.WriteLine($"Since he's technically human, Croc has {croc.Legs} legs. ");
                Console.WriteLine($"Killer Croc gets punched in his {croc.Eyes} eyes by Batman.");
            }
        /*Create an object of your Bird class
         * DONE give values to your members using the object of your Bird class
         *  
         * DONE Creatively display the class member values 
         */

        /*Create an object of your Reptile class
         * DONE give values to your members using the object of your Bird class
         *  
         * Creatively display the class member values 
         */
    }
    }
    }

