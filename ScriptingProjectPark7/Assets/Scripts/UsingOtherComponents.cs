using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{

        public GameObject otherBoi;

        private AnotherScript anotherScript;
        private AnotherScriptSquared anotherScriptSquared;
        private BoxCollider boxCol;

    // Start is called before the first frame update
    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        anotherScriptSquared = GetComponent<AnotherScriptSquared>();
        boxCol = GetComponent<BoxCollider>();
    }

    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + anotherScriptSquared.numberOfPlayerDeaths + " times");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
