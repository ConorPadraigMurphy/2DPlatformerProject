using UnityEngine;

public class EnemyFaller : MonoBehaviour
{
    // Start is called before the first frame update
    private bool dirDown = true;
    [SerializeField] float upSpeed = 0f;
    [SerializeField] float downSpeed = 0f;
    public Rigidbody2D rb;
    [SerializeField] float Highpoint = 0f;
    [SerializeField] float Lowpoint = 0f;



    void Update()
    {
        if (dirDown)
        {
            transform.Translate(Vector2.down * downSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.down * upSpeed * Time.deltaTime);
        }


        if (transform.position.y >= Highpoint)
        {
            dirDown = true;
        }

        if (transform.position.y <= Lowpoint)
        {
            dirDown = false;
        }

    }
}
