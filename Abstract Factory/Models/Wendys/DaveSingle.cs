public class DaveSingle : IBurger
{
    public string GetName() => "Dave's Single";

    public void Prepare()
    {
        Console.WriteLine("  🍔 Cooking fresh, never frozen beef patty");
        Console.WriteLine("  🍔 Adding cheese, lettuce, tomato, pickles");
        Console.WriteLine("  🍔 Using premium bun");
    }

    public decimal GetPrice() => 5.79m;
}
