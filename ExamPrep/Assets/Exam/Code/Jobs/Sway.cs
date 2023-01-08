using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sway : MonoBehaviour
{
    public bool useJobSystem = false;  
    public float angle = 30;
    public float frequency = 1;
    float theta = 0;
    void Start()
    {
        if (useJobSystem)
        {
            SwayManager.Instance.Add(this);
        }
    }
    void Update() // where you generate what the predab does
    {
        if (! useJobSystem)
        {
            transform.rotation = Quaternion.AngleAxis(Mathf.Sin(theta) * angle, transform.right);
            theta += Mathf.PI * 2.0f * Time.deltaTime * frequency;
        }
    }
    
}