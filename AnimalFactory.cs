using AnimalSounds;
using System;

class AnimalFactory
{
    public static Animal CreateAnimal(enmAnimals animalType, string name)
    {
        return animalType switch
        {
            enmAnimals.Dog => new Dog(name),
            enmAnimals.Cat => new Cat(name),
            enmAnimals.Sheep => new Sheep(name),
            _ => throw new ArgumentException("Invalid animal type")
        };
    }

    public static Animal CreateAnimal(enmAnimals animalType)
    {
        string defaultName = animalType switch
        {
            enmAnimals.Dog => "Luna",
            enmAnimals.Cat => "Bella",
            enmAnimals.Sheep => "Daisy",
            _ => "Unknown"
        };
        return CreateAnimal(animalType, defaultName);
    }
}
