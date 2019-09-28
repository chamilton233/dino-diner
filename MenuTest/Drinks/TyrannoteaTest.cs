using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveDefaultInfo()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        [Fact]
        public void ShouldHaveCorrectEverythingAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectEverythingAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectEverythingAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void HoldIceWorks()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        [Fact]
        public void AddLemonWorks()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Lemon = true;
            Assert.Contains<string>("Lemon", tea.Ingredients);
            tea.Lemon = false;
            Assert.DoesNotContain<string>("Lemon", tea.Ingredients);
        }
        [Fact]
        public void AddSweetGivesCorrectCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void AddSweetThenRemoveSweetGivesCorrectCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.DoesNotContain<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<uint>(8, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void HasCorrectIngredents()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            tea.Lemon = true;
            Assert.Contains<string>("Lemon", tea.Ingredients);
            tea.Sweet = true;
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            tea.Lemon = false;
            Assert.DoesNotContain<string>("Lemon", tea.Ingredients);
            tea.Sweet = false;
            Assert.DoesNotContain<string>("Cane Sugar", tea.Ingredients);
        }
    }
}
