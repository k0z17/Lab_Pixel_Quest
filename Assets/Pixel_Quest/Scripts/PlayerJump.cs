using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Capsule
    public float CapsuleHeigh = 0.25f;
    public float CapsuleRadius = 0.08f;
    // Ground Check

    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    // Components
    private Rigidbody2D _rigidbody2D;
    // Forces
    public float jumpForce = 10;

    // Sets gravity vector and connects components

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();



    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);


        }
















    }
}
