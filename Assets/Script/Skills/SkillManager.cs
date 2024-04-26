using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    private SkillManager()
    {

    }

    ~SkillManager()
    {

    }

    private static SkillManager instance;
    public Dash_Skill dash { get; private set; }
    public Clone_Skill clone { get; private set; }
    public SwordThrow_Skill swordThrow { get; private set; }

    public static SkillManager GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
     
    private void Start()
    {
        dash = GetComponent<Dash_Skill>();
        clone = GetComponent<Clone_Skill>();
        swordThrow = GetComponent<SwordThrow_Skill>();
    }
}
