using UnityEngine;
using UnityEngine.AI;

public class SummonEnemy : MonoBehaviour
{
    public GameObject enemy;
    public int numberOfEnemies;
    public float minSpawnDistance = 5f;
    public float maxSpawnDistance = 50f;

    public Transform player;

    public void Update()
    {
        int noEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;


        if (noEnemies < numberOfEnemies)
        {
            for (int x = 0; x < numberOfEnemies; x++)
            {
                Vector3 spawnPos = GetRandomSpawn();
                Instantiate(enemy, spawnPos, Quaternion.identity);
            }
        }
    }

        Vector3 GetRandomSpawn()
        {
            float angle = Random.Range(0f, 360f);
            float distance = Random.Range(minSpawnDistance, maxSpawnDistance);

            float x = Mathf.Cos(angle * Mathf.Deg2Rad) * distance;
            float z = Mathf.Sin(angle * Mathf.Deg2Rad) * distance;
            float y = player.position.y;
            return new Vector3(x, y, z);
        }

}
