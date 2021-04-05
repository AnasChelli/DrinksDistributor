using DrinksDistributor.Products;
using System.Collections.Generic;

namespace DrinksDistributor.Recipes
{
    public class Cappuccino : IRecipe
    {
        public IEnumerable<IProduct> Recipe => new List<IProduct> { new Coffee(), new Chocolate(), new Water(), new Cream() };
    }
}
