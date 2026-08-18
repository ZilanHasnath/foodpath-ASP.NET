namespace dotnet.Models
{
    public class ProductDetails
    {
        public string Name { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public float Rating { get; set; }
        public int ReviewCount { get; set; }
        public string Description { get; set; } = string.Empty;
        public string[] Ingredients { get; set; } = System.Array.Empty<string>();
        public string[] Highlights { get; set; } = System.Array.Empty<string>();
    }

    public class LandingPageViewModel
    {
        public ProductDetails Product { get; set; } = new();
    }
}