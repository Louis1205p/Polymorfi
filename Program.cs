using AnimalSounds;
using System;

class Program
{
    static void Main()
    {
        Animal dog = AnimalFactory.CreateAnimal(enmAnimals.Dog, "Max");
        Animal cat = AnimalFactory.CreateAnimal(enmAnimals.Cat);
        Animal sheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep);

        dog.MakeSound();
        cat.MakeSound();
        sheep.MakeSound();
    }
}
