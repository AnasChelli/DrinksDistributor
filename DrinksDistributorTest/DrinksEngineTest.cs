using DrinksDistributor;
using DrinksDistributor.Recipes;
using NFluent;
using NUnit.Framework;

namespace DrinksDistributorTest
{
    public class DrinksEngineTest
    {
        private IRecipe _recipe;
        private DrinksEngine _drinksEngine;

        [SetUp]
        public void Setup()
        {
            _drinksEngine = new DrinksEngine();
        }

        [Test]
        public void Should_return_expresso_price_when_receipie_name_is_expresso()
        {
            _recipe = new Expresso();

            var price = _drinksEngine.GetReceipiesPrice(_recipe);

            Check.That(price).Equals(1.56);
            Check.That(price).Equals(1.56);
        }

        [Test]
        public void Should_return_long_coffee_price_when_receipie_name_is_long_coffee()
        {
            _recipe = new LongCoffee();

            var price = _drinksEngine.GetReceipiesPrice(_recipe);

            Check.That(price).Equals(1.82);
        }

        [Test]
        public void Should_return_cappuccino_price_when_receipie_name_is_cappuccino()
        {
            _recipe = new Cappuccino();

            var price = _drinksEngine.GetReceipiesPrice(_recipe);

            Check.That(price).Equals(3.51);
        }

        [Test]
        public void Should_return_chocolate_price_when_receipie_name_is_chocolate()
        {
            _recipe = new ChocolateCoffee();

            var price = _drinksEngine.GetReceipiesPrice(_recipe);

            Check.That(price).Equals(5.33);
        }

        [Test]
        public void Should_return_tea_price_when_receipie_name_is_tea()
        {
            _recipe = new Tea();

            var price = _drinksEngine.GetReceipiesPrice(_recipe);

            Check.That(price).Equals(3.12);
        }
    }
}