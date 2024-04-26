using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Skeleton : Enemy
{

    #region States
    public SkeletonIdleState idleState { get; private set; }
    public SkeletonMoveState moveState { get; private set; }
    public SkeletonBattleState battleState { get; private set; }
    public SkeletonAttackState attackState { get; private set; }

    public SkeletonStunnedState stunnedState { get; private set; }
    public SkeletonDieState dieState { get; private set; }

    #endregion


    protected override void Awake()
    {
        base.Awake();

        idleState = new SkeletonIdleState(this,stateMachine,"Idle",this);
        moveState = new SkeletonMoveState(this,stateMachine,"Move",this);
        battleState = new SkeletonBattleState(this, stateMachine, "Move", this);
        attackState = new SkeletonAttackState(this, stateMachine, "Attack", this);
        stunnedState = new SkeletonStunnedState(this, stateMachine, "Stun", this);
        dieState = new SkeletonDieState(this, stateMachine,"Die", this);
    }

    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(idleState);
    }

    protected override void Update()
    {
        base.Update();

        CheckDie();
        
        if (canBeStunned && isKnocked)
        {
            stateMachine.ChangeState(stunnedState);
        }
    }

    private void CheckDie()
    {
        if(hp <= 0)
        {
            stateMachine.ChangeState(dieState);
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        Debug.Log("Á×À½2");
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }

    public override void AnimationFinishTrigger()
    {
        base.AnimationFinishTrigger();
    }
    public override bool CanBeStunned()
    {
        if(base.CanBeStunned())
        {
            stateMachine.ChangeState(stunnedState);
            return true;
        }
        return false;
    }
}
