using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class cambiarNivel : MonoBehaviour
{
    public void CambiarLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void Continuar()
    {

    }
    public void Salir()
    {
        Application.Quit();
    }
}
