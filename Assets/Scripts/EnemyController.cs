using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    Rigidbody2D rb;
    [SerializeField] 
    Transform rayPos;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(rayPos.position, new Vector3(speed, 0f, 0f), 0.1f);

        if (hit.collider != null && !hit.collider.CompareTag("Player"))
        {            
            speed = -speed;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y,transform.localScale.z );             
        }
        
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
    }

    
}
