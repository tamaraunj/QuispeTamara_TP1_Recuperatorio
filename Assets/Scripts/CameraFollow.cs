using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target")]
    [SerializeField] private GameObject target_p;
    [Header("Camera Settings")]
    [SerializeField] private Vector3 offset = new Vector3(0, 6f, -8f);

    void LateUpdate()
    {
        if (target_p == null) return;

        transform.position = target_p.transform.position + offset;
        transform.LookAt(target_p.transform.position + Vector3.up);
    }
}
