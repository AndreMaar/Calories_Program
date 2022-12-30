using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Runtime;


public class AccountClass
{
    public AccountClass(string nickname, int hei, int vei, DateTime birthDate, Sex _sex, Activity activity)
    {
        this.nickname = nickname;
        height = hei;
        veight = vei;
        this.birthDate = birthDate;
        this._sex = _sex;

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
        Debug.Log("Вода" + water);
    }

    public int Property
    {
        set { currentDayCalories = value; }     
        get { return currentDayCalories; }
    }
}




