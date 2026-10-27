using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;
    private float horizontal;
    private float vertical;
    private Rigidbody rb;
    private bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //flechas izq o der, A y D
        vertical = Input.GetAxisRaw("Vertical"); //flechas arriba y abajo, W y S

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void FixedUpdate()
    {
        Vector3 movement = (transform.forward * vertical + transform.right * horizontal).normalized; //normalized evita que el jugador se mueva más rápido en diagonal
        //Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;
        rb.linearVelocity = new Vector3(movement.x * speed, rb.linearVelocity.y, movement.z * speed);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
