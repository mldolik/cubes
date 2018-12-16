using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float spawnTime = 10;
    [SerializeField]
    private float maxChildCount = 5;
    private int childCount = 0;

    private void Start()
    {
        StartCoroutine(StartSpawning());
    }

    private void SpawnChild()
    {
        GameObject chaserGO = GameController.Instance.CreateChaser();
        chaserGO.transform.SetPositionAndRotation(transform.position, transform.rotation);
        childCount++;
    }

    public IEnumerator StartSpawning()
    {
        while (childCount < maxChildCount)
        {
            yield return new WaitForSeconds(spawnTime);
            SpawnChild();
        }
    }
}
