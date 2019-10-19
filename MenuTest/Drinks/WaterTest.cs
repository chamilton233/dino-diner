using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultInfo()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
            Assert.Equal<double>(0.10, water.Price);
            Assert.False(water.Lemon);
        }
        [Fact]
        public void AddLemonWorks()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }
        [Fact]
        public void CorrectInfoWhenChangingSizes()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
            Assert.Equal<double>(0.10, water.Price);
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
            Assert.Equal<double>(0.10, water.Price);
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
            Assert.Equal<double>(0.10, water.Price);
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
            Assert.Equal<double>(0.10, water.Price);

        }
        [Fact]
        public void HoldIceWorks()
        {
            Water water = new Water();
            Assert.True(water.Ice);
            water.HoldIce();
            Assert.False(water.Ice);
        }
        [Fact]
        public void HasCorrectIngreadients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            water.AddLemon();
            Assert.Contains<string>("Lemon", water.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Water water = new Water();
             Assert.Equal($"{water.Size} Water", water.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void HoldIceAndAddLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }


        [Fact]
        public void ChangingSizeShouldChangeDescription()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal("Medium Water", water.Description);
            water.Size = Size.Large;
            Assert.Equal("Large Water", water.Description);
            water.Size = Size.Small;
            Assert.Equal("Small Water", water.Description);
            
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }



        [Fact]
        public void ChangingSizeShouldNotifyDescriptionChange()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.Size = Size.Medium;
            });


        }
    }
}
