using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(int i)
    {
        DailyLog.WriteDailyLogs();
        SceneManager.LoadScene(i);
        if(SceneManager.GetActiveScene().buildIndex == 7) {
            for (int j = 0; j<HistoryManager.historyMeal.Count; j++)
            {
                HistoryManager.historyMeal[j].ClearAllLists();
            }
        }
    }
}
