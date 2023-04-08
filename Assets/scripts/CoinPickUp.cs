using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    private GameManager GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.gameObject.tag == "Player")
        {
            AudioManager.Instance.PlaycoinPickup();
            Debug.Log("Coin Collected");
            Destroy(gameObject);
            GameManager.updateScore(1);
            Debug.Log(GameManager.score);
        }
    }
}
