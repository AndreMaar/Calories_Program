using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollViewItem : MonoBehaviour
{
    public GameObject ParentGameObject;
    private FoodClass food;

    public void Start()
    {
        food = FoodSystem.foodElement;
        ParentGameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = food.GetName() + " | " + food.GetGrams() + "gr | " + food.GetTotalCalories() + "kkal";
    }
    public void Delete()
    {
        FoodSystem.newMeat.RemoveElementOfFood(food);
        Destroy(this.gameObject);
    }
}
