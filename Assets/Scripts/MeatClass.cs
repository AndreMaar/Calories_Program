using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatClass
{
    public static List<FoodClass> FoodOfMeal = new List<FoodClass>();

    public void AddElementOfFood(FoodClass food)
    {
        FoodOfMeal.Add(food);
        for(int i = 0; i < FoodOfMeal.Count; i++)
        {
            //Debug.Log(i);
        }
        //Debug.Log(FoodOfMeal[0].GetName()+" Calories="+ FoodOfMeal[0].GetCalories() + " Grams=" + FoodOfMeal[0].GetGrams() + " TotalCalories=" + FoodOfMeal[0].GetTotalCalories());
    }
    public void RemoveElementOfFood(FoodClass removebleFood)
    {
        FoodOfMeal.Remove(removebleFood);
    }
}
