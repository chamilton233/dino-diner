using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultInfo()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
            Assert.Equal<uint>(2, java.Calories);
            Assert.Equal<Size>(Size.Small, java.Size);
            Assert.False(java.Ice);
            Assert.False(java.Decaf);
        }

        [Fact]
        public void ShouldHaveCorrectEverythingAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectEverythingAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectEverythingAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
            Assert.Equal<uint>(8, java.Calories);
        }
        [Fact]
        public void AddIceWorks()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        [Fact]
        public void LeaveSpaceForCreamWorks()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        [Fact]
        public void HasCorrectIngredents()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
        }


        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            JurassicJava java = new JurassicJava();
            if (java.Decaf)
            {
                Assert.Equal($"{java.Size} Decaf Jurassic Java", java.Description);
            }
            else
            {
                Assert.Equal($"{java.Size} Jurassic Java", java.Description);
            }
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void HoldDressingShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void ChangingSizeShouldChangeDescription()
        {
            JurassicJava java = new JurassicJava();
            java.Size=Size.Medium;
            if (java.Decaf)
            {
                Assert.Equal("Medium Decaf Jurassic Java", java.Description);
            }
            else
            {
                Assert.Equal("Medium Jurassic Java", java.Description);
            }
            java.Size = Size.Large;
            if (java.Decaf)
            {
                Assert.Equal("Large Decaf Jurassic Java", java.Description);
            }
            else
            {
                Assert.Equal("Large Jurassic Java", java.Description);
            }
            java.Size = Size.Small;
            if (java.Decaf)
            {
                Assert.Equal("Small Decaf Jurassic Java", java.Description);
            }
            else
            {
                Assert.Equal("Small Jurassic Java", java.Description);
            }
        }

        [Fact]
        public void ChangingDecafShouldChangeDiscription()
        {
            JurassicJava java = new JurassicJava();
            java.Decaf = true;
            Assert.Equal($"{java.Size} Decaf Jurassic Java", java.Description);
            java.Decaf = false;
            Assert.Equal($"{java.Size} Jurassic Java", java.Description);
        }



        [Fact]
        public void HoldIceAndLeaveRoomForCreamShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            },
            item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void AddIceShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            });
        }

        [Fact]
        public void ChangingDecafShouldNotifyDescriptionChange()
        {
            JurassicJava java = new JurassicJava();
            java.Decaf = true; 
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Decaf = true;
            });

        }

        [Fact]
        public void ChangingSizeShouldNotifyDescriptionChange()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = Size.Medium;
            });
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Medium;
            });
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Medium;
            });

        }
    }
}
