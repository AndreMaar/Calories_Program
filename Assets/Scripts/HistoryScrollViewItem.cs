using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class HistoryScrollViewItem : MonoBehaviour
{
    [SerializeField] private GameObject ParentGameObject;



    public void SetText(DateTime date)
    {
        ParentGameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "";
    }
}
