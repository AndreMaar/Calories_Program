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
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = (float)RegistrationScript.newAccount.index;
        slider.value = (float)RegistrationScript.newAccount.Property;

        currentCaloriesTextObject.GetComponent<Text>().text = x.ToString();
        neededCaloriesTextObject.GetComponent<Text>().text = max.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        RegistrationScript.newAccount.Property = x;
        slider.value = (float)RegistrationScript.newAccount.Property;

        //Потім перенести заповнення полоски в Start()
    }
}
