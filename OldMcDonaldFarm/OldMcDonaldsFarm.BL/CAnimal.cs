using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Animals.Interfaces;
using Animals.Enumerations;

namespace Animals.BL
{
   
    public abstract class CAnimal : IAnimal
    {
        private string color;
        private float cost;
        private AnimalType type;
        
       
        
        public float Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public AnimalType Animaltype
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public bool Load()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
