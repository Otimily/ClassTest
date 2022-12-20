using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public string Name;
    public string store;

    public int price;
    
    public bool meet;
    public bool setmenu;

    public void Eat()
    {
        Debug.Log(Name + "를 " + store + "에서 " + price + "원을 주고 사 먹었습니다.");

    }

}
