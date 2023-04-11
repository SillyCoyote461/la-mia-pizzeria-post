namespace WebApplication1.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; } = 0.0f;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;

    }
}
