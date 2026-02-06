public class BurgerKingFactory : IRestaurantFactory
{
    public string GetRestaurantName() => "Burger King";
    public IBurger CreateBurger() => new Whopper();
    public IFries CreateFries() => new BurgerKingFries();
    public IDrink CreateDrink() => new Pepsi();
    public IToy CreateKidsToy() => new BKKingJrToy();
}