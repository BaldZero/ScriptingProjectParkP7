using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDownOn : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    private void Awake()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
        Debug.Log("CLICKITY CLICKITY");
    }
}
