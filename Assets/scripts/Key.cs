using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public Door Dooropen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Dooropen.Open();
            Debug.Log("Key triggered, Door opened");
            gameObject.SetActive(false);
        }
    }


}
