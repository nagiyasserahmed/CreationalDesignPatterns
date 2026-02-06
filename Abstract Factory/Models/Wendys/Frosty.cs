public class Frosty : IDrink
{
    public string GetName() => "Chocolate Frosty";

    public void Pour()
    {
        Console.WriteLine("  🥤 Dispensing signature Frosty from machine");
        Console.WriteLine("  🥤 It's a cross between a shake and soft serve!");
        Console.WriteLine("  🥤 Adding spoon-straw");
    }

    public decimal GetPrice() => 2.49m;
}
