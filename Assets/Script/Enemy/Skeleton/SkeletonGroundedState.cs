using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonGroundedState : EnemyState
{

    private Enemy_Skeleton enemy;
    protected Transform player;
    public SkeletonGroundedState(Enemy _enemy, EnemyStateMachine _stateMachine, string _animBoolName, Enemy_Skeleton enemy) 
        : base(_enemy, _stateMachine, _animBoolName)
    {
        this.enemy = enemy;
    }

    public override void Enter()
    {
        base.Enter();
        player = PlayerManager.GetInstance().player.transform;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (enemy.IsPlayerDerected()  ||Vector2.Distance(enemy.transform.position,player.position) < 2)
        {
            stateMachine.ChangeState(enemy.battleState);
        }
    }
}
