public class WendysFries : IFries
{
    public string GetSize() => "Medium";

    public void Cook()
    {
        Console.WriteLine("  🍟 Using natural-cut fries with skin on");
        Console.WriteLine("  🍟 Frying in high-quality oil");
        Console.WriteLine("  🍟 Seasoning with sea salt");
    }

    public decimal GetPrice() => 2.29m;
}