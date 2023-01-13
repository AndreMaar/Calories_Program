using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodSystem : MonoBehaviour
{
    public List<FoodClass> Food;
    static public FoodClass foodElement;
    [SerializeField] private InputField FoodInputField;
    [SerializeField] private GameObject FoodAddingPanel;
    [SerializeField] private GameObject FoodAddingPanelText;
    [SerializeField] private InputField GramsInputField;

    [SerializeField] private Transform scrollViewContent;
    public GameObject prefab;

    private string Input;
    private int grams;

    static public int CurrentScene;
    static private MeatClass breakfast;
    static private MeatClass lunch;
    static private MeatClass dinner;
    static public MeatClass[] meal = { breakfast, lunch, dinner};

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex - 2>=0 && SceneManager.GetActiveScene().buildIndex - 2 <= 2)
            CurrentScene = SceneManager.GetActiveScene().buildIndex - 2;
        if(meal[CurrentScene] == null)
        {
            meal[CurrentScene] = new MeatClass();
        }
        else
        {
            for(int i = 0; i < meal[CurrentScene].GetFoodList().Count;i++)
            {
                foodElement = meal[CurrentScene].GetFoodList()[i];
                
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
        FoodAddingPanelText.GetComponent<Text>().text = foodElement.GetName() + "\nis " + foodElement.GetCalories()*100 + " kcal in 100gr";
    }
    public void SetFoodGrams()
    {
        if (int.TryParse(GramsInputField.text, out grams))
        {
            foodElement.SetGrams(grams);

            meal[CurrentScene].AddElementOfFood(foodElement);

            GameObject prefabInstance = Instantiate(prefab, scrollViewContent) as GameObject;
            var myScriptReference = prefabInstance.GetComponent<ScrollViewItem>();
            myScriptReference.SetText(foodElement);

            GramsInputField.Select();
            GramsInputField.text = "";

            FoodAddingPanel.gameObject.SetActive(false);
        }
    }
}
