using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnInterval = 1f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, transform.rotation);
    }
}
