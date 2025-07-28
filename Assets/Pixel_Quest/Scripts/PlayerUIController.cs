using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{

    public Image HeartImage;
    private TextMeshProUGUI _text;
    // Start is called before the first frame update
    public void StartUI()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        _text = GameObject.Find("Cointext").GetComponent<TextMeshProUGUI>();


    }

   
    
    
    
    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)
    

    
    {
       HeartImage.fillAmount = currentHealth / maxHealth;
        



    }
    public void UpdateCoin(string newText) { _text.text = newText; }
    
       

    




}

