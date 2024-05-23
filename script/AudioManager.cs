using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClip bandaSonora; 
    public AudioClip fxButton;
    public AudioClip fxButtonAgradecimientos;
    public AudioClip fxAgradecimientos;
 
    public GameObject musicObj; 

    AudioSource _audioSource;
    AudioSource audioMusic;

    public static AudioManager Instance;

    void Awake()
    {
        if (Instance != null && Instance != this){
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       _audioSource = this.GetComponent<AudioSource>();
      
       audioMusic = musicObj.GetComponent<AudioSource>();
       audioMusic.clip = bandaSonora;
       audioMusic.loop = true;  
       audioMusic.volume = 0.2f;
       audioMusic.Play();
    }

    // Método para cambiar el clip de audio agradecimientos
    public void CambiarClipAgradecimientos()
    {
        DetenerMusica();
        audioMusic.clip = fxAgradecimientos;
        audioMusic.loop = false; // Detener la reproducción en bucle
        audioMusic.volume = 1f; // Establecer el volumen al máximo
        audioMusic.Play();
    }

    // Método para reanudar la música de fondo
    public void ReanudarMusica()
    {
        audioMusic.clip = bandaSonora;
        audioMusic.loop = true;
        audioMusic.volume = 0.2f;
        audioMusic.Play();
    }

    // Método para detener la música de fondo
    public void DetenerMusica()
    {
        audioMusic.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Método para hacer sonar clips de audio una vez
    public void SonarClipUnaVez(AudioClip ac)
    {
        _audioSource.PlayOneShot(ac);
    }
}
