using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class CaloriesBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private int max = (int)RegistrationScript.newAccount.index;

    [SerializeField] private GameObject neededCaloriesTextObject;
    [SerializeField] private GameObject currentCaloriesTextObject;

    static public MeatClass newMeat;
    private int allKcalOfMeats;


    void Start()
    {
        allKcalOfMeats = 0;
        slider.maxValue = max;
        
        neededCaloriesTextObject.GetComponent<Text>().text = max.ToString();

        for(int i = 0; i < 3; i++)
        {
            if (FoodSystem.meal[i] != null)
            {
                allKcalOfMeats += FoodSystem.meal[i].GetTotalKcalOfMeat();
            }
        }
        
        RegistrationScript.newAccount.Property = allKcalOfMeats;
        currentCaloriesTextObject.GetComponent<Text>().text = RegistrationScript.newAccount.Property.ToString();

        if (allKcalOfMeats > max)
            slider.value = max;
        else
            slider.value = RegistrationScript.newAccount.Property;

    }
}
