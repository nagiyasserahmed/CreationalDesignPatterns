public class Pepsi : IDrink
{
    public string GetName() => "Pepsi";

    public void Pour()
    {
        Console.WriteLine("  🥤 Filling cup with crushed ice");
        Console.WriteLine("  🥤 Pouring Pepsi from dispenser");
        Console.WriteLine("  🥤 Adding straw and lid");
    }

    public decimal GetPrice() => 1.99m;
}