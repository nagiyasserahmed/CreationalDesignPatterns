internal sealed class AbstractFactoryUsageExample
{
    public static void Run()
    {
        IRestaurantFactory factory = new BurgerKingFactory();

        var burger = factory.CreateBurger();
        var fries = factory.CreateFries();
        var drink = factory.CreateDrink();
        var toy = factory.CreateKidsToy();
        Console.WriteLine($"Welcome to {factory.GetRestaurantName()}!");
        Console.WriteLine($"You have ordered a {burger.GetName()} with {fries.GetSize()} fries, a {drink.GetName()}, and a {toy.GetToyName()} toy.");

        factory = new McDonaldsFactory();
        burger = factory.CreateBurger();
        fries = factory.CreateFries();
        drink = factory.CreateDrink();
        toy = factory.CreateKidsToy();
        Console.WriteLine($"\nWelcome to {factory.GetRestaurantName()}!");
        Console.WriteLine($"You have ordered a {burger.GetName()} with {fries.GetSize()} fries, a {drink.GetName()}, and a {toy.GetToyName()} toy.");


        factory = new WendysFactory();
        burger = factory.CreateBurger();
        fries = factory.CreateFries();
        drink = factory.CreateDrink();
        toy = factory.CreateKidsToy();
        Console.WriteLine($"\nWelcome to {factory.GetRestaurantName()}!");
        Console.WriteLine($"You have ordered a {burger.GetName()} with {fries.GetSize()} fries, a {drink.GetName()}, and a {toy.GetToyName()} toy.");
    }
}