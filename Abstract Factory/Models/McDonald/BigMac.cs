public class BigMac : IBurger
{
    public string GetName() => "Big Mac";

    public void Prepare()
    {
        Console.WriteLine("  🍔 Grilling two beef patties");
        Console.WriteLine("  🍔 Adding special sauce, lettuce, cheese");
        Console.WriteLine("  🍔 Placing in sesame seed bun");
    }

    public decimal GetPrice() => 5.99m;
}