public class BKKingJrToy : IToy
{
    public string GetToyName() => "Burger King Crown";

    public void Package()
    {
        Console.WriteLine("  🎁 Folding paper crown");
        Console.WriteLine("  🎁 Adding to Kids Meal bag");
    }
}