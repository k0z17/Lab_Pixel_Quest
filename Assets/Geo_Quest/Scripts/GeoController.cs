using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;




    // Start is called before the first frame update
    void Start()

    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;

                }
        }
    }
    // Update is called once per frame
    void Update()
    {



        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(xInput * speed, rb.velocity.y);
        

        /*
        {
         
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }
        {
        */


    }

}

         