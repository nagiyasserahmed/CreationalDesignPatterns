public class Chef
{
    private string _name;
    private string _restaurant;

    public Chef(string name, string restaurant)
    {
        _name = name;
        _restaurant = restaurant;
    }

    public void PrepareComboMeal(ComboMeal meal, IRestaurantFactory restaurant, bool isKidsMeal)
    {
        Console.WriteLine($"\n👨‍🍳 Chef {_name} at {_restaurant} is preparing your order...\n");

        var burger = restaurant.CreateBurger();
        Console.WriteLine($"Making {burger.GetName()}:");
        burger.Prepare();

        var fries = restaurant.CreateFries();
        Console.WriteLine($"\nMaking {fries.GetSize()} Fries:");
        fries.Cook();

        var drink = restaurant.CreateDrink();
        Console.WriteLine($"\nPreparing {drink.GetName()}:");
        drink.Pour();

        if (isKidsMeal)
        {
            var toy = restaurant.CreateKidsToy();
            Console.WriteLine($"\nAdding {toy.GetToyName()}:");
            toy.Package();
        }

        Console.WriteLine($"\n✅ Chef {_name} has finished preparing your meal!\n");
    }
}