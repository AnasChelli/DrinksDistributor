using DrinksDistributor.Products;
using System.Collections.Generic;

namespace DrinksDistributor.Recipes
{
    public class ChocolateCoffee : IRecipe
    {
        public IEnumerable<IProduct> Recipe => new List<IProduct> { new Chocolate(), new Chocolate(), new Chocolate(), new Milk(), new Milk(), new Water(), new Suger() };
    }
}
