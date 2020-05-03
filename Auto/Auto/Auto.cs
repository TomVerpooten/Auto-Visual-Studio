using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Auto
    {
        private string _merk;
        private string _nummerplaat;
        private string _type;

        public Auto()
        {
            Merk = "Niet gekend";
            Type = "Niet gekend";
            Nummerplaat = "Niet gekend";
        }

        public Auto(string merk, string type, string nummerplaat)
        {
            Merk = merk;
            Type = type;
            Nummerplaat = nummerplaat;
        }

        public string Merk
        {
            get
            {
                return _merk;
            }
            set
            {

                _merk = value;
            }
        }

        public string Nummerplaat
        {
            get
            {
                return _nummerplaat;
            }
            set
            {
                _nummerplaat = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public string tooninfo()
        {
            return "Uw auto is een " + Merk + " " + Type + " en heeft nummerplaat " + Nummerplaat;
        }
    }
}