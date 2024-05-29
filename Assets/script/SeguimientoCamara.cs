using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform muriel; // El objetivo a seguir, en este caso, el personaje "muriel"
    public Vector3 offset; // Desplazamiento de la cámara respecto al personaje
    public float suavizado = 0.125f; // Parámetro para suavizar el movimiento de la cámara

    void LateUpdate()
    {
        Vector3 posicionDeseada = muriel.position + offset;
        Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, suavizado);
        transform.position = posicionSuavizada;
    }
}


