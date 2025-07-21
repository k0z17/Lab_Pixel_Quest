using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Capsule
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;
    // Ground Check

    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    // Components
    private Rigidbody2D _rigidbody2D;
    // Forces
    public float jumpForce = 10f;
    public float fallForce = -1;
    private Vector2 gravityForce;
    // Water Check
    private bool _waterCheck;
    private string _waterTag = "Water";
    void Start()
    {
        gravityForce = new Vector2(0f, Physics2D.gravity.y);
        _rigidbody2D = GetComponent<Rigidbody2D>();



    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Water") { _waterCheck = true; }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Water") { _waterCheck = false; }
    }



    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(point: feetCollider.position, size: new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Vertical, angle: 0, groundMask);


        if (Input.GetKeyDown(KeyCode.Space) && (_waterCheck || _groundCheck))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);


        }
        if (_rigidbody2D.velocity.y < 0 && !_waterCheck)
        {
            _rigidbody2D.velocity += gravityForce * (fallForce * Time.deltaTime);



        }
        
            



















        
















    }
}
