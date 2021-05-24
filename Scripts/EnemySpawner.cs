using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy[] enemyPrefabs;
    Enemy enemy;
    public float timer = 30.0f;

    void Start()
    {
        Destroy(gameObject, timer);
    }

    public void Spawn()
    {
        if (enemy == null)
        {
            var index = Random.Range(0, enemyPrefabs.Length);
            enemy = Instantiate(enemyPrefabs[index], transform.position, transform.rotation);
        }
    }
  
}
