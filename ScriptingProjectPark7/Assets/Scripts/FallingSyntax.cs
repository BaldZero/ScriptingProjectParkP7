using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.y);

        if(transform.position.y <= 5f)
        {
            /* stuff is happening
             * HES GONNA HIT THE GROUND
             * */
            Debug.Log("I'm going to hit the ground AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH!!!.");
            
            if(transform.position.y <-5f)
            {
                Debug.Log("I have hit the ground.");
                //HE HIT THE GROUND
                //HOW COULD YOU!!!!!!!!!!!!!!!!!!
             
            }
        }
    }
}
