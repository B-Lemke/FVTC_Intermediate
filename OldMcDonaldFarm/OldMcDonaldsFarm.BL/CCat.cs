using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Animals.Enumerations;

namespace Animals.BL
{
    public class Cat : CAnimal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public Cat()
        {
        }

        public Cat(string _color, AnimalType _type, float _cost, string _name)
        
        {
            this.Color = _color;
            this.Animaltype = _type;
            this.Cost = _cost;
            this.Name = _name;
        }

    }
}
