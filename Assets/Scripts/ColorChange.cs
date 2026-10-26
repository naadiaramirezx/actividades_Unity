using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Buscar un componente SpriteRenderer que pertenezca al mismo GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    
    // void Update()
    // {
    //     if (Input.GetKey(KeyCode.Space))
    //     {
    //         spriteRenderer.color = Color.red;
    //     }
        
    // }

    //funcion publica para poder utilizarla en otro script
    public void ChangeColor(Color nuevoColor)
    {
        spriteRenderer.color = nuevoColor;
    }
}
