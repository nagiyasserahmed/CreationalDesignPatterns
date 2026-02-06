public class McDonaldsFries : IFries
{
    public string GetSize() => "Medium";

    public void Cook()
    {
        Console.WriteLine("  🍟 Cutting potatoes into thin strips");
        Console.WriteLine("  🍟 Deep frying at 350°F for 3 minutes");
        Console.WriteLine("  🍟 Salting with McDonald's signature salt");
    }

    public decimal GetPrice() => 2.49m;
}