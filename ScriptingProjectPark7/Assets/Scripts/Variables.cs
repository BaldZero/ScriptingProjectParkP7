using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int Myint = 5;
    // Start is called before the first frame update
    void Start()
    {
        Myint = MultiplyByTwo(Myint);
        Debug.Log(Myint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
