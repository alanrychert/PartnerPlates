namespace PartnerPlatesBackend.Models
{
    public class Combo
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public required decimal Price { get; set; }
    }
}
