namespace ShoppingCart.BFF.Product.Core;

public class ProductEntity {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
    public IEnumerable<Review> Reviews { get; set; } = null!;
}

public enum Rating
{
    AMAZING,
    GOOD,
    OKAY,
    POOR,
    BAD
}

public class Review
{
    public Guid Id { get; set; }
    public string Reviewer { get; set; } = null!;
    public string Content { get; set; } = null!;
    public Rating Stars { get; set; }
}