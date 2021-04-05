namespace DrinksDistributor.Products
{
    public class Cream : IProduct
    {
        public string Name => GetType().Name;

        public double Price => 0.5;
    }
}
