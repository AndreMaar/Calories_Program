using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GreetingScript : MonoBehaviour
{
    public GameObject greatingTextObject;

    void Update()
    {
        if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 12) 
        {
            greatingTextObject.GetComponent<Text>().text = "Good Morning";
        }
        else if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
        {
            greatingTextObject.GetComponent<Text>().text = "Good Afternoon";
        }
        else
        {
            greatingTextObject.GetComponent<Text>().text = "Good Evening";
        }
    }
}
