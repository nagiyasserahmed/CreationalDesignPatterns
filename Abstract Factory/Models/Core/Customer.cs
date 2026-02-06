public class Customer
{
    public string Name { get; set; }
    public decimal Budget { get; set; }

    public Customer(string name, decimal budget)
    {
        Name = name;
        Budget = budget;
    }

    public void PlaceOrder(IRestaurantFactory restaurant, bool isKidsMeal = false)
    {
        Console.WriteLine($"\n{'=',-50}");
        Console.WriteLine($"👤 Customer: {Name}");
        Console.WriteLine($"💵 Budget: ${Budget:F2}");
        Console.WriteLine($"🏪 Ordering from: {restaurant.GetRestaurantName()}");
        Console.WriteLine($"{'=',-50}");

        ComboMeal meal = new ComboMeal(restaurant, isKidsMeal);
        meal.DisplayOrder();

        if (meal.GetTotalPrice() <= Budget)
        {
            Console.WriteLine($"✅ {Name} can afford this meal!");
            Console.WriteLine($"💳 Paying ${meal.GetTotalPrice():F2}");
            Console.WriteLine($"💰 Remaining budget: ${Budget - meal.GetTotalPrice():F2}");

            // Chef prepares the meal
            Chef chef = new Chef("Gordon", restaurant.GetRestaurantName());
            chef.PrepareComboMeal(meal, restaurant, isKidsMeal);

            Console.WriteLine($"🎉 {Name} enjoys their {restaurant.GetRestaurantName()} combo meal!\n");
        }
        else
        {
            Console.WriteLine($"❌ Sorry {Name}, this meal costs ${meal.GetTotalPrice():F2}");
            Console.WriteLine($"   You only have ${Budget:F2}. Need ${meal.GetTotalPrice() - Budget:F2} more.");
        }
    }
}