using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 1)
        {
            SceneManager.LoadScene(2);
        }
        else if (scene.buildIndex == 2)
        {
            SceneManager.LoadScene(1);
        }
        
    }
    
}
