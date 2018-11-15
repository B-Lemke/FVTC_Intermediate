using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Enumerations;

namespace HeidsMusic.BL
{
    public class CWoodwind : CInstrument
    {
        private string _reedType;

        public string ReedType
        {
            get { return _reedType; }
            set { _reedType = value; }
        }
        private int _reedCount;

        public int ReedCount
        {
            get { return _reedCount; }
            set { _reedCount = value; }
        }

        public CWoodwind()
        {
        }

        public CWoodwind(string reedType, int reedCount, int cost, string manufacturer, string model, InstrumentType instrumentType)
        {
            // Parameters : Reed Type, Reed Count, Cost, Manufacturer, Model, Instrument Type
            this.ReedType = reedType;
            this.ReedCount = reedCount;
            this.Cost = cost;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Type = instrumentType;
        }
    }
}
