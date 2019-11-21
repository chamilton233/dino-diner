using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public List<Entree> entrees = new List<Entree>();
        public List<Side> sides= new List<Side>();
        public List<Drink> drinks= new List<Drink>();
        public List<CretaceousCombo> combos= new List<CretaceousCombo>();

        public void OnGet()
        {
            entrees.Add(new Brontowurst());
            entrees.Add(new DinoNuggets());
            entrees.Add(new PrehistoricPBJ());
            entrees.Add(new PterodactylWings());
            entrees.Add(new SteakosaurusBurger());
            entrees.Add(new TRexKingBurger());
            entrees.Add(new VelociWrap());
            sides.Add(new Triceritots());
            sides.Add(new MeteorMacAndCheese());
            sides.Add(new Fryceritops());
            sides.Add(new MezzorellaSticks());
            drinks.Add(new JurassicJava());
            drinks.Add(new Sodasaurus());
            drinks.Add(new Tyrannotea());
            drinks.Add(new Water());
            foreach (Entree e in entrees)
            {
                combos.Add(new CretaceousCombo(e));
            }
        }


    }
}