using UnityEngine;

public class MovingPlatformPassenger : MonoBehaviour
{
    [SerializeField] private Transform feetPoint;
    [SerializeField] private Transform platformTopPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MovilPlatform")
        {
            float playerFeet = feetPoint.position.y;
            float platformTop = platformTopPoint.position.y;
            if (Mathf.Abs(playerFeet - platformTop) < 0.2f)
            {
                transform.SetParent(collision.transform);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "MovilPlatform")
        {
            transform.SetParent(null);
        }
    }

}
