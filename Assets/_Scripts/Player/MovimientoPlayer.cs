using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{

    [SerializeField] private int velocidad = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    

        if (Input.GetKey(KeyCode.W)) 
        {
            transform.Translate(Vector2.right * velocidad * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.down * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.up * velocidad * Time.deltaTime);
        }
    }
}
