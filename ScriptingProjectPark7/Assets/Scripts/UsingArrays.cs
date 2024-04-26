using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UsingArrays : MonoBehaviour
{
    public GameObject[] player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < player.Length; i++)
        {
            Debug.Log("Player Number " + (i + 1) + " is named " + player[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
