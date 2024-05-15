using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicioscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verificar si se presiona la tecla Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Cargar la escena "0menu"
            SceneManager.LoadScene("0menu");
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("1circo");
    }

    public void AgradecimientosGame()
    {
        SceneManager.LoadScene("agradecimientos");
    }

    public void ExitGame()
    {
        Debug.Log("salida");
        Application.Quit();
    }
}

