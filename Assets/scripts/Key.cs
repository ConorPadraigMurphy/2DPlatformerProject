using UnityEngine;

public class Key : MonoBehaviour
{
    public Door Dooropen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.Instance.KeyPickup();
            Dooropen.Open();
            Debug.Log("Key triggered, Door opened");
            gameObject.SetActive(false);
        }
    }


}
