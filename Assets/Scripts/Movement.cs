using UnityEngine;

//clase llamada movement que hereda de monobehavior
public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float force = 5f;
    // private ColorChange colorChange;
    private SpriteRenderer spriteRenderer;
    // private Rigidbody2D rigidbody2D;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        // rigidbody2D = GetComponent<Rigidbody2D>();
        // colorChange = GetComponent<ColorChange>();
    }

    // Update is called once per frame
    //método que Unity ejecuta continuamente mientras el juego está funcionando.
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            // rigidbody2D.AddForce(Vector2.up * force);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            // rigidbody2D.AddForce(Vector2.down * force);
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            // rigidbody2D.AddForce(Vector2.left * force);
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            //  colorChange.ChangeColor(Color.orange);
            // rigidbody2D.AddForce(Vector2.right * force);
        }

       
    }
}
