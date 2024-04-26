using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SkeletonAnimationTriggers : MonoBehaviour
{
    private Enemy_Skeleton enemy => GetComponentInParent<Enemy_Skeleton>(); 

    private void AnimationTrigger()
    {
        enemy.AnimationFinishTrigger(); 
    }
    private void AttackTrigger()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(enemy.attackCheck.position, enemy.attackCheckRadius);     //범위내에 있는 모든 콜라이더를 가져오는 함수

        foreach (Collider2D hit in colliders)
        {
            if (hit.GetComponent<Player>() != null)
            {
                hit.GetComponent<Player>().Damage(10);
            }

        }
    }

    private void OpenCounterWindow()=>enemy.OpenCounterAttackwindow();

    private void CloseCounterWindow() => enemy.CloseCounterAttackwindow();   
}
