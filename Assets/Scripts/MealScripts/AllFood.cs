using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.IO;
using UnityEngine.SceneManagement;


public class AllFood : MonoBehaviour
{
    public static List<FoodClass> foods;
    static string textDocumentName = Application.streamingAssetsPath + "/AccountLogs/" + "Food" + ".txt";
    public static void CreateList()
    {
        foods = new List<FoodClass>();
        var lines = File.ReadAllLines(textDocumentName);

        for (int i = 0; i < lines.Length; i++) {
            string[] words = lines[i].Split(' ');
            foods.Add(new FoodClass(words[0],float.Parse(words[1])));
        }
    }
}

public class FoodClass
{

    public FoodClass(string name, float calories)
    {
        this.name = name;
        caloriesIn100Grams = calories;
    }

    private string name;
    private int grams;
    private float caloriesIn100Grams;
    private float totalCalories;

    public void SetGrams(int grams)
    {
        this.grams = grams;
        totalCalories = (caloriesIn100Grams * this.grams);
    }

    public string GetName()
    {
        return name;
    }
    public float GetCalories()
    {
        return caloriesIn100Grams;
    }
    public int GetGrams()
    {
        return grams;
    }
    public float GetTotalCalories()
    {
        return totalCalories;
    }
}

