using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    
    public float xMultiplier = 4;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");

        if (xMovement > 0) { _spriteRenderer.flipX = true; }
        else if (xMovement < 0) { _spriteRenderer.flipX = false; }



            _rigidbody2D.velocity = new Vector2(xMovement * xMultiplier, _rigidbody2D.velocity.y);
 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}

