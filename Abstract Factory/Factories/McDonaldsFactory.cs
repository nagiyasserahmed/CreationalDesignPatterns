public class McDonaldsFactory : IRestaurantFactory
{
    public string GetRestaurantName() => "McDonald's";
    public IBurger CreateBurger() => new BigMac();
    public IFries CreateFries() => new McDonaldsFries();
    public IDrink CreateDrink() => new CocaCola();
    public IToy CreateKidsToy() => new HappyMealToy();
}