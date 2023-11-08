using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLooping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool Continue = false;

        do
        {
            print("Can I go get a drink of water?");
        } while (Continue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
