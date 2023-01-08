using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class AccountSetting : MonoBehaviour
{
    [SerializeField] private Dropdown sexDropdown;
    [SerializeField] private Dropdown activityDropdown;
    [SerializeField] private InputField nameText;
    [SerializeField] private InputField veightText;
    [SerializeField] private InputField heightText;
    [SerializeField] private InputField dateText;

    private AccountClass AccountObject =  RegistrationScript.newAccount;

    private string _nameInput = "";
    private DateTime _dateInput = new DateTime(0001, 01, 01);
    private int _hightInput = 0;
    private int _veightInput = 0;

    private void Start()
    {
        nameText.GetComponent<InputField>().text = AccountObject.GetSetName;
        veightText.GetComponent<InputField>().text = AccountObject.GetSetVeight.ToString();
        heightText.GetComponent<InputField>().text = AccountObject.GetSetHeight.ToString();
        dateText.GetComponent<InputField>().text = AccountObject.GetSetDate.Month.ToString() +"." + AccountObject.GetSetDate.Day.ToString() + "."+ AccountObject.GetSetDate.Year.ToString();

        if (AccountObject.GetSex().ToString() == "Men")
        {
            sexDropdown.value = 0;
        }
        else if (AccountObject.GetSex().ToString() == "Women")
        {
            sexDropdown.value = 1;
        }

        switch (AccountObject.GetActivity())
        {
            case 1.2f:
                activityDropdown.value = 0;
                break;
            case 1.375f:
                activityDropdown.value = 1;
                break;
            case 1.55f:
                activityDropdown.value = 2;
                break;
            case 1.725f:
                activityDropdown.value = 3;
                break;
            case 1.9f:
                activityDropdown.value = 4;
                break;
        }
    }
    public void SexChanging()
    {
        switch (sexDropdown.value)
        {
            case 0:
                AccountObject.SetSex(AccountClass.Sex.Men);
                break;
            case 1:
                AccountObject.SetSex(AccountClass.Sex.Women);
                break;
        }
    }

    public void ActivityChanging()
    {
        switch (activityDropdown.value)
        {
            case 0:
                AccountObject.SetActivity(AccountClass.Activity.Minimum);
                break;
            case 1:
                AccountObject.SetActivity(AccountClass.Activity.Low);
                break;
            case 2:
                AccountObject.SetActivity(AccountClass.Activity.Medium);
                break;
            case 3:
                AccountObject.SetActivity(AccountClass.Activity.High);
                break;
            case 4:
                AccountObject.SetActivity(AccountClass.Activity.VeryHigh);
                break;
        }
    }

    public void NameChanging()
    {
        _nameInput = nameText.GetComponent<InputField>().text;

        if (_nameInput.Length > 3 && _nameInput.Length < 15)
        {
            AccountObject.GetSetName = _nameInput;
        }
    }
    public void DateChanging()
    {
        bool CanGoNext = DateTime.TryParse(dateText.GetComponent<InputField>().text, out _dateInput);
  
        if (CanGoNext && _dateInput.Year < (DateTime.Now.Year - 12) && _dateInput.Year > (DateTime.Now.Year - 100))
        {
            AccountObject.GetSetDate = _dateInput;
        }
    }
    public void HeightChanging()
    {
        bool CanGoNext = int.TryParse(heightText.GetComponent<InputField>().text, out _hightInput);

        if (CanGoNext && _hightInput > 120 && _hightInput < 220)
        {
            AccountObject.GetSetHeight = _hightInput;
        }
    }
    public void VeightChanging()
    {
        bool CanGoNext = int.TryParse(veightText.GetComponent<InputField>().text, out _veightInput);

        if (CanGoNext && _veightInput > 45 && _veightInput < 200)
        {
            AccountObject.GetSetVeight = _veightInput;
        }
    }
    public void SceneExit()
    {
        AccountObject.Calculation();
        AccountObject.WriteToFile();
    }
}
