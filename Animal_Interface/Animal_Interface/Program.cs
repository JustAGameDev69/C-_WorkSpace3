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

    class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken sound: toac toac toac ";
        }

        public string HowToEat()
        {
            return "Chicken could be fried!";
        }
    }

    public abstract class Fruit : Edible
    {

        public abstract string HowToEat();
    }

    public class Apple: Fruit
    {

        public override string HowToEat()
        {
            return "Apple could be sliced!";
        }
    }

    public class Orange : Fruit
    {

        public override string HowToEat()
        {
            return "Orange could be juiced!";
        }
    }

    public interface Edible
    {
        public string HowToEat();
    }

    class Abstract_Interface
    {
        static void Main(string[] args)
        {
            Animal[] animals_1 = new Animal[2];

            animals_1[0] = new Tiger();
            animals_1[1] = new Chicken();

            foreach (Animal animal in animals_1)
            {
                Console.WriteLine(animal.MakeSound());

                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.HowToEat());
                }
            }

            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();

            foreach(Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
        }
    }
}