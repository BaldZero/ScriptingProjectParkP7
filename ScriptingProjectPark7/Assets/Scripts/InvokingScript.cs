using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokingScript : MonoBehaviour
{
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        Instantiate(bomb, new Vector3(0, 2, 0), Quaternion.identity);
    }
}
