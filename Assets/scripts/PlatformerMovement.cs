using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{

    [SerializeField] float runSpeed = 5;
    [SerializeField] float jumpSpeed = 5;
    float xBound = 112f;
    float yBound = 100f;
    public Vector3 respawn;
    public GameObject fallDetector;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawn = transform.position;
    }

    public bool isGrounded;

    void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FallenOffmap")
        {
            GameManager.Instance.Damagedealt(1);
            transform.position = respawn;
        }
    }


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float xOffset = horizontalInput * runSpeed * Time.deltaTime;
        float xPosition = Mathf.Clamp(transform.position.x + xOffset, -xBound, xBound);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space) == true && isGrounded == true)
        {
            Vector2 jumpVelToAdd = new Vector2(0f, jumpSpeed);
            rb.velocity += jumpVelToAdd;
            isGrounded = false;

        }
    }
}
