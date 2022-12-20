using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour
{
    public string Name;
    public string nickname;
    public string phoneNumver;

    public int followCount;
    public int followerCount;

    public bool isFollow;

    public void Introduce()
    {
        Debug.Log(Name + "님께서 인스타그램을 사용중입니다. 전화번호 :" + phoneNumver);

    }
    public void Eat(Food f)
    {
        Debug.Log(f.Name + "를 " + f.store + "에서 " + f.price + "원을 주고 사 먹었습니다.");

    }

}
