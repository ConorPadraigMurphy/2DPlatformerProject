using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] int Damage;
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.Instance.Hurt();
            GameManager.Instance.Damagedealt(Damage);
            Debug.Log("Attacked Player - Trigger");
        }
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     //        if (collision.GetType().Equals(typeof(CapsuleCollider2D)))

    //     if (collision.gameObject.tag == "Player")
    //     {
    //         GameManager.Instance.Damagedealt(Damage);
    //         Debug.Log("Attacked Player - Collision");
    //     }
    // }
}
