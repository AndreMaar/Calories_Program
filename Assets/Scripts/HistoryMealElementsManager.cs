using UnityEngine;
using UnityEngine.UI;

public class HistoryMealElementsManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform breakfastScrollViewContent;
    [SerializeField] private Transform lunchScrollViewContent;
    [SerializeField] private Transform dinnerScrollViewContent;
    static int numberOfMeal = 0;

    public static void CreateElementsOfFood(int number)
    {
        numberOfMeal = number;
    }
    private void Start()
    {
        if (HistoryManager.historyMeal[numberOfMeal].breakfast != null)
        {
            for (int i = 0; i < HistoryManager.historyMeal[numberOfMeal].breakfast.Count; i++)
            {
                GameObject prefabInstance = Instantiate(prefab, breakfastScrollViewContent);
                prefabInstance.transform.GetChild(0).gameObject.GetComponent<Text>().text = HistoryManager.historyMeal[numberOfMeal].breakfast[0];
            }
        }
        if (HistoryManager.historyMeal[numberOfMeal].lunch != null)
        {
            for (int i = 0; i < HistoryManager.historyMeal[numberOfMeal].lunch.Count; i++)
            {
                GameObject prefabInstance = Instantiate(prefab, lunchScrollViewContent);
                prefabInstance.transform.GetChild(0).gameObject.GetComponent<Text>().text = HistoryManager.historyMeal[numberOfMeal].lunch[0];
            }
        }
        if (HistoryManager.historyMeal[numberOfMeal].dinner != null)
        {
            for (int i = 0; i < HistoryManager.historyMeal[numberOfMeal].dinner.Count; i++)
            {
                GameObject prefabInstance = Instantiate(prefab, dinnerScrollViewContent);
                prefabInstance.transform.GetChild(0).gameObject.GetComponent<Text>().text = HistoryManager.historyMeal[numberOfMeal].dinner[0];
            }
        }
    }
}
