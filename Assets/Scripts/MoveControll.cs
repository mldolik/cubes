using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveControll : MonoBehaviour
{
    public abstract void Move(Vector3 direction);

    public abstract bool IsMoving();
}
