public class CocaCola : IDrink
{
    public string GetName() => "Coca-Cola";

    public void Pour()
    {
        Console.WriteLine("  🥤 Filling cup with ice");
        Console.WriteLine("  🥤 Pouring Coca-Cola from fountain");
        Console.WriteLine("  🥤 Adding straw and lid");
    }

    public decimal GetPrice() => 1.99m;
}