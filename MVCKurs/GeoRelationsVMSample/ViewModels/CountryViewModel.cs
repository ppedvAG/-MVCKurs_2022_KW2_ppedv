using GeoRelationsVMSample.Models;

namespace GeoRelationsVMSample.ViewModels
{
    public class CountryViewModel
    {
        public Country Country { get; set; } // Objekt wird im Formular befüllt  

        public IList<Continent> SelectContinentList { get; set; } //Benötigen wir vorab um ein Land ein Kontinentn zuzuordnen. 


    }
}
