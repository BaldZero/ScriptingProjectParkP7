using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public Rigidbody bombPrefab;
    public Transform cubeEnd;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody bombInstance;
            bombInstance = Instantiate(bombPrefab, cubeEnd.position, cubeEnd.rotation);
            bombInstance.AddForce(cubeEnd.forward * 2000);
        }
       
    }
}
