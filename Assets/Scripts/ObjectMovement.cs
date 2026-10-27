using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float speed = 3f;
    [SerializeField] private float destroyAfter = 5f;
    void Start()
    {
        Destroy(gameObject, destroyAfter);
    }
    void Update()
    {
        transform.Translate(0,0, speed*Time.deltaTime);
    }
}
