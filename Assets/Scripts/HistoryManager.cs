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
    string calories;

    [SerializeField] private Transform scrollViewContent;
    public GameObject prefab;

    private void Start()
    {
        var lines = File.ReadAllLines(textHistoryDocumentName);
        ReadMeatHistory(lines);
    }

    private void ReadMeatHistory(string[] lines)
    {
        for(int i = 0; i< lines.Length; i++){
            if(DateTime.TryParse(lines[i], out date))
            {
                veight = lines[i+1];
                calories = lines[i+3];

                GameObject prefabInstance = Instantiate(prefab, scrollViewContent) as GameObject;
                var myScriptReference = prefabInstance.GetComponent<HistoryScrollViewItem> ();
                
                prefabInstance.transform.GetChild(1).gameObject.GetComponent<Text>().text = date.ToString("MM.dd.yyyy") + " | " + veight + "kg | " + calories + "kcal";
            
            }
        }

    }
}
