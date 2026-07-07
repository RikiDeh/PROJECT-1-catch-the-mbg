using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject cubeSpawn;
    [SerializeField] private float spawnDelay = 0.2f;

    private bool isSpawning = true;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {

        while (isSpawning)
        {
            // Spawn the entity
            Instantiate(cubeSpawn, new Vector3(Random.Range(-8f, 8f), 8f, 0f), Quaternion.identity);

            // Wait for the current delay duration
            yield return new WaitForSeconds(spawnDelay);

        }
    }

}
