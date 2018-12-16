using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController :Singleton<GameController>
{
    [SerializeField]
    private Enemy chaserPrefab;

    private Player playerGameObject;

    private void Start()
    {
        playerGameObject = FindObjectOfType<Player>();
        if (playerGameObject == null)
        {
            Debug.LogError("No player GameObject was found!");
        }
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        foreach (Enemy enemy in enemies)
        {
            playerGameObject.AttachObserver(enemy);
        }
    }

    public GameObject CreateChaser()
    {
        GameObject chaserObject = Instantiate<GameObject>(chaserPrefab.gameObject);
        Enemy enemy = chaserObject.GetComponent<Enemy>();
        playerGameObject.AttachObserver(enemy);
        return chaserObject;
    }
}
