using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed=10f;
    [SerializeField] private float sideSpeed=4f;
    [SerializeField] private float jumpForce=10f;
    private Rigidbody rb;
    private float horizontal;
    [SerializeField] private float minX = -3.0f; 
    [SerializeField] private float maxX = 3.0f;
    private bool isGrounded = true;
    private RaycastHit _raycastHit;
    public LayerMask groundLayer;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        Inputs();
    }
    void FixedUpdate()
    {
        Move();
    }

    private void Inputs()
    {
        horizontal = Input.GetAxis("Horizontal");
        
    }

    private void Move()
    {
        Vector3 constrainedPos = rb.position;
        constrainedPos.x = Mathf.Clamp(constrainedPos.x, minX, maxX);
        rb.position = constrainedPos;
        rb.linearVelocity = new Vector3(horizontal*sideSpeed, rb.linearVelocity.y, forwardSpeed);
    }

    
  

    
}

    
    
   
    
    

