using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float speed = 3f;
    [SerializeField] private float distance = 5f;
    private float startZ;
    private bool movingForward = true;

    void Start()
    {
        startZ = transform.position.z;
    }

    void Update()
    {
        float direction = movingForward ? 1f : -1f;

        transform.Translate(Vector3.forward * direction * speed * Time.deltaTime, Space.World);

        if (movingForward && transform.position.z >= startZ + distance)
        {
            movingForward = false;
        }
        else if (!movingForward && transform.position.z <= startZ)
        {
            movingForward = true;
        }
    }
}
