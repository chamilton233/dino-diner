using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class DinoNuggetsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal(4.25, dn.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal<uint>(59*6, dn.Calories);
        }


        [Fact]
        public void ShouldListDefaultIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            List<string> ingredients = dn.Ingredients;
            // Should be six nuggets
            int nuggetCount = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(6, nuggetCount);
            Assert.Equal<int>(6, ingredients.Count);
        }

        [Fact]
        public void AddingNuggetsShouldAddIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            // Should be seven nuggets
            int nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(7, nuggetCount);
            Assert.Equal<int>(7, dn.Ingredients.Count);

            dn.AddNugget();
            // Should be 8 nuggets
            nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(8, nuggetCount);
            Assert.Equal<int>(8, dn.Ingredients.Count);

        }

        [Fact]
        public void AddingNuggetsShouldIncreasePrice()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal<double>(4.50, dn.Price);
            dn.AddNugget();
            Assert.Equal<double>(4.75, dn.Price);
            dn.AddNugget();
            Assert.Equal<double>(5.00, dn.Price);
        }

        [Fact]
        public void AddingNuggetsShouldIncreaseCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*7);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*8);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*9);
        }

        [Fact]
        public void AddingNuggetsShouldNotifySpecialChange()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.PropertyChanged(dn, "Special", () =>
            {
                dn.AddNugget();
            });
            Assert.PropertyChanged(dn, "Ingredients", () =>
            {
                dn.AddNugget();
            });
        }
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Empty(dn.Special);
        }

        [Fact]
        public void AddingNuggetsShouldAddToSpecial()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Collection<string>(dn.Special, item =>
            {
                Assert.Equal("1 Extra Nuggets", item);
            });
            dn.AddNugget();
            Assert.Collection<string>(dn.Special, item =>
            {
                Assert.Equal("2 Extra Nuggets", item);
            });
            dn.AddNugget();
            Assert.Collection<string>(dn.Special, item =>
            {
                Assert.Equal("3 Extra Nuggets", item);
            });
        }
    }
}
