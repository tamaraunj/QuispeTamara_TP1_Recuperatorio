using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector3 checkpointPosition;
    private bool checkpointReached = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkpointPosition = other.transform.position;
            checkpointReached = true;

            Debug.Log("¡Checkpoint alcanzado! Posición guardada.");
        }
    }
    public bool HasBeenReached()
    {
        return checkpointReached;
    }

    public Vector3 GetCheckpointPosition()
    {
        return checkpointPosition;
    }
}
