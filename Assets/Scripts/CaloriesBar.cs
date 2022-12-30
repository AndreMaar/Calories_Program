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
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = (float)RegistrationScript.newAccount.index;
        slider.value = (float)RegistrationScript.newAccount.Property;
    }

    // Update is called once per frame
    void Update()
    {
        RegistrationScript.newAccount.Property = x;
        slider.value = (float)RegistrationScript.newAccount.Property;
    }
}
