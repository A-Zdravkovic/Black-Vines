using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    Rigidbody2D rb; // Reference to the rigidbody attached to this gameobject
    public float speed; // The speed of our character
    public float jump; // Jump force
    private float horizontal;
    public Transform groundCheckObj; // Position to check for ground
    public Animator playerMovment; // Animator reference
    public LayerMask groundLayer; // Layer to check for ground
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Assign the Horizontal axis value to the variable called horizontal
        horizontal = Input.GetAxis("Horizontal");

        // Check if player is grounded using Raycast
        isGrounded = Physics2D.Raycast(groundCheckObj.position, Vector2.down, 0.5f, groundLayer); // Increased raycast length

        if (Input.GetButtonDown("Jump") && isGrounded) // Jump only if grounded
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            // Play running animation
            GetComponent<Animation>().Play("MCRunningRight");
        }
    }

    // Updates based on our physics updating
    private void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(horizontal, 0) * Time.deltaTime * speed;
        moveDirection.y = rb.velocity.y;

        rb.velocity = moveDirection;
    }
}
