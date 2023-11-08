using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoLooping : MonoBehaviour
{
    int enemynum = 4;
    // Start is called before the first frame update
    void Start()
    {
        print("I am fighting several people");
        for (int guy = 0; guy <= enemynum; guy++)
        {
            Debug.Log("The number of people I've beaten in a fight so far is: " + guy);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
    