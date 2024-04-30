using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokingRepeating : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("SpawnObject");
        }
    }

    void SpawnObject()
    {
        float randomX = Random.Range(-2f, 2f);
        float randomZ = Random.Range(-2f, 2f);
        Instantiate(bullet, new Vector3(randomX, 2, randomZ), Quaternion.identity);
    }
}
