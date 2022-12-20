using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppManager : MonoBehaviour
{
    public Friend red;
    public Friend puple;
    public Friend kamcho;
    public Friend brown;

    public Food towerburger;
    public Food zingerburger;
    public Food twister;

    public Food chocolatetart;
    public Food nugget;


    private void Start()
    {
        red.Introduce();
        puple.Introduce();
        kamcho.Introduce();
        brown.Introduce();

        towerburger.Eat();
        zingerburger.Eat();
        twister.Eat();

        chocolatetart.Eat();
        nugget.Eat();

        red.Eat(zingerburger);


    }

}
