using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalaEnemigo : MonoBehaviour
{
    private Vida _Vida;
    private Slider _Slider;
    void Start()
    {
        _Vida = FindAnyObjectByType<Vida>();
        _Slider = FindAnyObjectByType<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * 40 * Time.deltaTime, Space.Self);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _Vida.vida -= 1;
            _Slider.value -= 0.1f;

        }
    }
}
