using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
