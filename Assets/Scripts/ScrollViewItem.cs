using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollViewItem : MonoBehaviour
{
    [SerializeField] private GameObject ParentGameObject;
    private FoodClass scrollViewItemFood;

    public void Delete()
    {
        FoodSystem.meal[FoodSystem.CurrentScene].RemoveElementOfFood(scrollViewItemFood);
        Destroy(this.gameObject);
    }

    public void SetText(FoodClass foodElement)
    {
        scrollViewItemFood = foodElement;
        ParentGameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = scrollViewItemFood.GetName() + " | " + scrollViewItemFood.GetGrams() + "gr | " + scrollViewItemFood.GetTotalCalories() + "kcal";
    }
}
