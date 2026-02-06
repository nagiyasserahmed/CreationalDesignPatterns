public interface IRestaurantFactory
{
    string GetRestaurantName();
    IBurger CreateBurger();
    IFries CreateFries();
    IDrink CreateDrink();
    IToy CreateKidsToy();
}