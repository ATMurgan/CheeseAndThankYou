namespace CheeseAndThankYou.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String Name { get; set; } 
        
        // Child ref to Products. Make child nullable so we can add categories without products
        public List<Product>? Products { get; set; }
    }
}
