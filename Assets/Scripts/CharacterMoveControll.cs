using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveControll : MoveControll
{
    [SerializeField]
    private Rigidbody2D body;
    [SerializeField]
    private float speed = 1;

    public override void Move(Vector3 direction)
    {
        body.velocity = direction * speed;
    }

    public override bool IsMoving()
    {
        return body.velocity.magnitude != 0;
    }
}
