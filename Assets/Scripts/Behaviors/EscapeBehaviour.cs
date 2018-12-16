using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeBehaviour : InDistanceMoveBehaviour
{
    public override void Perform(GameObject target)
    {
        moveControll.Move((transform.position - target.transform.position).normalized);
    }
}
