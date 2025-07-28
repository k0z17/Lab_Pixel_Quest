using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLevel : MonoBehaviour
{
    public string nextLevel = "Home";
    private Rigidbody2D rb;
    private Renderer objRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
            rb = GetComponent<Rigidbody2D>();
            objRenderer = rb.GetComponent<Renderer>();
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;

                }


                


                

        }

    }

        // Update is called once per frame
        void Update()
    {
        
    }
}

