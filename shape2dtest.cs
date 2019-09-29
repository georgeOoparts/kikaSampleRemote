using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes2D;

public class shape2dtest : MonoBehaviour
{
   
    void Start()
    {
   
        var shape = GetComponent<Shape>();
        shape.settings.fillColor = Color.white;

        Debug.Log("test");
    }

   
}
