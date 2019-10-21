﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using System.Collections.ObjectModel;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void OrderShouldHaveCorrectSubtotal()
        {
            Order o = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(new Brontowurst());
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            items.Add(tea);
            o.Items = items;
            Assert.Equal<double>(7.35, o.SubTotalCost);
        }

        [Fact]
        public void DefultEverythingShouldBeZero()
        {
            Order o = new Order();
            Assert.Equal<double>(0, o.SubTotalCost);
            Assert.Equal<double>(0, o.SalesTaxCost);
            Assert.Equal<double>(0.2, o.SalesTaxRate);
            Assert.Equal<double>(0, o.TotalCost);
        }

        [Fact]
        public void ShouldHveCorrectItems()
        {
            Order o = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            DinoNuggets dino = new DinoNuggets();
            items.Add(dino);
            Fryceritops tea = new Fryceritops();
            CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
            combo.Drink = new JurassicJava();
            items.Add(combo);
            tea.Size = Size.Large;
            items.Add(tea);
            o.Items = items;
            Assert.Contains<IOrderItem>(dino, o.Items);
            Assert.Contains<IOrderItem>(tea, o.Items);
            Assert.Contains<IOrderItem>(combo, o.Items);
            Assert.Equal<int>(3, o.Items.Count);
        }

        [Fact]
        public void ShouldHaveCorrectCost()
        {
            Order o = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
            combo.Drink = new Sodasaurus();
            combo.Side = new MeteorMacAndCheese();
            combo.Size = Size.Large;
            items.Add(combo);
            o.Items = items;
            Assert.Equal<double>(10.72, o.SubTotalCost);
            Assert.Equal<double>(2.14, o.SalesTaxCost);
            Assert.Equal<double>(0.2, o.SalesTaxRate);
            Assert.Equal<double>(12.86, o.TotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectCostPart2()
        {
            Order o = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            combo.Drink = soda;
            combo.Side = new MeteorMacAndCheese();
            combo.Size = Size.Large;
            items.Add(combo);//12.65
            CretaceousCombo comba = new CretaceousCombo(new VelociWrap());
            items.Add(comba);//9.1
            MezzorellaSticks side = new MezzorellaSticks();
            side.Size = Size.Medium;
            items.Add(side);//1.45
            o.Items = items;
            Assert.Equal<double>(23.20, o.SubTotalCost);
            Assert.Equal<double>(4.63, o.SalesTaxCost);
            Assert.Equal<double>(0.2, o.SalesTaxRate);
            Assert.Equal<double>(27.83, o.TotalCost);
        }

        [Fact]
        public void NegitveTotalsAreNotNegitive()
        {
            Order o = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            TRexKingBurger rex = new TRexKingBurger();
            rex.Price = -50000;
            items.Add(rex);
            items.Add(new SteakosaurusBurger());
            o.Items = items;
            Assert.Equal<double>(0, o.SubTotalCost);
            Assert.Equal<double>(0, o.SalesTaxCost);
            Assert.Equal<double>(0.2, o.SalesTaxRate);
            Assert.Equal<double>(0, o.TotalCost);
        }

    }
}
