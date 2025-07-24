using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class PlayerUIController : MonoBehaviour
{

    public UnityEngine.UI.Image HeartImage;
    // Start is called before the first frame update
    private void Start()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();



    }

   
    
    
    
    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)
    

    
    {
       HeartImage.fillAmount = currentHealth / maxHealth;
        



    }





}

