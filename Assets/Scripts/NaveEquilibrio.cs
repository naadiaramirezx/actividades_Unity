using UnityEngine;

public class NaveEquilibrio : MonoBehaviour
{
    public float fuerza = 8f;

    private Rigidbody2D rb;
    //referencia a componente ColorChange
    private ColorChange colorChange;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        colorChange = GetComponent<ColorChange>();
    }

    //pixed update: para aplicar la fuerza dentro del ciclo de actualización física
    void FixedUpdate()
    {
        //get axis raw: obtiene el valor de la dirección del eje en el eje x y y el eje y
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direccion = new Vector2(
            horizontal,
            vertical
        );

        
        rb.AddForce(direccion * fuerza);

        //cambiar el color si detecta mov
        if (horizontal !=0 || vertical != 0)
        {
            colorChange.ChangeColor(Color.magenta);
            
        } 
        else
        {
            colorChange.ChangeColor(Color.red);
        }

        //Permite que la nave 
        // acelere y responda a las fuerzas
    }
}