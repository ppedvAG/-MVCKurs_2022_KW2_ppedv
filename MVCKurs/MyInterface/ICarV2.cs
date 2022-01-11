using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    public interface ICarV2 : ICar
    {
        string Farbe { get; set; }

        bool AnhängerKupplung { get; set; }



    }
}
