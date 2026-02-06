public class WendysFactory : IRestaurantFactory
{
    public string GetRestaurantName() => "Wendy's";
    public IBurger CreateBurger() => new DaveSingle();
    public IFries CreateFries() => new WendysFries();
    public IDrink CreateDrink() => new Frosty();
    public IToy CreateKidsToy() => new WendysToy();
}