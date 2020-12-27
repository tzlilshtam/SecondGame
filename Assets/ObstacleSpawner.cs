
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;
    private float timeToSpawn = 2f;
    public float timeBetweenWaves = 1f;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            spawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
            score.scoreValue += 1;
        }
        
    }
    void spawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
        
    }
}
