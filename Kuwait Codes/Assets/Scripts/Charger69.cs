using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger69 : MonoBehaviour
{

    string heroname = "General Lee";
    int herohight = 180;
    int heroage = 53;
    string herosuperpower = "nitros";
    string villanname = "Bugatti";
    int villanhight = 150;
    int villanage = 6;
    string villansuperpower = "super speed";
    
    // Start is called before the first frame update
    void Start()
    {
        print(" hero name is " + heroname + " and his age is " + heroage);
        print(" villan name is " + villanname + " and his age is " + villanage);
        print(" hero hight is " + herohight + 5 + " and his super power is " + herosuperpower);
        print(" villan hight is " + villanhight + " and his super power is " + villansuperpower);
        print(" the age difference between them is " + (heroage - villanage));
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
