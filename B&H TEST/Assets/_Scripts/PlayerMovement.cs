using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputActionReference Movement;
    [SerializeField] private float moveSpeed;
    private Rigidbody rb;
    private Vector2 movement => Movement.action.ReadValue<Vector2>();
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        rb.linearVelocity = new Vector3(movement.x, 0, movement.y);
    }

   
}
