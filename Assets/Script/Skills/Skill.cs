using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField]
    protected float cooldown;
    protected float cooldownTimer;

    protected Player player;


    protected virtual void Start()
    {
        player = PlayerManager.GetInstance().player;
    }

    protected virtual void Update()
    {
        cooldownTimer -= Time.deltaTime;    
    }


    public virtual bool CanUseSkill()
    {
        if(cooldownTimer < 0){
            cooldownTimer = cooldown;
            return true;
        }
        Debug.Log("��ų ��ٿ�");
        return false;
    }

    public virtual void UseSkill()
    {
        //����� ��ų ����
    }

}
