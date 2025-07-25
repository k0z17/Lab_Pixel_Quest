using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{



    public Transform respawnPoint;
    public string nextLevel = "Level_2";
    public int coinCount = 0;
    public int _health = 3;
    public int _maxHealth = 3;
    private PlayerUIController _playerUIController;
    private void Start()
    {
        _playerUIController = GetComponent<PlayerUIController>();
        _playerUIController.UpdateHealth(_health, _maxHealth);



    }














    private void OnTriggerEnter2D(Collider2D other)
        
    { switch (other.tag)
        {
            case "Finish":
                {
                    string nextLevel = other.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;



                }
            case "Death":
                {
                    _health--;
                    _playerUIController.UpdateHealth(_health,_maxHealth);
                    if (_health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);


                    }
                    else
                    {
                        transform.position = respawnPoint.position;



                    }
                    break;




                    
                }







                
            case "Coin":
                {
                    coinCount++;
                    Destroy(other.gameObject);
                    break;


                }
            case "Health":
                if (_health < 3)
                {
                    _health++;
                    _playerUIController.UpdateHealth(_health,_maxHealth);
                    Destroy(other.gameObject);
                    



                }
                break;
            case "Respawn":
                {
                    respawnPoint.position = other.transform.Find("Point").position;
                    break;

                }








        }
           
        



    }













}

