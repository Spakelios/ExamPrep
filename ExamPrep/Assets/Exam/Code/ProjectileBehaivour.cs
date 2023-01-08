using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed = 4;

    public void Update()
    {
        transform.position += transform.right * (Time.deltaTime * speed);
        StartCoroutine(die());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("creep"))
        {
            Destroy(other.gameObject);
        }
    }

    IEnumerator die()
    {
        yield return new WaitForSeconds(10);
        
        Destroy(gameObject);

    }
}
