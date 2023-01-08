using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  public GameObject bullet;
  public Transform creep;
  private void OnTriggerStay(Collider other)
  {
    
    GameObject.FindGameObjectsWithTag("creep");
    
    if (other.CompareTag("creep"))
    {
      Quaternion.LookRotation(new Vector3(1,1,1));
      Instantiate(bullet);
    }
  }
}
