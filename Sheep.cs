using System;

class Sheep : Animal
{
    public Sheep(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bææh");
    }
}
