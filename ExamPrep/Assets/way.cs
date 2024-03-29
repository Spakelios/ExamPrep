using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class way : MonoBehaviour 
{
    public float angle = 20.0f;
    public float frequency;
    public float theta;
    public Vector3 axis = Vector3.zero;
    
    void Start () 
    { 
        if (axis == Vector3.zero) 

        {
            axis = Random.insideUnitSphere;
            axis.y = 0;
            axis.Normalize(); 

        }
    }
    void Update () 
    {
        transform.localRotation = Quaternion.AngleAxis(
            Mathf.Sin(theta) * angle, axis);
        theta += frequency * Time.deltaTime * Mathf.PI * 2.0f;
    }
} 