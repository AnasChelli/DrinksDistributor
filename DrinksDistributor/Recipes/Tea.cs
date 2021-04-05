using DrinksDistributor.Products;
using System.Collections.Generic;

namespace DrinksDistributor.Recipes
{
    public class Tea : IRecipe
    {
        public IEnumerable<(IProduct, int)> Recipe => new List<(IProduct product, int nbOfDose)>
        {
            (new Products.Tea(), 1),
            (new Water(), 2)
        };
    }
}
