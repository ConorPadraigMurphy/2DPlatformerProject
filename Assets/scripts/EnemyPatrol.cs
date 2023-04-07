using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    // Start is called before the first frame update
    private bool dirRight = true;
    public float speed = 2.0f;
    public Rigidbody2D rb;

    [SerializeField] float Rightpoint = 0f;
    [SerializeField] float Leftpoint  = 0f;



    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector2(-1, 1f);
        }

        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector2(1, 1f);

        }


        if (transform.position.x >= Rightpoint)
        {
            dirRight = false;
        }

        if (transform.position.x <= Leftpoint)
        {
            dirRight = true;
        }


        //     if (transform.localScale.x > 0)
        //         rb.velocity = new Vector2(speed, 0f);
        //     else
        //         rb.velocity = new Vector2(-speed, 0f);
    }
    // private void OnTriggerExit2D(Collider2D collision)
    // {
    //     // 2 colliders bounced off each other.
    //     // reverse the scale on the x value.
    //     transform.localScale = new Vector2(-(transform.localScale.x), 1f);
    // }
}
