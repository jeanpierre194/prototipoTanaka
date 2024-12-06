using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
  [SerializeField] private Jefe _Jefe;

    // Update is called once per frame
    void Update()
    {
        _Jefe = FindAnyObjectByType<Jefe>();
        transform.Translate(Vector2.up * 150 * Time.deltaTime, Space.Self);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo")) 
        {
            Destroy(collision.gameObject);

        }
        if (collision.CompareTag("Jefe"))
        {

            _Jefe.vida -= 1;
            Destroy(this.gameObject);


        }
    }
}
