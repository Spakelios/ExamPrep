using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class move : MonoBehaviour
{
 public NavMeshAgent agent;
private Transform player;

 public void Awake()
 {
  player = GameObject.Find("Tower(Clone").transform;
  agent = GetComponent<NavMeshAgent>();
 }

 private void Start()
 {
  StartCoroutine("Die");

  agent.SetDestination(player.position);

 }

 IEnumerator Die()
 {

  yield return new WaitForSeconds(5);
  
  Destroy(gameObject);

 }
}
