using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FastVeightChanging : MonoBehaviour
{
    [SerializeField] private Text VeightText;
    
    public void Start()
    {
        UpdateInfo();
    }

    public void UpdateInfo()
    {
        VeightText.GetComponent<Text>().text = RegistrationScript.newAccount.GetSetVeight.ToString();
        DailyLog.WriteDailyLogs();
    }

    public void PlusVeight()
    {
        RegistrationScript.newAccount.GetSetVeight += 0.1f;
        
        UpdateInfo();
    }
    public void MinusVeight()
    {
        RegistrationScript.newAccount.GetSetVeight -= 0.1f;
        
        UpdateInfo();
    }

}
