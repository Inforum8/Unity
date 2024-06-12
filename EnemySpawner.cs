using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;
    private float[] arrPosx = {-2.5f, -1.3f, 0f, 1.3f, 2.5f};

    void Start()
    {
        foreach (float posX in arrPosx)
        {
            int index = UnityEngine.Random.Range(0, enemies.Length);
            SpawnEnemy(posX, index); // 현재 반복의 posX 사용
        }
    }

    void SpawnEnemy(float posX, int index)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
        Instantiate(enemies[index], spawnPos, Quaternion.identity);
    }
}
