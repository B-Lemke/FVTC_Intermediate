using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Enumerations;

namespace HeidsMusic.BL
{
    public class CBrass : CInstrument
    {
        private string _sFinish;

        public string Finish
        {
            get { return _sFinish; }
            set { _sFinish = value; }
        }
        private int _iValveCount;

        public int ValveCount
        {
           get { return _iValveCount; }
           set { _iValveCount = value; }
        }

      

        public CBrass()
        {
        }

        public CBrass(string finish, int valveCount, int cost, string manufacturer, string model, InstrumentType instrumentType)
        {
            // Parameters : Finish, Valvecount, Cost, Manufacturer, Model, Instrument Type
            this.Finish = finish;
            this.ValveCount = valveCount;
            this.Cost = cost;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Type = instrumentType;

        }
    }
}
