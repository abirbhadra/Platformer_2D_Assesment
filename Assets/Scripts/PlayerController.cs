using UnityEngine;

using System.Collections;
public class PlayerController : MonoBehaviour
{
    private float horizontal;
    
    Rigidbody2D rb;
    [SerializeField]
    private float speed = 0.5f;
    [SerializeField]
    private float jumpForce = 250f;
    [SerializeField]
    private bool isGrounded;
    SpriteRenderer spriteRenderer;
    [SerializeField]
    private Animator player_Animator;
    public PlayerHealth playerHealth;
    [SerializeField]
    public bool playerwin = false;


    [SerializeField]
    private bool playergettingdamage = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.collider.CompareTag("Enemy"))
        {
            playergettingdamage = true;
        }
        if(collision.collider.CompareTag("Exit"))
        {
            playerwin = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
        if (collision.collider.CompareTag("Enemy"))
        {
            playergettingdamage = false;
        }
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        player_Animator.SetFloat("Speed", Mathf.Abs(horizontal));
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true) 
        {
            player_Animator.SetBool("isJumping", true);
            rb.AddForce(Vector3.up * jumpForce);

        }
        if(isGrounded == false)
        {
            player_Animator.SetBool("isJumping", false);
        }
        Flip();

        if(playergettingdamage == true)
        {
            playerHealth.ReduceHealth();
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(horizontal * speed, rb.linearVelocity.y);
    }

    private void Flip()
    {
        if(horizontal > 0) 
    {
            transform.localScale = new Vector3(3, 3, 1); 
        }
    else if (horizontal < 0) 
        {
            transform.localScale = new Vector3(-3, 3, 1); 
        }
    }


}

