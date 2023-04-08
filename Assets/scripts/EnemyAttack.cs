using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    [SerializeField] int Damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.Damagedealt(Damage);
            Debug.Log("Attacked Player - Trigger");
        }
    }
}
