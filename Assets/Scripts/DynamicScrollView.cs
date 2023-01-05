using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicScrollView : MonoBehaviour
{
    [SerializeField]
    private Transform scrollViewContent;

    [SerializeField]
    private GameObject prefab;
    private int amount = 10;

    private void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(prefab, scrollViewContent);
        }
    }

}
