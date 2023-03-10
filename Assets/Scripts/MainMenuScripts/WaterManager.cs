using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterManager : MonoBehaviour
{
    private int water = 0;

    [SerializeField] private Image[] waterPoints;
    [SerializeField] private Sprite fullWater;
    [SerializeField] private Sprite emptyWater;
    
    // Start is called before the first frame update
    void Start()
    {
        water = RegistrationScript.newAccount.GetWater();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Image img in waterPoints)
        {
            img.sprite = emptyWater;
        }
        for (int i = 0; i < water; i++)
        {
            waterPoints[i].sprite = fullWater;
        }

    }

    public void AddWater()
    {
        if (water < 7)
        {
            water++;
            RegistrationScript.newAccount.SetWater(water);
        }
    }
    public void RemoveWater()
    {
        if (water > 0)
        {
            water--;
            RegistrationScript.newAccount.SetWater(water);
        }
    }
}
