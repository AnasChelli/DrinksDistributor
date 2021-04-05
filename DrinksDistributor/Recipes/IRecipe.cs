using DrinksDistributor.Products;
using System.Collections.Generic;

namespace DrinksDistributor.Recipes
{
    public interface IRecipe
    {
        public IEnumerable<(IProduct, int)> Recipe { get; }
    }
}
