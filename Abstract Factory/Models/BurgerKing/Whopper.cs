public class Whopper : IBurger
{
    public string GetName() => "Whopper";

    public void Prepare()
    {
        Console.WriteLine("  🍔 Flame-grilling quarter pound beef patty");
        Console.WriteLine("  🍔 Adding tomatoes, lettuce, mayo, ketchup");
        Console.WriteLine("  🍔 Placing in toasted bun");
    }

    public decimal GetPrice() => 6.49m;
}