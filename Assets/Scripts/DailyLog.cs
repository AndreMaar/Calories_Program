using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DailyLog : MonoBehaviour
{
    private static AccountClass AccountObject = RegistrationScript.newAccount;
    static string textDocumentName = Application.streamingAssetsPath + "/AccountLogs/" + "DailyLogs" + ".txt";
    string textHistoryDocumentName = Application.streamingAssetsPath + "/AccountLogs/" + "HistoryDailyLogs" + ".txt";

    private List<FoodClass> Food;
    private static bool FirstRun = false;
    void Awake()
    {
        if (!FirstRun)
        {
            SetReadAndWrite();
        }
    }

    private void SetReadAndWrite()
    {
        FirstRun = true;
        AllFood.CreateList();
        if (File.Exists(textDocumentName))
        {
            var line = File.ReadAllLines(textDocumentName);

            DateTime Date = DateTime.Parse(line[0]);

            if (Date == DateTime.Today)
            {
                ReadToAccount(line);
                WriteDailyLogs();
            }
            else
            {
                WriteHistoryLogs(line);
                WriteDailyLogs();
            }
        }
        else
        {
            WriteDailyLogs();
        }
    }
    public static void WriteDailyLogs()
    {
        List<string> daily_logs = new List<string>();
        daily_logs.Add(DateTime.Today.ToString());
        daily_logs.Add(AccountObject.GetSetVeight.ToString());
        daily_logs.Add(AccountObject.GetWater().ToString());
        daily_logs.Add(AccountObject.Property.ToString());

        for (int j = 0; j < 3; j++)
        {
            if (FoodSystem.meal[j] != null)
            {
                string mealName = null;
                switch (j)
                {
                    case 0:
                        mealName="Breakfast ";
                        break;
                    case 1:
                        mealName = "Lunch ";
                        break;
                    case 2:
                        mealName = "Dinner ";
                        break;
                }
                for (int i = 0; i < FoodSystem.meal[j].GetFoodList().Count; i++)
                {
                    daily_logs.Add(mealName + FoodSystem.meal[j].GetFoodList()[i].GetName() + " " + FoodSystem.meal[j].GetFoodList()[i].GetGrams() + " " + FoodSystem.meal[j].GetFoodList()[i].GetTotalCalories());
                }
            }
        }

        File.WriteAllLines(textDocumentName, daily_logs);
    }

    private void WriteHistoryLogs(string[] daily_logs)
    {
        File.AppendAllLines(textHistoryDocumentName, daily_logs);
    }

    private void ReadToAccount(string[] daily_logs)
    {
        Food = new List<FoodClass>(AllFood.foods);

        RegistrationScript.newAccount.GetSetVeight = float.Parse(daily_logs[1]);
        RegistrationScript.newAccount.SetWater(int.Parse(daily_logs[2]));

        if (daily_logs.Length > 4) {
            for (int j = 4; j < daily_logs.Length; j++)
            {
                int i=0;
                string[] words = daily_logs[j].Split(' ');
                switch (words[0])
                {
                    case "Breakfast":
                        i = 0;
                        break;
                    case "Lunch":
                        i = 1;
                        break;
                    case "Dinner":
                        i = 2;
                        break;
                }
                FoodSystem.meal[i] = new MeatClass();
                foreach (FoodClass food in Food)
                {
                    if (food.GetName() == words[1])
                    {
                        FoodSystem.meal[i].AddElementOfFood(food);
                        food.SetGrams(int.Parse(words[2]));
                    }
                }
            }
        }
    }
}