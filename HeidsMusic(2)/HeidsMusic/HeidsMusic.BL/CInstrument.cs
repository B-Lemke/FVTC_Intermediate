using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Interfaces;
using HeidsMusic.Enumerations;

namespace HeidsMusic.BL
{
   

    public abstract class CInstrument : IInstrument
    {
        private string _sManufacturer;
        private float _fCost;
        private string _sModel;
 
        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Load()
        {
            throw new NotImplementedException();
        }

        public string Manufacturer
        {
            get
            {
                return _sManufacturer;
            }
            set
            {
                _sManufacturer = value;
            }
        }

        public float Cost
        {
            get
            {
                return _fCost;
            }

            set
            {
                _fCost = value;
            }
        }

        public string Model
        {
            get
            {
                return _sModel;
            }
            set
            {
                _sModel = value;
            }
        }

        public InstrumentType Type { get; set; }
   
    }
}
