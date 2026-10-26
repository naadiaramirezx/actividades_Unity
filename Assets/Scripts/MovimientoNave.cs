using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float velocidad = 5f;
    
    private ColorChange colorChange;
    void Start()
    {
       
        colorChange = GetComponent<ColorChange>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            colorChange.ChangeColor(Color.red);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            colorChange.ChangeColor(Color.yellow);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            colorChange.ChangeColor(Color.orange);
        }
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            colorChange.ChangeColor(Color.orange);
        }
        
    }
}
