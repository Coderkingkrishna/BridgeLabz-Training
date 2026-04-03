
// Vegetarian meal implementation
class VegetarianMeal : IMealPlan
{
    public string GetMealType()
    {
        return "Vegetarian";
    }

    public int GetCalories()
    {
        return 1800;
    }
}
