using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int maxhealth = 6;

    // Start is called before the first frame update
    void Start()
    {
        
        health = maxhealth;
    }

    void update(){
        
    }

    

    public void damagedealt(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    } 
}
