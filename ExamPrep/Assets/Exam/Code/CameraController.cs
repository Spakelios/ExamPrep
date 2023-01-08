using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public Image Image;

    private void Update()
    {
        Image.transform.position = Input.mousePosition;
    }
}
