#nullable disable
namespace GeoRelationSample.Shared.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
