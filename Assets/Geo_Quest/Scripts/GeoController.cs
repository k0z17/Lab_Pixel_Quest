using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
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


        }

    }
}
