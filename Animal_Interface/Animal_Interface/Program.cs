using System;

namespace AnkaraMessi
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger sound: gruuuuuuhhhhhhh ";
        }
    }

    class Chicken : Animal
    {
        public override string MakeSound()
        {
            return "Chicken sound: toac toac toac ";
        }

    }

    class Abstract_Interface
    {
        static void Main(string[] args)
        {
            Animal[] animals_1 = new Animal[2];

            animals_1[1] = new Chicken();
            animals_1[2] = new Tiger();

            foreach (Animal animal in animals_1)
            {
                Console.WriteLine(animal.MakeSound());
            }
        }
    }
}