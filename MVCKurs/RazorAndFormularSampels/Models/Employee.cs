using System.ComponentModel.DataAnnotations;

namespace RazorAndFormularSampels.Models
{

    //Kriterien eines Datensatz werden mit Data Annotations gesetzt

    // https://docs.microsoft.com/de-de/dotnet/api/system.componentmodel.dataannotations?view=net-6.0
    public class Employee
    {
        public int Id { get; set; } //Id ist für die Datenbank wichtig -> Unique Identity 
        //public Guid AlternativeID { get; set; } = Guid.NewGuid();

        [Required] //Muss Feld
        [Display(Name = "Firstname")]
        public string FirstName { get; set; } = string.Empty;

        [Required] //Muss Feld
        [Display(Name = "Lastname")]
        public string LastName { get; set; } = string.Empty;


        public DateTime Birthday { get; set; } = DateTime.Now; //Default - Wert


        //MinLengthAttribute
        [MinLength(10)] //Wenn Eingabe, dann mindestens 10 Zeichen
        public string Address { get; set; } = string.Empty; 
    }
}
