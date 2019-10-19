using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }


        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Empty(sb.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Whole Wheat Bun", item);
            });
        }

        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }

        [Fact]
        public void HoldBunAndHoldOnionAndHoldPeppersShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldKetchup();
            sb.HoldMustard();
            sb.HoldPickle();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Whole Wheat Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickle", item);
            },
            item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldBun();
            });
        }

        [Fact]
        public void HoldKetchupShouldNotifySpecialChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            });
            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldKetchup();
            });
        }

        [Fact]
        public void HoldMustardShouldNotifySpecialChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            });
            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldMustard();
            });
        }

        [Fact]
        public void HoldPickleShouldNotifySpecialChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            });
            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldPickle();
            });
        }
    }

}
