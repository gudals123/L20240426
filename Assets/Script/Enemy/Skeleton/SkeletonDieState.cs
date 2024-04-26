using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonDieState : EnemyState
{
    Enemy_Skeleton enemy;

    public SkeletonDieState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, Enemy_Skeleton enemy) 
        : base(_enemyBase, _stateMachine, _animBoolName)
    {
        this.enemy = enemy;
    }

    public override void AnimationFinishTrigger()
    {
        base.AnimationFinishTrigger();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        enemy.ZeroVelocity();
    }



}
