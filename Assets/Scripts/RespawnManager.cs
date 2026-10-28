using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Checkpoint checkpoint;
    private Vector3 startPosition;

    private void Start()
    {
        if (player != null)
        {
            startPosition = player.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        if (player == null)
        {
            return;
        }

        Vector3 respawnPosition = startPosition;

        if (checkpoint != null && checkpoint.HasBeenReached())
        {
            respawnPosition = checkpoint.GetCheckpointPosition();
        }
        Rigidbody rb = player.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.position = respawnPosition;
        }
        else
        {
            player.position = respawnPosition;
        }


        Debug.Log("¡Respawn!");
    }
}
