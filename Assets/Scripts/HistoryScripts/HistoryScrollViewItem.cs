using UnityEngine;
using UnityEngine.SceneManagement;

public class HistoryScrollViewItem : MonoBehaviour
{
    [SerializeField] private GameObject ParentGameObject;
    public int numberOfScrollViewElement;

    public void ShowNumber()
    {
        HistoryMealElementsManager.CreateElementsOfFood(numberOfScrollViewElement);
        SceneManager.LoadScene(7);
    }
}


