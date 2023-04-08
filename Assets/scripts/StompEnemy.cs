using UnityEngine;

public class StompEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyHead")
        {
            AudioManager.Instance.PlayEnemyKill();
            Debug.Log("I just hit " + collision.gameObject.name);
            Debug.Log("STOMP");
            Destroy(collision.gameObject);
        }
    }
}
