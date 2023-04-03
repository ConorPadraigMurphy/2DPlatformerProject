using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerHealth playerHealth;
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.damagedealt(1);
            Debug.Log("Attacked Player - Trigger");
        }
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     //        if (collision.GetType().Equals(typeof(CapsuleCollider2D)))

    //     if (collision.gameObject.tag == "Player")
    //     {
    //         playerHealth.damagedealt(1);
    //         Debug.Log("Attacked Player - Collision");
    //     }
    //}
}
