namespace DrinksDistributor.Products
{
    public class Chocolate : IProduct
    {
        public string Name => GetType().Name;

        public double Price => 1;
    }
}
