using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myObject;

    void Start()
    {
        Debug.Log("Active Self; " + myObject.activeSelf);
        Debug.Log("Active in hierarchy" + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
