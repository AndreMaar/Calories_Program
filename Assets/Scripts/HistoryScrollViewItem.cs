using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;
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


