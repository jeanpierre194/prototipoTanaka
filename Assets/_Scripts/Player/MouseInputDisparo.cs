using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputDisparo : MonoBehaviour
{

 
    // Update is called once per frame
    void Update()
    {
         Vector3  mousePosicion = Camera.main.ScreenToWorldPoint( Input.mousePosition );
         
         Vector2 direccion = mousePosicion - transform.position;

        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angulo);
    }
}
