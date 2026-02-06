public class BurgerKingFries : IFries
{
    public string GetSize() => "Medium";

    public void Cook()
    {
        Console.WriteLine("  🍟 Using thick-cut potatoes");
        Console.WriteLine("  🍟 Deep frying at 375°F for 4 minutes");
        Console.WriteLine("  🍟 Seasoning with sea salt");
    }

    public decimal GetPrice() => 2.79m;
}