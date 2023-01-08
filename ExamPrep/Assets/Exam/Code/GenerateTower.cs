using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateTower : MonoBehaviour
{

    public GameObject Tower;
    public static float x, y = 3, z = 7, tower;
    public Button button;
    public GameObject spawn;



    public void Generate()
    {
        Instantiate(Tower);
        tower++;
        Tower.transform.position = new Vector3(x + 10 , y, z);
        spawn.SetActive(true);

        
        
      
    } 
    

    public void Update()
    {
    
        if (tower >= 4)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }
}
