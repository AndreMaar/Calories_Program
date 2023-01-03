using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSystem : MonoBehaviour
{
    public static List<FoodClass> foods = AllFood.foods;
    public GameObject FoodInputField;

    private string Input;

    public void SearchFood()
    {
        Input = FoodInputField.GetComponent<Text>().text;
        foreach (FoodClass food in foods)
        {
            if (food.name == Input)
            {
                Debug.Log("Find" + food.name);
            }
        }
        Debug.Log("ok" + Input);
    }
}
