public class WendysToy : IToy
{
    public string GetToyName() => "Wendy's SpongeBob Toy";

    public void Package()
    {
        Console.WriteLine("  🎁 Placing toy in protective bag");
        Console.WriteLine("  🎁 Adding to Kids Meal");
    }
}