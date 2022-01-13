#nullable disable
using System.ComponentModel.DataAnnotations;

namespace GeoRelationSample.Shared.Models
{

    //Index verwenden + Include(c=c.Continents) 
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;   
        
        public int? Population { get; set; }

        [Required]
        public int ContinentId { get; set; }

        public virtual Continent ContinentRef { get; set; } 

        public virtual ICollection<Language> Languages { get; set; } = new List<Language>();
    }
}
