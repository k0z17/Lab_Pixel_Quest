using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "GeoLevel_2";
    public int coinCount = 0;
    private int _health = 3;
    private void OnTriggerEnter2D(Collider2D other)
        
    { switch (other.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;



                }
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break ;


                }
            case "Coin":
                {
                    coinCount++;
                    Destroy(other.gameObject);
                    break;


                }
            case "Health":
                {
                    _health++;
                    Destroy(other.gameObject);
                    break;



                }










        }
           
        



    }













}

