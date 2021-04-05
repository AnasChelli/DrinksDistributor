using DrinksDistributor.Constants;
using DrinksDistributor.Recipes;
using System;

namespace DrinksDistributor
{
    public class DrinksEngine
    {
        private double _price;

        public double GetReceipiesPrice(IRecipe recipe)
        {
            foreach (var (product, nbOfDose) in recipe.Recipe)
            {
                _price += product.Price * nbOfDose;
            }

            return Math.Round(_price += _price * ProfitMargin.Value, 2);
        }
    }
}