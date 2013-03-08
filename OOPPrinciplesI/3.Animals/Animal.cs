using System;

namespace _3.Animals
{
    /// <summary>
    /// Hold information about animals' sex
    /// </summary>
    enum Sex
    {
        Male, Female
    }

    /// <summary>
    /// Abstract class to hold information about a generic animal
    /// </summary>
    abstract class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Sex Sex { get; protected set; }
        protected virtual string Sound { get; set; }

        /// <summary>
        /// Holds all animal sounds as strings
        /// </summary>
        protected static string[] AnimalSounds
        {
            get
            {
                return new string[]{"Woof!", "Quak!", "Meooow!", "Meow Meow!", "Psss!"};
            }
        }

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public void ProduceSound()
        {
            Console.WriteLine(Sound);
        }

        /// <summary>
        /// Identifies an animal by its sound
        /// </summary>
        /// <param name="sound">The ounds to identify</param>
        /// <returns>Identified animal as string</returns>
        public static string Identify(string sound)
        {
            int index = Array.IndexOf(AnimalSounds, sound);

            switch (index)
            {
                case 0:
                    return "Dog";
                    break;
                case 1:
                    return "Frog";
                    break;
                case 2:
                    return "Cat";
                    break;
                case 3:
                    return "Kitten";
                    break;
                case 4:
                    return "Tomcat";
                    break;
                default:
                    return "Not recognised";
                    break;
            }
        }

        /// <summary>
        /// Calculates the verage age of all animal in an array
        /// </summary>
        /// <param name="animals">The animals</param>
        /// <returns>The average age</returns>
        public static double CalculateAverageAge(Animal[] animals)
        {
            double sum = 0;

            for(int i = 0; i < animals.Length; i ++)
            {
                sum += animals[i].Age;
            }

            return sum / animals.Length;
        }
    }
}
