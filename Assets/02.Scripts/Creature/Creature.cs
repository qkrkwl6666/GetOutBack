using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �߻� Ŭ����
public abstract class Creature : MonoBehaviour
{
    private int _health;
    private int _stamina;
    virtual public void Awake()
    {
        _health = 1000;
        _stamina = 100;
    }

    ~Creature()
    {

    }


}
