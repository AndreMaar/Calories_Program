using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class CaloriesBar : MonoBehaviour
{
    public Slider slider;
    private int max = (int)RegistrationScript.newAccount.index;

    public GameObject neededCaloriesTextObject;
    public GameObject currentCaloriesTextObject;

    static public MeatClass newMeat;
    private int allKcalOfMeats;


    void Start()
    {
        allKcalOfMeats = 0;
        slider.maxValue = (float)RegistrationScript.newAccount.index;
        
        neededCaloriesTextObject.GetComponent<Text>().text = max.ToString();

        for(int i = 0; i < 3; i++)
        {
            if (FoodSystem.meat[i] != null)
            {
                allKcalOfMeats += FoodSystem.meat[i].GetTotalKcalOfMeat();
            }
        }
        RegistrationScript.newAccount.Property = allKcalOfMeats;
        currentCaloriesTextObject.GetComponent<Text>().text = RegistrationScript.newAccount.Property.ToString();
        slider.value = RegistrationScript.newAccount.Property;

    }
}
