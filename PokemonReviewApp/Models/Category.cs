namespace PokemonReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string categoryType { get; set; }
        public string Description { get; set; }
       public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
