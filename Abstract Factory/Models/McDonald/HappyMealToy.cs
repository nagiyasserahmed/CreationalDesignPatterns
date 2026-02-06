public class HappyMealToy : IToy
{
    public string GetToyName() => "McDonald's Minion Figure";

    public void Package()
    {
        Console.WriteLine("  🎁 Wrapping toy in plastic wrapper");
        Console.WriteLine("  🎁 Adding to Happy Meal box");
    }
}