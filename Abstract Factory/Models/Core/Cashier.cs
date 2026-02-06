public class Cashier
{
    private string _name;
    private IRestaurantFactory _restaurant;

    public Cashier(string name, IRestaurantFactory restaurant)
    {
        _name = name;
        _restaurant = restaurant;
    }

    public void TakeOrder(Customer customer, bool isKidsMeal = false)
    {
        Console.WriteLine($"\n💁 Cashier {_name}: 'Welcome to {_restaurant.GetRestaurantName()}! How can I help you?'");
        Console.WriteLine($"👤 {customer.Name}: 'I'd like a {(isKidsMeal ? "Kids" : "Combo")} meal please.'");
        Console.WriteLine($"💁 Cashier {_name}: 'Great choice! Let me prepare that for you.'\n");

        customer.PlaceOrder(_restaurant, isKidsMeal);
    }
}