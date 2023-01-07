using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatClass
{
    private List<FoodClass> FoodOfMeal = new List<FoodClass>();

    public void AddElementOfFood(FoodClass food)
    {
        FoodOfMeal.Add(food);
    }
    public void RemoveElementOfFood(FoodClass removebleFood)
    {
        FoodOfMeal.Remove(removebleFood);
    }
    public List<FoodClass> GetFoodList()
    {
        return FoodOfMeal;
    }
    public int GetTotalKcalOfMeat()
    {
        int TotalKcalOfMeat = 0;
        for (int i = 0; i < FoodOfMeal.Count; i++)
        {
            TotalKcalOfMeat += (int)FoodOfMeal[i].GetTotalCalories();
        }
        return TotalKcalOfMeat;
    }
}
