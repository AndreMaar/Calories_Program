using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class CaloriesBar : MonoBehaviour
{
    public Slider slider;
    public int x;
    private int max = (int)RegistrationScript.newAccount.index;

    public GameObject neededCaloriesTextObject;
    public GameObject currentCaloriesTextObject;

    static public MeatClass newMeat;

    void Start()
    {
        slider.maxValue = (float)RegistrationScript.newAccount.index;
        slider.value = (float)RegistrationScript.newAccount.Property;

        
        neededCaloriesTextObject.GetComponent<Text>().text = max.ToString();

        if (FoodSystem.newMeat != null)
        {
            newMeat = FoodSystem.newMeat;
            RegistrationScript.newAccount.Property = newMeat.GetTotalKcalOfMeat();
            currentCaloriesTextObject.GetComponent<Text>().text = RegistrationScript.newAccount.Property.ToString();
            slider.value = RegistrationScript.newAccount.Property;

        }
    }

    void Update()
    {
        //RegistrationScript.newAccount.Property = x;
        //slider.value = (float)RegistrationScript.newAccount.Property;

    }
}
