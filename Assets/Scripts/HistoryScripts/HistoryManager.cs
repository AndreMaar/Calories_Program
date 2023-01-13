using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class HistoryManager : MonoBehaviour
{
    string textHistoryDocumentName = Application.streamingAssetsPath + "/AccountLogs/" + "HistoryDailyLogs" + ".txt";
    DateTime date;
    string veight;
    int j = -1;
    string calories;
    HistoryScrollViewItem myScriptReference;

    [SerializeField] private Transform scrollViewContent;
    public GameObject prefab;


    static public List<HistoryMealClass> historyMeal = new List<HistoryMealClass>();

    private void Start()
    {
        var lines = File.ReadAllLines(textHistoryDocumentName);
        ReadMeatHistory(lines);
    }

    private void ReadMeatHistory(string[] lines)
    {
        for(int i = 0; i< lines.Length; i++){
            if (DateTime.TryParse(lines[i], out date))
            {
                veight = lines[i + 1];
                calories = lines[i + 3];
                i += 3;
                j++;
                
                GameObject prefabInstance = Instantiate(prefab, scrollViewContent);
                myScriptReference = prefabInstance.GetComponent<HistoryScrollViewItem>();
                prefabInstance.transform.GetChild(0).gameObject.GetComponent<Text>().text = date.ToString("MM.dd.yyyy") + " | " + veight + "kg | " + calories + "kcal";
                myScriptReference.numberOfScrollViewElement = j;
                if(int.Parse(calories) == 0)
                    prefabInstance.transform.GetChild(1).gameObject.SetActive(false);

                historyMeal.Add(new HistoryMealClass());
            }
            else
            {   
                historyMeal[j].AddHistoryMeal(lines[i]);
            }
        }
    }
}
