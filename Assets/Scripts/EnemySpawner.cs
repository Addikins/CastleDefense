using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Range(0, 5)] [SerializeField] float minRandomSpawnDelay = 1f;
    [Range(0, 5)] [SerializeField] float maxRandomSpawnDelay = 5f;
    [SerializeField] Attacker enemyPrefab;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minRandomSpawnDelay, maxRandomSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Attacker newAttacker =
            Instantiate(enemyPrefab, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }
}
