#nullable disable
namespace GeoRelationSample.Shared.Models
{
    public class LanguageInCountry
    {
        public int Id { get; set; } 

        public int Percent { get; set; } = 0;





        public int LanguageId { get; set; }
        public virtual Language LanguageRef { get; set; }

        public int CountryId { get; set; }
        public virtual Country CountryRef { get; set; }
    }
}
