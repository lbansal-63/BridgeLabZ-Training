using System;
using System.Collections.Generic;

// =====================================
// Meal Interface
// =====================================

public interface IMealPlan
{
    string GetMealName();

    int GetCalories();
}


// =====================================
// Vegetarian Meal
// =====================================

public class VegetarianMeal : IMealPlan
{
    public string GetMealName()
    {
        return "Paneer Rice";
    }

    public int GetCalories()
    {
        return 500;
    }
}


// =====================================
// Vegan Meal
// =====================================

public class VeganMeal : IMealPlan
{
    public string GetMealName()
    {
        return "Vegan Salad";
    }

    public int GetCalories()
    {
        return 300;
    }
}


// =====================================
// Keto Meal
// =====================================

public class KetoMeal : IMealPlan
{
    public string GetMealName()
    {
        return "Egg and Avocado";
    }

    public int GetCalories()
    {
        return 450;
    }
}


// =====================================
// Generic Meal Class
// =====================================

public class Meal<T>
    where T : IMealPlan
{
    private T mealPlan;

    public Meal(T mealPlan)
    {
        this.mealPlan = mealPlan;
    }

    public void Generate()
    {
        Console.WriteLine(
            $"Meal: {mealPlan.GetMealName()}");

        Console.WriteLine(
            $"Calories: {mealPlan.GetCalories()}");
    }
}


// =====================================
// Meal Plan Generator
// =====================================

public class MealPlanGenerator
{
    // Generic Method
    public void ValidateAndGenerate<T>(
        T meal)
        where T : IMealPlan
    {
        if (meal.GetCalories() <= 0)
        {
            Console.WriteLine(
                "Invalid meal.");
            return;
        }

        Console.WriteLine(
            "Meal is valid.");

        Console.WriteLine(
            $"Meal: {meal.GetMealName()}");

        Console.WriteLine(
            $"Calories: {meal.GetCalories()}");
    }
}


// =====================================
// Program
// =====================================

public class Program
{
    public static void Main()
    {
        VegetarianMeal vegetarian =
            new VegetarianMeal();

        VeganMeal vegan =
            new VeganMeal();

        KetoMeal keto =
            new KetoMeal();


        Meal<VegetarianMeal> vegetarianPlan =
            new Meal<VegetarianMeal>(
                vegetarian);

        Meal<VeganMeal> veganPlan =
            new Meal<VeganMeal>(
                vegan);

        Meal<KetoMeal> ketoPlan =
            new Meal<KetoMeal>(
                keto);


        Console.WriteLine(
            "Vegetarian Plan:");

        vegetarianPlan.Generate();


        Console.WriteLine(
            "\nVegan Plan:");

        veganPlan.Generate();


        Console.WriteLine(
            "\nKeto Plan:");

        ketoPlan.Generate();


        // Generic Method

        MealPlanGenerator generator =
            new MealPlanGenerator();

        Console.WriteLine(
            "\nValidation:");

        generator.ValidateAndGenerate(
            vegetarian);

        generator.ValidateAndGenerate(
            vegan);

        generator.ValidateAndGenerate(
            keto);
    }
}