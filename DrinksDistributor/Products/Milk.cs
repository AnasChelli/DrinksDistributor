namespace DrinksDistributor.Products
{
    public class Milk : IProduct
    {
        public string Name => GetType().Name;

        public double Price => 0.4;
    }
}
