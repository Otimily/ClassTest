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
        Debug.Log("�����մϴ�. ���� ���������� �÷��̵˴ϴ�!");

        red.Introduce();
        puple.Introduce();

        Eat(ChocolateTart);
        Eat(zingerburger);
    }

    void Eat(Food f)
    {
        Debug.Log("�����մϴ�. ���� ���������� �÷��̵˴ϴ�!");
    }
}
