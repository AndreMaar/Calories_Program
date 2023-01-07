using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountSetting : MonoBehaviour
{
    [SerializeField] private Dropdown sexDropdown;
    [SerializeField] private Dropdown activityDropdown;

    private AccountClass AccountObject =  RegistrationScript.newAccount;

    private void Start()
    {
        if (AccountObject.GetSex().ToString() == "Male")
        {
            sexDropdown.value = 0;
        }
        else if (AccountObject.GetSex().ToString() == "Female")
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
}
