using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAwakeAnd : MonoBehaviour
{
    //Awake happens even if the script is not enabled.
    //Poop
    void Awake()
    {
        Debug.Log("Awake was here first.");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start was second.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
