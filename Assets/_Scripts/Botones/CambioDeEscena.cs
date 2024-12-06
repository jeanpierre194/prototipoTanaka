using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public void Menu()
    {

        SceneManager.LoadScene("Elegir");
    }

    public void Mujer() 
    {

        SceneManager.LoadScene("MujerEscena");
    }

    public void Hombre()
    {

        SceneManager.LoadScene("HombreEscena");
    }

}
