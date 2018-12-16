using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Subject<Player>
{
    [SerializeField]
    private MoveControll moveControll;

    private void Update()
    {
        moveControll.Move(new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0).normalized);
        Notify(this);
    }
}
