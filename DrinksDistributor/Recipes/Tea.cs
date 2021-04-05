using DrinksDistributor.Products;
using System.Collections.Generic;

namespace DrinksDistributor.Recipes
{
    public class Tea : IRecipe
    {
        public IEnumerable<IProduct> Recipe => new List<IProduct> { new Products.Tea(), new Water(), new Water() };
    }
}
