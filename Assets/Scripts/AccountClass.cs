using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Runtime;


public class AccountClass
{
    public AccountClass(string nickname, int height, int veight, DateTime birthDate, Sex _sex, Activity activity)
    {
        this.nickname = nickname;
        this.height = height;
        this.veight = veight;
        this.birthDate = birthDate;
        this._sex = _sex;

        SetActivity(activity);

        index = Calculation();
    }

    public enum Sex
    {
        Men,
        Women,
    }
    public enum Activity
    {
        Minimum,
        Low,
        Medium,
        High,
        VeryHigh,
    }
    private string nickname;
    private Sex _sex;
    private DateTime birthDate;
    private int age;
    private int height;
    private int veight;
    private float activity;
    public double index;

    private int water;
    private int currentDayCalories;

    private double Calculation()
    {
        double i;

        if (DateTime.Today.Month < birthDate.Month || DateTime.Today.Day < birthDate.Day)
            age = (int)DateTime.Today.Year - (int)birthDate.Year - 1;
        else
            age = (int)DateTime.Today.Year - (int)birthDate.Year;

        if (_sex == Sex.Men)
            i = (88.36 + (13.4 * veight) + (4.8 * height) - (5.7 * age)) * activity;
        else
            i = (447.6 + (9.2 * veight) + (3.1 * height) - (4.3 * age)) * activity;
        return i;
    }

    public void ShowIndex()
    {
        Debug.LogFormat("{0} {1} {2} {3} {4} {5} | Index = {6}", nickname, veight, height, age, _sex, activity, index);
    }

    public void SetWater(int waterValue)
    {
        water = waterValue;
    }

    public int GetWater()
    {
        return water;
    }

    public int Property
    {
        set { currentDayCalories = value; }     
        get { return currentDayCalories; }
    }

    public string GetSetName
    {
        set { nickname = value; }
        get { return nickname; }
    }

    public void SetSex(Sex sex)
    {
        _sex = sex;
    }
    public void SetActivity(Activity activity)
    {
        switch (activity)
        {
            case Activity.Minimum:
                this.activity = 1.2f;
                break;
            case Activity.Low:
                this.activity = 1.375f;
                break;
            case Activity.Medium:
                this.activity = 1.55f;
                break;
            case Activity.High:
                this.activity = 1.725f;
                break;
            case Activity.VeryHigh:
                this.activity = 1.9f;
                break;
        }
    }
    public float GetActivity()
    {
        return activity;
    }
    public Sex GetSex()
    {
        return _sex;
    }
}




