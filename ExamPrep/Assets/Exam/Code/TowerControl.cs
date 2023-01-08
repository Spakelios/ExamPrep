using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class TowerControl : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            GenerateTower.tower--;
        }
        
        if (Input.GetMouseButton(1))
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
        } 
        
    }
    
    
}
