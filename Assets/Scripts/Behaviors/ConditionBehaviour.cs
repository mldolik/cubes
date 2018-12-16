using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ConditionBehaviour : MonoBehaviour
{
    public abstract bool EnterCondition(GameObject target);

    public abstract bool ExitCondition(GameObject target);

    public abstract void Perform(GameObject target);
}
