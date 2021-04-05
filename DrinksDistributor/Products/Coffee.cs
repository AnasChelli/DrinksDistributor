namespace DrinksDistributor.Products
{
    public class Coffee : IProduct
    {
        public string Name => GetType().Name;
        public double Price => 1;
    }
}
