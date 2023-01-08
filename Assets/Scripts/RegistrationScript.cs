using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;
using System.Linq;
using System.IO;
using System.Runtime;
using UnityEngine.SceneManagement;



public class RegistrationScript : MonoBehaviour
{
    private DateTime _dateInput = new DateTime(0001,01,01);
    private int _hightInput = 0;
    private float _veightInput = 0;
    private string _nameInput = "NoName";
    bool CanGoNext = true;

    [SerializeField] private GameObject DateInputField;
    [SerializeField] private GameObject HightInputField;
    [SerializeField] private GameObject VeightInputField;
    [SerializeField] private GameObject NameInputField;
    [SerializeField] private GameObject NextButton;
    [SerializeField] private GameObject NextButtonText;
    [SerializeField] private GameObject BackButton;
    [SerializeField] private GameObject ErrorText;


    [SerializeField] private GameObject[] registrationObjects;

    [SerializeField] private ToggleGroup SexToggleGroup;
    [SerializeField] private ToggleGroup ActivityToggleGroup;

    public static  AccountClass newAccount;
    AccountClass.Sex _sex = AccountClass.Sex.Men;
    AccountClass.Activity _activity = AccountClass.Activity.Low;
    string textDocumentName = Application.streamingAssetsPath + "/AccountLogs/" + "Logs" + ".txt";

    private int _pageNumber = 0;
    string[] logs = new string [12];

    public void Awake()
    {
        if (File.Exists(textDocumentName))
        {
            var lines = File.ReadAllLines(textDocumentName).ToList();

            SexSet(lines[4]);

            ActivitySet(lines[5]);

            newAccount = new AccountClass(lines[0], int.Parse(lines[1]), float.Parse(lines[2]), DateTime.Parse(lines[3]), _sex, _activity);
            newAccount.ShowIndex();
            SceneManager.LoadScene(1);
        }
    }

    public void ShowIndex()
    {
        newAccount = new AccountClass(_nameInput, _hightInput, _veightInput, _dateInput, _sex, _activity);
        newAccount.ShowIndex();
    }

    public void DateChecker() //Функція перевірки та запису дати народження   
    {
        CanGoNext = DateTime.TryParse(DateInputField.GetComponent<Text>().text , out _dateInput);

        if (CanGoNext == true && (_dateInput.Year > (DateTime.Now.Year - 12) || _dateInput.Year < (DateTime.Now.Year - 100)))
        {
            CanGoNext = false;
        }

        if (CanGoNext == true)
            ErrorText.gameObject.SetActive(false);
        else
            ErrorText.gameObject.SetActive(true);

    }

    public void HightChecker()
    {
        CanGoNext = int.TryParse(HightInputField.GetComponent<Text>().text, out _hightInput);

        if (_hightInput < 120 || _hightInput > 220){
            CanGoNext = false;
            ErrorText.gameObject.SetActive(true);
        }
        else
            ErrorText.gameObject.SetActive(false);
    }

    public void VeightChecker()
    {
        CanGoNext = float.TryParse(VeightInputField.GetComponent<Text>().text, out _veightInput);

        if (_veightInput < 45 || _veightInput > 200){
            CanGoNext = false;
            ErrorText.gameObject.SetActive(true);
        }
        else
            ErrorText.gameObject.SetActive(false);
    }

    public void SexChecker()
    {
        Toggle sexToggle = SexToggleGroup.ActiveToggles().FirstOrDefault();
        CanGoNext = false;
        if (sexToggle != null)
        {
            SexSet(sexToggle.name);

            CanGoNext = true;
        }
    }

    public void SexSet(string sex)
    {
        if (sex == "Male")
        {
            _sex = AccountClass.Sex.Men;
        }
        else if (sex == "Female")
        {
            _sex = AccountClass.Sex.Women;
        }
    }

    public void ActivityChecker()
    {
        Toggle activityToggle = ActivityToggleGroup.ActiveToggles().FirstOrDefault();
        CanGoNext = false;
        if (activityToggle != null)
        {
            ActivitySet(activityToggle.name);

            CanGoNext = true;
        }
    }

    public void ActivitySet(string activity)
    {
        switch (activity)
        {
            case "Minimum":
                _activity = AccountClass.Activity.Minimum;
                break;
            case "Low":
                _activity = AccountClass.Activity.Low;
                break;
            case "Medium":
                _activity = AccountClass.Activity.Medium;
                break;
            case "High":
                _activity = AccountClass.Activity.High;
                break;
            case "VeryHigh":
                _activity = AccountClass.Activity.VeryHigh;
                break;
        }
    }

    public void NameChecker()
    {
        _nameInput = NameInputField.GetComponent<Text>().text;

        if (_nameInput.Length > 3 && _nameInput.Length < 15)
        {
            CanGoNext = true;
            ErrorText.gameObject.SetActive(false);
        }
        else
            ErrorText.gameObject.SetActive(true);
    }

    public void CheckImputs()
    {
        switch (_pageNumber)
        {
            case 1:
                DateChecker();
                break;
            case 2:
                HightChecker();
                break;
            case 3:               
                VeightChecker();
                break;
            case 4:
                SexChecker();
                break;
            case 5:                                
                ActivityChecker();
                break;
            case 6:
                NameChecker();
                break;
        }
    }
    public void NextPage()
    {
        CheckImputs();
        if (_pageNumber < 7 && CanGoNext)
        {
            _pageNumber++;
            CanGoNext = false;
            ChangeRegistrationPage();
        }
        if (_pageNumber == 7)
        {
            FinishRegistration();
        }
    }

    public void BackPage()
    {
        if (_pageNumber > 0)
        {
            _pageNumber--;
            ChangeRegistrationPage();
        }
    }

    private void ChangeRegistrationPage()
    {
        for(int i = 0; i < registrationObjects.Length; i++)
        {
            registrationObjects[i].gameObject.SetActive(false);
        }
        
        ErrorText.gameObject.SetActive(false);

        switch (_pageNumber)
        {
            case 0:                
                BackButton.gameObject.SetActive(false);
                CanGoNext = true;
                NextButtonText.GetComponent<Text>().text = "Register";
                break;
            case 1:
                NextButtonText.GetComponent<Text>().text = "Next";                
                BackButton.gameObject.SetActive(true);
                registrationObjects[0].gameObject.SetActive(true);
                break;
            case 2:
                registrationObjects[1].gameObject.SetActive(true);
                break;
            case 3:
                registrationObjects[2].gameObject.SetActive(true);
                break;
            case 4:
                registrationObjects[3].gameObject.SetActive(true);
                break;
            case 5:
                registrationObjects[4].gameObject.SetActive(true);
                NextButtonText.GetComponent<Text>().text = "Next";
                break;
            case 6:
                registrationObjects[5].gameObject.SetActive(true);
                NextButtonText.GetComponent<Text>().text = "Finish";
                break;
        }
        
    }

    private void FinishRegistration()
    {
        newAccount = new AccountClass(_nameInput, _hightInput, _veightInput, _dateInput, _sex, _activity);
        newAccount.ShowIndex();

        SceneManager.LoadScene(1);

        newAccount.WriteToFile();

    }
}
