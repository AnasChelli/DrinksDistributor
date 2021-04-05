namespace DrinksDistributor.Products
{
    public class Tea : IProduct
    {
        public string Name => GetType().Name;

        public double Price => 2;
    }
}
