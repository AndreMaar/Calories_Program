using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSystem : MonoBehaviour
{
    public static List<FoodClass> Food;
    public GameObject FoodInputField;

    private string Input;

    public void SearchFood()
    {
        Food = new List<FoodClass>(AllFood.foods);
        Input = FoodInputField.GetComponent<Text>().text;
        foreach (FoodClass food in Food)
        {
            if (food.name == Input)
            {
                Debug.Log("Find" + food.name);
            }
        }
        Debug.Log("ok" + Input);
    }
}
