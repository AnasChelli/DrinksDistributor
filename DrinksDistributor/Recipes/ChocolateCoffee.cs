using DrinksDistributor.Products;
using System.Collections.Generic;

namespace DrinksDistributor.Recipes
{
    public class ChocolateCoffee : IRecipe
    {
        public IEnumerable<(IProduct, int)> Recipe => new List<(IProduct product, int nbOfDose)>
        {
            (new Chocolate(), 3),
            (new Milk(), 2),
            (new Water(), 1),
            (new Suger(), 1)
        };
    }
}
