namespace MVCSamples.Models
{
    public class PositionOptions
    {
        public const string Position = "Position";

        public string Title { get; set; } = default!; //default! ist bei jedem datentyp anwendbar


        public string Name { get; set; } = string.Empty;

    }
}
