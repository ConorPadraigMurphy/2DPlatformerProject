using UnityEngine;

public class BounceOffHead : MonoBehaviour
{
    [SerializeField] float springBoost = 0f;

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * springBoost, ForceMode2D.Impulse);
        }

    }
}