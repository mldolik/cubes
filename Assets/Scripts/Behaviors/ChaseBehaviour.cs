using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBehaviour : InDistanceMoveBehaviour
{
    public override void Perform(GameObject target)
    {
        moveControll.Move((target.transform.position - transform.position).normalized);
    }
}
