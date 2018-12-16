using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InDistanceBehaviour : ConditionBehaviour
{
    [SerializeField]
    private float distance = 10;

    public override bool EnterCondition(GameObject target)
    {
        Vector3 localPosition = transform.position;
        Vector3 targetPosition = target.transform.position;

        //For reduction of counting square root of distance between positions each frame
        if (localPosition.x >= targetPosition.x - distance &&
            localPosition.x <= targetPosition.x + distance &&
            localPosition.y >= targetPosition.y - distance &&
            localPosition.y <= targetPosition.y + distance)
        {
            return Vector3.Distance(localPosition, targetPosition) <= distance;
        }
        return false;
    }

    public override bool ExitCondition(GameObject target)
    {
        return Vector3.Distance(transform.position, target.transform.position) > distance;
    }
}
