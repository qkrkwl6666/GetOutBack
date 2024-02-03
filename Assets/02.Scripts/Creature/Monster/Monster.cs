using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum MonsterState
{
    Idle,   // 대기 상태
    Move,   // 이동 상태
    Attack, // 공격 상태
}

public class Monster : Creature
{
    public override void Awake()
    {
        base.Awake();
        _health = 100;
        _attackDamage = 20;
        _moveSpeed = 30;
        currentState = MonsterState.Idle;
    }
    public override void OnDestroy()
    {
        base.OnDestroy();
    }
    public MonsterState GetMonsterState() {  return currentState; }

    protected MonsterState currentState;

}
