using UnityEngine;

public class PowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        //coded in video
        PlatformerMovement Playermove = other.transform.GetComponent<PlatformerMovement>();
        if (other.gameObject.CompareTag("Player"))
        {
            Playermove.SpeedBoostActivated();
            gameObject.SetActive(false);
        }
    }
}
