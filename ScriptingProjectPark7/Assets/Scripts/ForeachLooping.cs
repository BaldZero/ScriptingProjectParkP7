using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLooping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string [3];

        strings[0] = "First fish";
        strings[1] = "Second fish";
        strings[2] = "Third fish";

        foreach(string Fish in strings)
        {
            print(Fish);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
