using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {



        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(xInput * speed, rb.velocity.y);
        float yInput = Input.GetAxis("Vertical");

        /*
        {
         
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += new Vector2(rb.velocity.x, 1);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position += new Vector2(rb.velocity.x, -1);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }
        {
        */


    }

}

         