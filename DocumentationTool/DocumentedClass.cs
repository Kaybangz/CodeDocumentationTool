using System;
using System.Runtime.CompilerServices;


namespace DocumentationTool
{
    [CustomAttribute("These are animals that give birth to their young ones alive")]
    public class Mammals
    {
        [CustomAttribute("Every animal should have a name", Input = "Name of the animal")]
        public string Name { get; set; }

        [CustomAttribute("Every animal should have an age", Input = "Age of the animal")]
        public int Age { get; set; }


        [CustomAttribute("Every animal should has a gender", Input = "Takes in both known genders")]
        public enum Gender
        {
            Male,
            Female,
        }

        [CustomAttribute("Mammals know the sex of their babies at birth", Input = "Takes in the gender", Output = "Logs a string to the console")]
        public void GivingBirth(Gender gender)
        {
            if (gender == Gender.Male) Console.WriteLine("It's a male mammal");
            else Console.WriteLine("It's a female mammal");
        }

    }


    [CustomAttribute("These are animals that do not give birth to their young ones alive")]
    public class Reptiles
    {
        [CustomAttribute("Every animal should have a name", Input = "Name of the animal")]
        public string Name { get; set; }

        [CustomAttribute("Every animal should have an age", Input = "Age of the animal")]
        public int Age { get; set; }


        [CustomAttribute("Every animal should has a gender", Input = "Takes in both known genders")]
        public enum Gender
        {
            Male,
            Female,
        }

        [CustomAttribute("Reptiles do not know the sex of their babies at birth", Input = "Takes in the gender", Output = "Logs a string to the console")]
        public void GivingBirth(Gender gender, bool isMale)
        {
            var random = new Random();

            isMale = random.Next(2) == 1;

            if (gender == Gender.Male) Console.WriteLine("It's a male reptile");
            else Console.WriteLine("It's a female reptile");
        }
    }
}
