using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GreetingScript : MonoBehaviour
{
    [SerializeField] private GameObject greatingTextObject;

    void Update()
    {
        if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 12) 
        {
            greatingTextObject.GetComponent<Text>().text = "Good Morning, " + RegistrationScript.newAccount.GetSetName;
        }
        else if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
        {
            greatingTextObject.GetComponent<Text>().text = "Good Afternoon, " + RegistrationScript.newAccount.GetSetName;
        }
        else
        {
            greatingTextObject.GetComponent<Text>().text = "Good Evening, " + RegistrationScript.newAccount.GetSetName;
        }
    }
}
