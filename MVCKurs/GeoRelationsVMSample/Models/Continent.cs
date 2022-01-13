

namespace GeoRelationsVMSample.Models
{
    public class Continent
    {
        public int Id { get; set; }

        public string Name { get; set; }


        #region Navigation

        public virtual ICollection<Country> Countries { get; set; }
        #endregion Navigation
    }
}
