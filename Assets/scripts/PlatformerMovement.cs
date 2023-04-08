using System.Collections;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    private bool dirRight = true;
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float runSpeedBoost = 2f;
    [SerializeField] float jumpSpeed = 5f;
    float xBound = 112f;
    float yBound = 100f;
    private Vector3 respawn;
    [SerializeField] GameObject fallDetector;
    [SerializeField] Animator animate;

    //private Animation animate;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //animate = gameObject.GetComponent<Animation>();
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

    public void SpeedBoostActivated()
    {
        //Coded in video
        AudioManager.Instance.PlayPowerUpPickup();
        runSpeed += runSpeedBoost;
        StartCoroutine(SpeedBoostDeactivate());
    }

    IEnumerator SpeedBoostDeactivate()
    {
        //coded in video
        yield return new WaitForSeconds(5.0f);
        runSpeed -= runSpeedBoost;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            transform.localScale = new Vector2(1.5f, 1.5f);
        }

        else if (Input.GetKeyDown(KeyCode.A) == true)
        {
            transform.localScale = new Vector2(-1.5f, 1.5f);
        }

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        animate.SetBool("isRunning", horizontalInput != 0);
        float xOffset = horizontalInput * runSpeed * Time.deltaTime;
        float xPosition = Mathf.Clamp(rb.position.x + xOffset, -xBound, xBound);
        rb.position = new Vector2(xPosition, rb.position.y);
        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space) == true && isGrounded == true)
        {
            Vector2 jumpVelToAdd = new Vector2(0f, jumpSpeed);
            rb.velocity += jumpVelToAdd;
            isGrounded = false;
        }
    }
}
