using UnityEngine;

public class ImpulsoPelota : MonoBehaviour
{
    // Start is called once before the 

    public float fuerza = 5f;
    private Rigidbody2D rb;

    //funcion del awake: se ejecuta antes de comenzar el juego, se ejecuta una sola vez
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        //get key down cuando queramos aplicar un solo impulso por pulsación, no repetirlo 
        {
            rb.AddForce(
                Vector2.up * fuerza, 
                ForceMode2D.Impulse //impulso
            );
        }
        
    }
}
