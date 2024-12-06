using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jefe : MonoBehaviour
{

    public int vida = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida <= 0) 
        {

           Destroy(gameObject);
            SceneManager.LoadScene("Victoria");
        }
    }

   
}
