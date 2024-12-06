using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject enemigo;
    [SerializeField] private int tiempoCreacion;
    [SerializeField] private int tiempoEspera;
    [SerializeField] private int tiempoDestruccion;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Enemigo",tiempoEspera ,tiempoCreacion);
        Destroy(gameObject,tiempoDestruccion);
    }

  

    private void Enemigo() 
    {
         Instantiate(enemigo,transform.position,transform.rotation);
        
    }
}
