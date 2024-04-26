using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone_Skill : Skill
{
    [SerializeField]
    private GameObject clocePrefab;
    [SerializeField]
    private float cloneDuration;
    [Space]
    [SerializeField]
    private bool canAttack;
    public void CreateClone(Transform _clonePosition)
    {
        GameObject newClone = Instantiate(clocePrefab);

        newClone.GetComponent<Clone_Skill_Controller>().SetupCloen(_clonePosition, cloneDuration, canAttack);
    }


}