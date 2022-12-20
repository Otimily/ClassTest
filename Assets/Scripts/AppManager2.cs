using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager2 : MonoBehaviour
{
    public Friend red;
    public Friend puple;

    public Food ChocolateTart;
    public Food zingerburger;

    void Start()
    {
        Debug.Log("감사합니다. 앱이 정상적으로 플레이됩니다!");

        red.Introduce();
        puple.Introduce();

        Eat(ChocolateTart);
        Eat(zingerburger);
    }

    void Eat(Food f)
    {
        Debug.Log("감사합니다. 앱이 정상적으로 플레이됩니다!");
    }
}
