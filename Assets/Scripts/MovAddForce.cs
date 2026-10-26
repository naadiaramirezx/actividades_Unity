using UnityEngine;

public class AddForce : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float force = 5f;
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody2D.AddForce(Vector2.up * force);
            spriteRenderer.color = Color.red;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody2D.AddForce(Vector2.down * force);
            spriteRenderer.color = Color.yellow;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2D.AddForce(Vector2.left * force);
            spriteRenderer.color = Color.orange;
        }
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2D.AddForce(Vector2.right * force);
            spriteRenderer.color = Color.orange;
        }
        
    }
}
