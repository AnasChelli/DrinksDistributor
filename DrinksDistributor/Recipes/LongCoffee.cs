using DrinksDistributor.Products;
using System.Collections.Generic;

namespace DrinksDistributor.Recipes
{
    public class LongCoffee : IRecipe
    {
        public IEnumerable<IProduct> Recipe => new List<IProduct> { new Coffee(), new Water(), new Water() };
    }
}
