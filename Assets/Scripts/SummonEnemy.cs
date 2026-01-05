using UnityEngine;
using UnityEngine.AI;

public class SummonEnemy : MonoBehaviour
{
    //initialising variables 
    public GameObject enemy;
    public int numberOfEnemies;
    public float minSpawnDistance = 5f;
    public float maxSpawnDistance = 50f;

    public Transform player;

    public void Update()
    {
        //checking amount of nemies
        int noEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        //if less enemies than max spawn more enemies
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
            //using random functions to create a unique and random spawn point for each enemy
            float angle = Random.Range(0f, 360f);
            float distance = Random.Range(minSpawnDistance, maxSpawnDistance);

            float x = Mathf.Cos(angle * Mathf.Deg2Rad) * distance;
            float z = Mathf.Sin(angle * Mathf.Deg2Rad) * distance;
            float y = player.position.y;
            return new Vector3(x, y, z);
        }

}
