using MyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodCar
{
    public class CarV2 : ICarV2
    {
        public string Farbe { get; set; } = default!;
        public bool AnhängerKupplung { get; set; }
        public string Marke { get; set; } = default!;
        public string Modell { get; set; } = default!;
        public int Baujahr { get; set; }

        public bool HatTüv()
        {
            return true;
        }
    }
}
