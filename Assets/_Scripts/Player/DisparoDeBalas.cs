using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoDeBalas : MonoBehaviour
{

    [SerializeField] private GameObject Bala;
    [SerializeField] private float TiempoDisparo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo", 0,TiempoDisparo);
    }


    private void Disparo() 
    {

        Instantiate(Bala, transform.position, transform.rotation);
    }


}
