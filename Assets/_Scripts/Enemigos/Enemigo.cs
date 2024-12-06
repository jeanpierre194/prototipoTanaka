using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
     private Transform Player;
    [SerializeField] private int velocidad = 5;

    private void Start()
    {
        Player = FindAnyObjectByType<MovimientoPlayer>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direccion = Player.position - transform.position;
        direccion.Normalize();


        transform.position = Vector2.MoveTowards(transform.position, Player.position, velocidad * Time.deltaTime);
    }
}
