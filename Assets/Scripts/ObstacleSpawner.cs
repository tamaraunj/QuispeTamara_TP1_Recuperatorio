using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private float spawnInterval = 3f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    private void SpawnObstacle()
    {
        Instantiate(spawnObject, transform.position, transform.rotation);
    }
}
