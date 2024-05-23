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
          if (Input.GetKeyDown(KeyCode.Space))
        {
            // Verificar si estamos en la escena "cinematica"
            if (SceneManager.GetActiveScene().name == "cinematica")
            {
                SceneManager.LoadScene("1circo");
            }
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("cinematica");
        
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

    public void SuenaBoton(){
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButton);
    }
    public void SuenaBeso(){
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonAgradecimientos);
    }
}

