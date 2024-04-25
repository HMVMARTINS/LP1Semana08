using System;

namespace AnimalKingdom
{
    // Define a interface IMammal
    public interface IMammal
    {
        int NumberOfNipples { get; }
    }

    // Define a interface ICanFly
    public interface ICanFly
    {
        int NumberOfWings { get; }
    }

    // Define a classe Animal
    public abstract class Animal
    {
        public virtual string Sound()
        {
            return "Sound will be ";
        }
    }
}
    
