using DrinksDistributor.Recipes;
using System;

namespace DrinksDistributor
{
    public class DrinksEngine
    {
        private double price;

        public double GetReceipiesPrice(IRecipe recipe)
        {
            foreach (var product in recipe.Recipe)
            {
                price += product.Price;
            }

            return Math.Round(price += price * 0.3d, 2);
        }
    }
}