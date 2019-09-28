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
    }
}
