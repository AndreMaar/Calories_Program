using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSystem : MonoBehaviour
{
    public List<FoodClass> Food;
    static public FoodClass foodElement;
    public InputField FoodInputField;
    public GameObject FoodAddingPanel;
    public GameObject FoodAddingPanelText;
    public InputField GramsInputField;

    public Transform scrollViewContent;
    public GameObject prefab;

    private string Input;
    private bool CanGoNext;
    private int grams;

    static public MeatClass newMeat;

    private void Start()
    {

        if(newMeat == null)
        {
            newMeat = new MeatClass();
        }
        else
        {
            for(int i = 0; i < newMeat.GetFoodList().Count;i++)
            {
                foodElement = newMeat.GetFoodList()[i];
                Debug.Log(foodElement.GetName() + i);
                
                GameObject prefabInstance = Instantiate(prefab, scrollViewContent) as GameObject;
                var myScriptReference = prefabInstance.GetComponent<ScrollViewItem>();
                myScriptReference.SetText(foodElement);
            }
            
        }
    }
    public void SearchFood()
    {
        Food = new List<FoodClass>(AllFood.foods);
        Input = FoodInputField.text;
        foreach (FoodClass food in Food)
        {
            if (food.GetName() == Input)
            {
                foodElement = food;
                
                ShowAddingPanel();             
            }
        }
        FoodInputField.Select();
        FoodInputField.text = "";
    }

    public void ShowAddingPanel()
    {
        FoodAddingPanel.gameObject.SetActive(true);
        FoodAddingPanelText.GetComponent<Text>().text = foodElement.GetName() + "\nis " + foodElement.GetCalories()*100 + " kkal in 100gr";
    }
    public void SetFoodGrams()
    {
        //Має буть перевірка на правильність вводу грамів страви
        CanGoNext = int.TryParse(GramsInputField.text, out grams);
        foodElement.SetGrams(grams);

        newMeat.AddElementOfFood(foodElement);

        GameObject prefabInstance = Instantiate(prefab, scrollViewContent) as GameObject;
        var myScriptReference = prefabInstance.GetComponent<ScrollViewItem>();
        myScriptReference.SetText(foodElement);

        GramsInputField.Select();
        GramsInputField.text = "";

        FoodAddingPanel.gameObject.SetActive(false);
    }

}
