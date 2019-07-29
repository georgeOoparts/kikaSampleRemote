using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testZukei : MonoBehaviour
{
    public GameObject e2;

    // Start is called before the first frame update
     
    void Start()
    {
        //public Image banana;

        //spriteRenderer srCircle1= circle1.GetComponent<Renderer>();
        //Renderer rdE2 = e2.GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            e2.GetComponent<Renderer>().enabled = false; 


        Debug.Log("wo::"+e2.name);        
    }
}
