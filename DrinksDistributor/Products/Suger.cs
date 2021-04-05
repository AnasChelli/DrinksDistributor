namespace DrinksDistributor.Products
{
    public class Suger : IProduct
    {
        public string Name => GetType().Name;

        public double Price => 0.1;
    }
}
