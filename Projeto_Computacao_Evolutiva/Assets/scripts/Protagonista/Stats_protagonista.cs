using UnityEngine;

public class Stats_protagonista : MonoBehaviour
{
    public float jumpForce;
    public float fallForce;
    public bool isJumping;

    public float maxY;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se o personagem está no chão
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            Jump();
        }

        
        if (transform.position.y <= maxY)
        {
            Reset_jump();
        } 
        else
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                fall();
            }
        }
    }

    void Jump()
    {
        gameObject.transform.position = new Vector2(transform.position.x, (transform.position.y) + 0.50f);
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.simulated = true;
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isJumping = true;
    }

    void Reset_jump()
    {
        rb.simulated = false;
        isJumping = false;
        gameObject.transform.position = new Vector2(transform.position.x, maxY);
    }

    void fall()
    {
        rb.velocity += Vector2.up * Physics2D.gravity.y * fallForce * Time.deltaTime;
    }
}
