namespace GeoRelationSample.Shared.Models
{
    public class Continent
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
