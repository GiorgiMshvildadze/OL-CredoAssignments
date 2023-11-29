using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilder
{
    public class PresetBurger
    {
        public static void ChoosePresetBurger(string? choosePreset)
        {
            switch (choosePreset)
            {
                case "1":
                    Console.WriteLine("Cheeseburger Contains:");
                    Burger Cheeseburger = new Burger();
                    string[] cheeseburger = Cheeseburger.BuildCheeseBurger();
                    foreach (var ingredient in cheeseburger)
                    {
                        Console.WriteLine(ingredient);
                    }
                    break;
                case "2":
                    Console.WriteLine("Hamburger Contains:");
                    Burger hamBurger = new Burger();
                    string[] hamburger = hamBurger.BuildHamburger();
                    foreach (var ingredient in hamburger)
                    {
                        Console.WriteLine(ingredient);
                    }
                    break;
                case "3":
                    Console.WriteLine("Special Burger Contains:");
                    Burger SpecialBurger = new Burger();
                    string[] specialBurger = SpecialBurger.BuildSpecialBurger();
                    foreach (var ingredient in specialBurger)
                    {
                        Console.WriteLine(ingredient);
                    }
                    break;
            }
        }
    }
}
