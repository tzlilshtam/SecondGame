
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{


    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;

    void Start()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for( int i = 0; i < spawnPoints.Length; i++)
        {
            if(randomIndex != i)
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position , Quaternion.identity);
            }
        }
    }

   
    void Update()
    {
        
    }
}
