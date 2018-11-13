using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Animals.Enumerations;

 namespace Animals.Interfaces
{
    public interface IAnimal
    {
        bool Save();
        bool Load();

        string Color { get; set; }
        float Cost { get; set; }
        AnimalType Animaltype { get; set; }
    }

    public interface IAnimals
    {
        void Save();
        
    }
}


