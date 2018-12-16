using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Observer<Player>
{
    [SerializeField]
    private Behaviour defaultBehaviour;
    [SerializeField]
    private ConditionBehaviour[] possibleNextBehaviours;

    private int currentBehaviorPointer = -1;
    private Player playerObject;

    private void FixedUpdate()
    {
        if (playerObject != null)
        {
            if (currentBehaviorPointer != -1 && possibleNextBehaviours[currentBehaviorPointer].ExitCondition(playerObject.gameObject))
            {
                currentBehaviorPointer = -1;
            }
            if (currentBehaviorPointer == -1)
            {
                for (int i = 0; i < possibleNextBehaviours.Length; i++)
                {
                    if (possibleNextBehaviours[i].EnterCondition(playerObject.gameObject))
                    {
                        currentBehaviorPointer = i;
                        possibleNextBehaviours[currentBehaviorPointer].Perform(playerObject.gameObject);
                        return;
                    }
                }
            }
            else
            {
                possibleNextBehaviours[currentBehaviorPointer].Perform(playerObject.gameObject);
                return;
            }
        }
        defaultBehaviour.Perform();
    }

    public override void OnSubjectUpdate(Player newState)
    {
        playerObject = newState;
    }
}
