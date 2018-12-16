using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementBehaviour : Behaviour
{
    [SerializeField]
    protected MoveControll moveControll;

    private int counter = 0;
    private Vector3 direction;

    public override void Perform()
    {
        if (counter == 0)
        {
            counter = Random.Range(1, 100);
            direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0).normalized;
        } else
        {
            counter--;
        }
        moveControll.Move(direction);
    }
}
