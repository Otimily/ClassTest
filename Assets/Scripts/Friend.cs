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
        Debug.Log(Name + "�Բ��� �ν�Ÿ�׷��� ������Դϴ�. ��ȭ��ȣ :" + phoneNumver);

    }
    public void Eat(Food f)
    {
        Debug.Log(f.Name + "�� " + f.store + "���� " + f.price + "���� �ְ� �� �Ծ����ϴ�.");

    }

}
