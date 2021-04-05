using DrinksDistributor.Products;
using System.Collections.Generic;

namespace DrinksDistributor.Recipes
{
    public class Cappuccino : IRecipe
    {
        public IEnumerable<(IProduct, int)> Recipe => new List<(IProduct product, int nbOfDose)>
        {
            (new Coffee(), 1),
            (new Chocolate(), 1),
            (new Water(), 1),
            (new Cream(), 1)
        };
    }
}
