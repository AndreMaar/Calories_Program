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
    void Start()
    {
        if (File.Exists(textDocumentName))
        {
            var line = File.ReadAllLines(textDocumentName);
            Debug.Log(line[0]);
            DateTime Date = DateTime.Parse(line[0]);

            //Нада продумать і протестить

            if (Date == DateTime.Today)
            {
                Debug.Log("Дата збігається");
                WriteDailyLogs();
            }
            else
            {
                Debug.Log("Дата не збігається");
                WriteHistoryLogs(line);
                WriteDailyLogs();
            }
        }
        else
        {
            Debug.Log("Файлу не існує");
            WriteDailyLogs();
        }
    }
    //
    //Треба функція яка буде створювати та заповнювати list і повертати його
    //
   
    public static void WriteDailyLogs()
    {
        List<string> daily_logs = new List<string>();
        daily_logs.Add(DateTime.Today.ToString());
        daily_logs.Add(AccountObject.GetSetVeight.ToString());
        daily_logs.Add(AccountObject.GetWater().ToString());
        daily_logs.Add(AccountObject.Property.ToString());

        for (int i = 0; i < 3; i++)
        {
            if (FoodSystem.meat[i] != null)
            {
                switch (i)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
        }
        File.WriteAllLines(textDocumentName, daily_logs);
    }

    private void WriteHistoryLogs(string[] daily_logs)
    {
        File.AppendAllLines(textHistoryDocumentName, daily_logs);
    }
}
//Треба функція зчитування DailyLogs файлу в обʼєкт акаунту.