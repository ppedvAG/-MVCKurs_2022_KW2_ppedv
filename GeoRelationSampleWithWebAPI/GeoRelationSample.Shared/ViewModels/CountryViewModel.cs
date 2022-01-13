using GeoRelationSample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoRelationSample.Shared.ViewModels
{

    //In welchen View wäre das interessant -> Create / Edit
    public class CountryViewModel
    {
        public Country Country { get; set; }  

        public IList<Continent> SelectContinentList { get; set; }

    }
}
