using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 추상 클래스
public abstract class Creature : MonoBehaviour
{
    virtual public void Awake() {}

    virtual public void OnDestroy() {}

    public float GetHealth() { return _health; }
    public void SetHealth(float health) { _health = health; }
    public float GetStamina() { return _stamina; }
    public void SetStamina(float stamina) { _stamina = stamina; }
    public float GetAttackDamage() { return _attackDamage; }
    public void SetAttackDamage(float attackDamage) { _attackDamage = attackDamage; } 
    public void TakeDamage(float attackDamage) 
    { 
        if(_health - attackDamage > 0)
        {
            _health -= attackDamage;
        }
        else if(_health - attackDamage <= 0)
        {
            _health = 0;
            _isDead = true;
        }
    }

    protected float _health;
    protected float _stamina;
    protected float _attackDamage;
    protected float _moveSpeed;
    protected bool _isDead = false;

}
