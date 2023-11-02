using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTimer : MonoBehaviour
{
    float Coffeetemperature = 85.0f;
    float hotlimitTemperature = 70.0f;
    float coldlimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Temperaturetest();

        if (Input.GetKeyDown(KeyCode.W))
            Coffeetemperature = Coffeetemperature + 10;
            Coffeetemperature -= Time.deltaTime*5f;
        

    }
    void Temperaturetest()
    {
        if(Coffeetemperature > hotlimitTemperature)
        {
            print("AHHHHHHHHH HOTTTT.");
        }
        else if(Coffeetemperature < coldlimitTemperature) 
        {
            print("TOO COLD DONT DRINK.");
        }
        else
        {
            print("OH YEAH THATS GOOD.");
        }
    }
}
