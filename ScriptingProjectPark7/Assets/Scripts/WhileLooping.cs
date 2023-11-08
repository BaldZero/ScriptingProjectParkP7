using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLooping : MonoBehaviour
{
    int cupsinthesink = 4;
    // Start is called before the first frame update
    void Start()
    {
        while (cupsinthesink > 0)
        {
            Debug.Log("I just washed a cup");
            cupsinthesink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
