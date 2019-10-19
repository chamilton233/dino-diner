using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SadasaurusTest
    {
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultInfo()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50,soda.Price);
            Assert.Equal<uint>(112, soda.Calories);
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        [Fact]
        public void ShouldHaveCorrectEverythingAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
            Assert.Equal<uint>(112, soda.Calories);
        }
        [Fact]
        public void ShouldhaveCorrectEverythingAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2, soda.Price);
            Assert.Equal<uint>(156, soda.Calories);
        }
        [Fact]
        public void ShouldhaveCorrectEverythingAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
            Assert.Equal<uint>(208, soda.Calories);
        }
        [Fact]
        public void ShouldHaveDefualtIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }
        [Fact]
        public void ShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectIngreadents()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }


        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal($"{soda.Size} {soda.Flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void ChangingFlavorShouldChangeDescription()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor=SodasaurusFlavor.Chocolate;
            Assert.Equal($"{soda.Size} Chocolate Sodasaurus", soda.Description);
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal($"{soda.Size} Cola Sodasaurus", soda.Description);
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal($"{soda.Size} Lime Sodasaurus", soda.Description);
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal($"{soda.Size} Orange Sodasaurus", soda.Description);
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal($"{soda.Size} RootBeer Sodasaurus", soda.Description);
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal($"{soda.Size} Vanilla Sodasaurus", soda.Description);
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal($"{soda.Size} Cherry Sodasaurus", soda.Description);
        }

        [Fact]
        public void ChangingSizeShouldChangeDescription()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal($"Medium {soda.Flavor} Sodasaurus", soda.Description);
            soda.Size = Size.Large;
            Assert.Equal($"Large {soda.Flavor} Sodasaurus", soda.Description);
            soda.Size = Size.Small;
            Assert.Equal($"Small {soda.Flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.PropertyChanged(soda, "Special", () =>
            {
                soda.HoldIce();
            });
        }

        [Fact]
        public void ChangingFlavorShouldNotifyDescriptonChange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor=SodasaurusFlavor.Orange;
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Flavor = SodasaurusFlavor.Orange;
            });
        }


        [Fact]
        public void ChangingSizeShouldNotifyDescriptionChange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Medium;
            });

        }
    }
}
