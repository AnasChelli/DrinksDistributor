namespace DrinksDistributor.Products
{
    public class Water : IProduct
    {
        public string Name => GetType().Name;

        public double Price => 0.2;
    }
}
