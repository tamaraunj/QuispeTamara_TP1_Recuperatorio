using UnityEngine;
using UnityEngine.InputSystem;

public class MovingPlatform : MonoBehaviour
{

    [Header("Movement Settings")]
    [SerializeField] private float speed = 2f;
    [SerializeField] private float moveDistance = 10f;
    [SerializeField] private float changeDirectionTime = 2f;
    private bool movingForward = true; //la plataforma va desde el inicio hasta el destino
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool isWaiting = false;
    private float distanceTravelled = 0f;
    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + Vector3.right * moveDistance;
    }

    void Update()
    {
        if (isWaiting) return;

        float step = speed * Time.deltaTime;

        if (movingForward)
        {
            transform.Translate(Vector3.right * step, Space.World);
        }
        else
        {
            transform.Translate(Vector3.left * step, Space.World);
        }

        distanceTravelled += step;

        if (distanceTravelled >= moveDistance)
        {
            transform.position = movingForward ? targetPosition : startPosition;
            isWaiting = true;
            CancelInvoke("ChangeDirection");
            Invoke("ChangeDirection", changeDirectionTime);
        }
    }

    private void ChangeDirection()
    {
        movingForward = !movingForward;
        distanceTravelled = 0f;
        isWaiting = false;
    }
}
