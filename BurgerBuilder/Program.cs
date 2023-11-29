using System;
using System.Security.Cryptography.X509Certificates;

namespace BurgerBuilder;


public class Burger
{

    public string Bun { get; set; } = "Bum";
    public string Cheese { get; set; }
    public string lettuce { get; set; } = "Lettuce";
    public string pickle { get; set; }
    public string meat { get; set; }
    public string sauce { get; set; }

    public string[] BuildCheeseBurger()
    {
        Burger Cheeseburger = new Burger();
        Cheeseburger.Bun = "Bun";
        Cheeseburger.Cheese = "Cream Cheese";
        Cheeseburger.lettuce = "Lettuce";
        Cheeseburger.pickle = "Pickle";
        Cheeseburger.meat = "Beef";
        Cheeseburger.sauce = "Hot Sauce";
        string[] cheeseburger = { Cheeseburger.Bun, Cheeseburger.Cheese, Cheeseburger.lettuce, Cheeseburger.pickle, Cheeseburger.meat, Cheeseburger.sauce };

        return cheeseburger;
    }

    public string[] BuildHamburger()
    {
        Burger Hamburger = new Burger();
        Hamburger.Bun = "Bun";
        Hamburger.lettuce = "Lettuce";
        Hamburger.pickle = "Pickle";
        Hamburger.meat = "Beef";
        Hamburger.sauce = "Sweet Sauce";
        string[] hamburger = { Hamburger.Bun, Hamburger.lettuce, Hamburger.pickle, Hamburger.meat, Hamburger.sauce };

        return hamburger;

    }
    public string[] BuildSpecialBurger()
    {
        Burger SpecialBurger = new Burger();
        SpecialBurger.Bun = "Bun";
        SpecialBurger.Cheese = "Cream Cheese";
        SpecialBurger.lettuce = "Lettuce";
        SpecialBurger.pickle = "Pickle";
        SpecialBurger.meat = "Chicken";
        SpecialBurger.sauce = "Special Sauce";
        string[] specialBurger = { SpecialBurger.Bun, SpecialBurger.Cheese, SpecialBurger.lettuce, SpecialBurger.pickle, SpecialBurger.meat, SpecialBurger.sauce };

        return specialBurger;

    }

}



class Program
{
    public static void ChooseMenu()
    {
        Console.WriteLine("Which Menu do you want:\n 1. Presets for Burgers \n 2.Make your own burger ");
        string? chooseMenu = Console.ReadLine();
        switch (chooseMenu)
        {
            case "1":
                ShowPresetOptions();
                break;
            case "2":
                MakeYourOwnBurger();
                break;
        }
    }

    public static void ShowPresetOptions()
    {
        Console.WriteLine("Preset Burgers: \n 1.Cheeseburger \n 2.Hamburger \n 3.Special");
        string? choosePreset = Console.ReadLine();
        PresetBurger.ChoosePresetBurger(choosePreset);
    }


    public static void MakeYourOwnBurger()
    {
        ChooseCheese();
    }

    public static void ChooseCheese()
    {
        Console.WriteLine("Do you want cheese? \n 1.Yes \n2.No");
        string? wantCheese = Console.ReadLine();
        Burger CustomBurger = new Burger();

        switch (wantCheese)
        {

            case "1":
                CustomBurger.Cheese = "Cream Cheese";
                break;
            case "2":
                CustomBurger.Cheese = "No Cheese";
                break;
        }
        ChoosePickle(CustomBurger);
    }

    public static void ChoosePickle(Burger customBurger)
    {
        Console.WriteLine("Do you want pickle? \n 1.Yes \n 2.No");
        string? wantPickle = Console.ReadLine();

        switch (wantPickle)
        {

            case "1":
                customBurger.pickle = "Pickle";
                break;
            case "2":
                customBurger.pickle = "No Pickle";
                break;
        }
        ChooseMeat(customBurger);
    }

    public static void ChooseMeat(Burger customBurger)
    {
        Console.WriteLine("Which meat do you want? \n 1.Chicken \n 2.Beef");
        string? whichMeat = Console.ReadLine();

        switch (whichMeat)
        {
            case "1":
                customBurger.meat = "Chicken";
                break;
            case "2":
                customBurger.meat = "Beef";
                break;

        }
        ChooseSauce(customBurger);
    }

    public static void ChooseSauce(Burger customBurger)
    {
        Console.WriteLine("Which sauce do you want? \n 1.Hot Sauce \n 2.Sweet Sauce \n 3.Special Sauce");
        string? whichSauce = Console.ReadLine();


        switch (whichSauce)
        {
            case "1":
                customBurger.sauce = "Hot sauce";
                break;
            case "2":
                customBurger.sauce = "Sweet sauce";
                break;
            case "3":
                customBurger.sauce = "Special Sauce";
                break;
        }

        OutputCustomBurger(customBurger);
    }

    public static void OutputCustomBurger(Burger customBurger)
    {
        Console.WriteLine("Your custom burger contains:");

        Console.WriteLine(customBurger.meat);
        Console.WriteLine(customBurger.pickle);
        Console.WriteLine(customBurger.Bun);
        Console.WriteLine(customBurger.Cheese);
        Console.WriteLine(customBurger.lettuce);
        Console.WriteLine(customBurger.sauce);
        Console.ReadLine();
    }
    static void Main(string[] args)
    {
        ChooseMenu();
    }
}