public class ComboMeal
{
    private string _restaurantName;
    private IBurger _burger;
    private IFries _fries;
    private IDrink _drink;
    private IToy _toy;

    public ComboMeal(IRestaurantFactory restaurant, bool isKidsMeal = false)
    {
        _restaurantName = restaurant.GetRestaurantName();
        _burger = restaurant.CreateBurger();
        _fries = restaurant.CreateFries();
        _drink = restaurant.CreateDrink();

        if (isKidsMeal)
        {
            _toy = restaurant.CreateKidsToy();
        }
    }

    public decimal GetTotalPrice()
    {
        decimal total = _burger.GetPrice() + _fries.GetPrice() + _drink.GetPrice();
        if (_toy != null)
        {
            total += 1.00m;
        }
        return total;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"\n📋 ORDER SUMMARY - {_restaurantName}");
        Console.WriteLine("================================");
        Console.WriteLine($"🍔 Burger: {_burger.GetName()} - ${_burger.GetPrice()}");
        Console.WriteLine($"🍟 Fries: {_fries.GetSize()} - ${_fries.GetPrice()}");
        Console.WriteLine($"🥤 Drink: {_drink.GetName()} - ${_drink.GetPrice()}");

        if (_toy != null)
        {
            Console.WriteLine($"🎁 Toy: {_toy.GetToyName()} - $1.00");
        }

        Console.WriteLine($"💰 TOTAL: ${GetTotalPrice():F2}");
        Console.WriteLine("================================\n");
    }
}